using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RPBD_Shutov_Lab3;

public enum DBMS
{
    [DisplayDBMS("SQLite")]
    SQLite,
    [DisplayDBMS("PostgreSQL")]
    PostgreSQL,
    [DisplayDBMS("SQL Server")]
    SQLServer,
}

#region ENUM DBMS EXT
[AttributeUsage(AttributeTargets.Field)]
public class DisplayDBMS : Attribute
{
    private string text;
    public DisplayDBMS(string text)
    {
        this.text = text;
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }
}

public static class DBMSExt
{
    public static string GetDBMSName(this DBMS en)
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