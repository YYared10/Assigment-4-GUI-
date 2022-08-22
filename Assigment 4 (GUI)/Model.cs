using System;
using System.Collections.Generic;

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
            modelList.Add(this);

        }
        public static List<Model> GetAllProducts()
        {
            return modelList;
        }
        public static Model findOne(string name)
        {
            //ToLower() is used to make case insensative search. 
            return modelList.Find(it => it.Objectname.ToLower() == name.ToLower());
        }


    }




}
