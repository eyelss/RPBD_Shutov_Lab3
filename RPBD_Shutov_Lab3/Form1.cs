using System.ComponentModel;

namespace RPBD_Shutov_Lab3
{
    public partial class Form1 : Form
    {
        private ShopContext shop;
        public Form1()
        {
            InitializeComponent();
            shop = new ShopContext();
            comboBox1.DataSource = shop.GetAllDBMS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem as string == "SQLite")
            {
                shop = new ShopContext(DBMS.SQLite);
            }
            if (comboBox1.SelectedItem as string == "SQL Server")
            {
                shop = new ShopContext(DBMS.SQLServer);
            }
            if (comboBox1.SelectedItem as string == "PostgreSQL")
            {
                shop = new ShopContext(DBMS.PostgreSQL);
            }
            shop.Database.EnsureCreated();
            InitQuery();
            DisplayComboBoxes();
            DisplayListBoxes();
        }

        private IQueryable<User> usersQuery;
        private IQueryable<Basket> basketsQuery;
        private IQueryable<Product> productsQuery;
        private BindingList<User> _users;


        private void InitQuery()
        {
            usersQuery = shop.Users;
            basketsQuery = shop.Baskets;
            productsQuery = shop.Products;
        }

        private void DisplayListBoxes(bool users = false, bool baskets = false, bool products = false)
        {
            if (!users && !baskets && !products)
                (users, baskets, products) = (true, true, true);

            if (users)
            {
                usersListBox.DataSource = usersQuery.ToList();
            }
            if (baskets)
            {
                basketsListBox.DataSource = basketsQuery.ToList();
            }
            if (products)
            {
                productsListBox.DataSource = productsQuery.ToList();
            }
        }

        private void DisplayComboBoxes(bool baskets = false, bool products = false)
        {
            if (!baskets && !products)
                (baskets, products) = (true, true);

            if (baskets)
            {
                userId.DataSource = usersQuery.ToList();
                productId.DataSource = productsQuery.ToList();
            }
            if (products)
            {
                productStatus.DataSource = allProductStatuses;
                customerId.DataSource = usersQuery.Where(user => shop.Customers.Select(customer => customer.User).Contains(user)).ToList();
            }
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = usersListBox.SelectedItem as User;
            if (user == null)
                return;
            userIdTextBox.Text = user.Id.ToString();
            userName.Text = user.Name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            shop.SaveChanges();

            DisplayComboBoxes();
            DisplayListBoxes();
        }

