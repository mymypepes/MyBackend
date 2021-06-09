using MyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Services
{
    public interface ProductServices
    {
        public Product Find();
        public List<Product> FindAll();

        public List<Product> Search(double min, double max);

        public Product Create(Product product);
        public Product Update(Product product);
        public void Delete(string id);

        public bool Login(Login request);



    }
}
