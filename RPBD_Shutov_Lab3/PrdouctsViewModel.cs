using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPBD_Shutov_Lab3
{
    public class ProductsViewModel
    {
        private Product product;
        private Customer customer;

        public ProductsViewModel(Product product, Customer customer) =>
            (this.product, this.customer) = (product, customer);

        public decimal Price
        {
            get
            {
                return product.Price;
            }
            set 
            { 
                product.Price = value;
            }
        }

        public string OwnerName
        {
            get
            {
                return customer.User.Name;
            }
            set
            {
                customer.User.Name = value;
            }
        }

        public string ProductName
        {
            get
            {
                return product.Name;
            }
            set 
            { 
                product.Name = value; 
            }
        }

        public string ProductDescription
        {
            get
            {
                return product.Description;
            }
            set
            {
                product.Description = value;
            }
        }

        public string GetStatus()
        {
            return product.Status.GetStatusString();
        }

        public void SetStatus(ProductStatus type)
        {
            product.Status = type;
        }

        public override string ToString()
        {
            return $"{OwnerName}: {ProductName}";
        }
    }
}