        private ProductStatus[] allProductStatuses = { ProductStatus.SELLED, ProductStatus.CANCELED, ProductStatus.ACTIVE };
        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = productsListBox.SelectedItem as Product;
            if (product == null)
                return;
            productIdTextBox.Text = product.Id.ToString();
            productName.Text = product.Name;
            productDescription.Text = product.Description;
            productPrice.Text = product.Price.ToString();
            productStatus.SelectedItem = allProductStatuses.First(x => x == product.Status);
            customerId.SelectedItem = product.Customer.User;
        }

        private void basketsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var basket = basketsListBox.SelectedItem as Basket;
            if (basket == null)
                return;
            BasketIdTextBox.Text = basket.Id.ToString();
            productId.SelectedItem = basket.Product;
            userId.SelectedItem = basket.User;
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            var user = usersListBox.SelectedItem as User;
            user.Name = userName.Text;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = userName.Text,
            };
            shop.Users.Add(user);
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            var user = usersListBox.SelectedItem as User;
            shop.Users.Remove(user);
        }

        private void filterUser_Click(object sender, EventArgs e)
        {
            var inputName = userName.Text;
            usersQuery = shop.Users.Where(user => inputName == "" ? true : user.Name == inputName);
            DisplayListBoxes(users: true);
        }

        private void filterByUser_Click(object sender, EventArgs e)
        {
            var user = userId.SelectedItem as User;
            basketsQuery = shop.Baskets.Where(basket => basket.User == user);
            DisplayListBoxes(baskets: true);
        }

        private void filterByProduct_Click(object sender, EventArgs e)
        {
            var product = productId.SelectedItem as Product;
            basketsQuery = shop.Baskets.Where(basket => basket.Product == product);
            DisplayListBoxes(baskets: true);
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            shop.Database.EnsureDeleted();
        }

        private void editBasket_Click(object sender, EventArgs e)
        {
            var basket = basketsListBox.SelectedItem as Basket;
            basket.User = userId.SelectedItem as User;
            basket.Product = productId.SelectedItem as Product;
        }

        private void addBasket_Click(object sender, EventArgs e)
        {
            var basket = new Basket
            {
                User = userId.SelectedItem as User,
                Product = productId.SelectedItem as Product
            };
            shop.Baskets.Add(basket);
        }

        private void deleteBasket_Click(object sender, EventArgs e)
        {
            var basket = basketsListBox.SelectedItem as Basket;
            shop.Baskets.Remove(basket);
        }

        private void editProduct_Click(object sender, EventArgs e)
        {
            var product = productsListBox.SelectedItem as Product;
            product.Name = productName.Text;
            product.Description = productDescription.Text;
            product.Price = decimal.Parse(productPrice.Text);
            product.Status = (ProductStatus)productStatus.SelectedItem;
            var customerUser = customerId.SelectedItem as User;
            product.Customer = shop.Customers.First(cust => cust.User == customerUser);
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            var customerUser = customerId.SelectedItem as User;
            var product = new Product
            {
                Name = productName.Text,
                Description = productDescription.Text,
                Price = decimal.Parse(productPrice.Text),
                Status = (ProductStatus)productStatus.SelectedItem,
                Customer = shop.Customers.First(cust => cust.User == customerUser),
            };
            shop.Products.Add(product);
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            var product = productsListBox.SelectedItem as Product;
            shop.Products.Remove(product);
        }

        private void filterByStatus_Click(object sender, EventArgs e)
        {
            var status = (ProductStatus)productStatus.SelectedItem;
            productsQuery = shop.Products.Where(prod => prod.Status == status);
            DisplayListBoxes(products: true);
        }

        private void filterByCustomer_Click(object sender, EventArgs e)
        {
            var customerUser = customerId.SelectedItem as User;
            productsQuery = shop.Products.Where(prod => prod.Customer.User == customerUser);
            DisplayListBoxes(products: true);
        }

        private void filterProduct_Click(object sender, EventArgs e)
        {
            var name = productName.Text;
            var desc = productDescription.Text;
            decimal price;
            bool priceComparable = decimal.TryParse(productPrice.Text, out price);
            productsQuery = shop.Products
                .Where(prod => name == "" ? true : prod.Name == name)
                .Where(prod => desc == "" ? true : prod.Description == desc)
                .Where(prod => !priceComparable || prod.Price == price);
            DisplayListBoxes(products: true);
        }

        private void exampleDataButton_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = "Alex",
                Wallets =
                {
                    new Wallet
                    {
                        Money = 100
                    }
                }
            };

            var customer1 = new Customer
            {
                User = new User
                {
                    Name = "John",
                    Wallets = { }
                }
            };

            var customer2 = new Customer
            {
                User = new User
                {
                    Name = "Tom",
                    Wallets =
                    {
                        new Wallet
                        {
                            Money = 200
                        },
                        new Wallet
                        {
                            Money = 12
                        }
                    }
                }
            };

            var product1 = new Product
            {
                Name = "Car",
                Description = "Cool car by the way",
                Status = ProductStatus.ACTIVE,
                Customer = customer1,
                Price = 50000
            };

            var product2 = new Product
            {
                Name = "Water",
                Description = "There is no taste",
                Status = ProductStatus.CANCELED,
                Customer = customer1,
                Price = 10
            };

            var product3 = new Product
            {
                Name = "Pen",
                Description = "Now you can write!",
                Status = ProductStatus.SELLED,
                Customer = customer2,
                Price = 1
            };

            var basket = new Basket
            {
                Product = product3,
                User = user
            };

            shop.AddRange(user, customer1, customer2, product1, product2, product3, basket);
            shop.SaveChanges();
            InitQuery();
            DisplayListBoxes();
            DisplayComboBoxes();
        }
    }
}