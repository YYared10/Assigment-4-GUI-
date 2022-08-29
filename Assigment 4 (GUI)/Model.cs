using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Assigment_4__GUI_
{
    internal class Model
    {
        static private List<Model> modelList = new List<Model>();
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Inventorynum { get; set; }
        public string Objectname { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public bool isAvailable { get; set; }
        public string ProductType { get; set; }
        public List<int> catagory { get; set; } = new List<int>();



        public void save()
        {
            Database_Services databaseServices = new Database_Services();
            int productType = (this.ProductType == "simple") ? 0 : 1;
            int isAvailable = this.isAvailable ? 1 : 0;
            string quary = $"INSERT INTO Product VALUES('{this.Objectname}'," +
                           $"'{this.Date.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                           $"{this.Inventorynum}," +
                           $"{this.Count}," +
                           $"{this.Price}," +
                           $"{ProductType}," +
                           $"{isAvailable})";
            int numberOfRowAffercted = databaseServices.ExecuteNonQuery(quary);


        }
        public static List<Model> GetAllProducts()
        {
            Database_Services service = new Database_Services();
            List<Model> temp = new List<Model>();
            string query = "SELECT * FROM Model ";

            SqlDataReader data = service.ExecuteReader(query);
            while (data.Read())
            {
                Model product = new Model();
                product.Number = (int)data["Numbers"];
                product.Date = DateTime.Parse((string)data["ProdDate"].ToString());
                product.Inventorynum = (int)data["InventoryNumber"];
                product.Objectname = (string)data["ObjectName"];
                product.Price = Convert.ToDouble(data["Price"]);
                product.Count = (int)data["Quantity"];
                product.ProductType = (Convert.ToBoolean(data["ProductType"])) ? "Variable" : "Simple";
                temp.Add(product);
            }
            return temp;


        }
       /* public static Model findOne(string name)
        {
            //ToLower() is used to make case insensative search. 
            return modelList.Find(it => it.Objectname.ToLower() == name.ToLower());
        }
       */

    }




}
