using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace PetStore.Models
{
    //THIS IS CALLED THE DATA ACCESS LAYER! DAL

    [Table("Product")]
    public class Product
    {
        //Assigning ID to PRIMARY KEy
        [Key]
        public long id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }

        public Product()
        {

        }

        public Product(string _name, Decimal _price)
        {
            Name = _name;
            Price = _price;

            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            db.Open();
            string sql = $"insert into Product (Name, Description, Price) OUTPUT INSERTED.Id values ('{_name}', '{_price}') ";
            int _id = db.QuerySingle<int>(sql);

            id = _id;
            db.Query(sql);
            db.Close();
        }


        public static Product Create(string _name, Decimal _price)
        {
            //Create the new Product instance
            Product prod = new Product() { Name = _name, Price = _price };

            //Save it to the DB
            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            long _id = db.Insert<Product>(prod);


            // Set the ID column of the instance
            prod.id = _id;

            //Return the instance
            return prod;
        }

        public static Product Read(long _id)
        {
            //Take ID, query DB, return with 1 value.
            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            Product prod = db.Get<Product>(_id);
            return prod;
        }

        public static List<Product> Read()
        {
            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            List<Product> prods = db.GetAll<Product>().ToList() ;
            return prods;
        }

        public static void Delete (long _id)
        {
            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            db.Delete(new Product() { id = _id });
        }

        public void Save()
        {
            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            db.Update(this);

        }

        public static List<Product> ListAll()
        {
            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            db.Open();
            List<Product> cats = db.Query<Product>("Select * from Product").AsList<Product>();
            db.Close();
            return cats;

        }

    }
}
