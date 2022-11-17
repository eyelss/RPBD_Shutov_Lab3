using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.Sqlite;
using System.Data.Common;
using Npgsql;
using System.Reflection;

namespace RPBD_Shutov_Lab3;

public class ShopContext : DbContext
{

    public string DbPath { get; }
    public DBMS DbType { get; set; }

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public ShopContext()
    {
        ConfigureSources();
    }

    public ShopContext(DBMS type) : this()
    {
        DbType = type;
    }

    private List<string> dbmsList;
    public List<string> GetAllDBMS { get => dbmsList; }
    string configFileName = "appsettings.json";
    JsonConnectionParse? conf;
    private void ConfigureSources()
    {
        conf = new JsonConnectionParse(File.ReadAllText(configFileName));
        dbmsList = conf.data.Select(x => x.Key).ToList();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        var connString = conf.GetConnection(DbType.GetDBMSName());
        string sqlString = "";
        DbConnectionStringBuilder builder;
        if (DbType == DBMS.SQLite)
        {
            builder = new SqliteConnectionStringBuilder();
            foreach (var i in connString)
                builder[i.Key] = i.Value;
            sqlString = builder.ToString();
            optionsBuilder.UseSqlite(sqlString);
        }
        if (DbType == DBMS.PostgreSQL)
        {
            builder = new NpgsqlConnectionStringBuilder();
            foreach (var i in connString)
                builder[i.Key] = i.Value;
            sqlString = builder.ToString();
            optionsBuilder.UseNpgsql(sqlString);
        }
        if (DbType == DBMS.SQLServer)
        {
            builder = new SqlConnectionStringBuilder();
            foreach (var i in connString)
                builder[i.Key] = i.Value;
            sqlString = builder.ToString();
            optionsBuilder.UseSqlServer(sqlString);
        }

        optionsBuilder.UseLazyLoadingProxies();
    }
}

public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public ProductStatus Status { get; set; }

    [Required]
    public virtual Customer Customer { get; set; }

    public override string ToString() => $"{Name} [{Id.ToString().Split('-')[0]}]";
}

public enum ProductStatus
{
    [DisplayStatusProduct("SELLED")]
    SELLED,
    [DisplayStatusProduct("CANCELED")]
    CANCELED,
    [DisplayStatusProduct("ACTIVE")]
    ACTIVE,
}

#region ENUM PRODUCT STATUS EXT
[AttributeUsage(AttributeTargets.Field)]
public class DisplayStatusProduct : Attribute
{
    private string text;
    public DisplayStatusProduct(string text)
    {
        this.text = text;
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }
}

public static class ProductStatusExt
{
    public static string GetStatusString(this ProductStatus en)
    {
        Type t = en.GetType();
        MemberInfo[] memInfo = t.GetMember(en.ToString());
        if (memInfo != null && memInfo.Length > 0)
        {
            object[] attrs = memInfo[0].GetCustomAttributes(typeof(DisplayStatusProduct), false);
            if (attrs != null && attrs.Length > 0)
                return ((DisplayStatusProduct)attrs[0]).Text;
        }

        return en.ToString();
    }
}
#endregion

public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }

    public virtual List<Wallet> Wallets { get; set; } = new();

    public override string ToString() => $"{Name} [{Id.ToString().Split('-')[0]}]";
}

public class Wallet
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }
    [Required]
    public decimal Money { get; set; }

    [Required]
    public virtual User User { get; set; }
}

[Comment("Purchases by users history")]
public class Purchase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public virtual User User { get; set; }

    [Required]
    public virtual Product Product { get; set; }
}

[Comment("Users who sells products")]
public class Customer
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public virtual User User { get; set; }

    public virtual List<Product> Products { get; set; }
}

[Comment("User's choosing of products")]
public class Basket
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public virtual User User { get; set; }
    [Required]
    public virtual Product Product { get; set; }

    public override string ToString() => $"{User.Name}:{Product.Name} [{Id.ToString().Split('-')[0]}]";
}