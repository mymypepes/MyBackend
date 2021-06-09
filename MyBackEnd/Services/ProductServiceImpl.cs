using MyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Services
{
    public class ProductServiceImpl : ProductServices
    {
        public Product Create(Product product)
        {
            Debug.WriteLine("Product Info");
            Debug.WriteLine("Id:" + product.Id);
            Debug.WriteLine("Name:" + product.Name);
            Debug.WriteLine("Price:" + product.Price);
            Debug.WriteLine("Quantity:" + product.Quantity);
            Debug.WriteLine("Status:" + product.Status);
            product.Price = 9999;
            return product;

        }

        public void Delete(string id)
        {
            Debug.WriteLine("Delete Id:" + id);
        }

        public Product Find()
        {
           return new Product
            {
               Id = "v01",
               Name = "van",
               Price = 45,
               Quantity = 2,
               Status = true
            };
        }

        public List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = "v01",
                    Name = "van",
                    Price = 45,
                    Quantity = 2,
                    Status = true
                },
                    new Product
                {
                    Id = "v02",
                    Name = "mynho",
                    Price = 100,
                    Quantity = 1,
                    Status = false
                },
            };
        }

        public bool Login(Login request)
        {
            string username = request.userName;
            string password = request.passWord;
            if (username == null || password == null)
            {
                return false;
            }
            else if("abc".Equals(username) && "def".Equals(password))
            {
                return true;
            }
            return false;
        }

        public List<Product> Search(double min, double max)
        {
            return FindAll().Where(p => p.Price >= min && p.Price <= max).ToList();
        }

        public Product Update(Product product)
        {
            Debug.WriteLine("Product Info - Update");
            Debug.WriteLine("Id:" + product.Id);
            Debug.WriteLine("Name:" + product.Name);
            Debug.WriteLine("Price:" + product.Price);
            Debug.WriteLine("Quantity:" + product.Quantity);
            Debug.WriteLine("Status:" + product.Status);
            product.Name = "aaaa";
            product.Quantity = 77;
            product.Price = 888;
            product.Status =!product.Status;
            return product;
        }
    }
}
