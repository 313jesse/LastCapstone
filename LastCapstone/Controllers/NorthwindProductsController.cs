using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LastCapstone.Models;
using Newtonsoft.Json;

namespace LastCapstone.Controllers
{

    public class NorthwindProductsController : ApiController
    {
        [HttpGet]
        public List<Product> Products(int productID, string productName)
        {
            NorthwindEntities ORM = new NorthwindEntities();

            List<Product> ProdList = ORM.Products.ToList();

            return ORM.Products.Select(x => x.ProductID)(productName != null).ToList);
        }
        [HttpGet]
        public List<Product> GetProduct(int productID)
        {
            NorthwindEntities ORM = new NorthwindEntities();
            List<Product> IDList = ORM.Products.Where(x => x.ProductID == productID).ToList();
            return IDList;
        }

    } }