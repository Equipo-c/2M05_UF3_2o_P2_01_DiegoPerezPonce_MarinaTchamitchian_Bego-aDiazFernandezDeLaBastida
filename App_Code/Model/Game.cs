using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace M05_UF3_P2_Template.App_Code.Model
{
    public class Game
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public string Version { get; set; }
        public int Product_id { get; set; }
        public Product Product { get; set;  }

        public Game()
        {
        }
        public Game(DataRow row)
        {
            try
            {
                Id = (int)row[0];
            }
            catch
            {
                Id = 0;
            }


            try
            {
                Rating = float.Parse(row[1].ToString());
            }
            catch
            {
                Rating = 0;
            }
           
            Version = row[2].ToString();

            try { Product_id = (int)row[3]; } catch { Product_id = 0; }

            if (Product_id > 0)
            {
                Product = new Product(Product_id);
            }

        }
        public Game(int Id) : this(DatabaseManager.Select("Product", null, "Id = " + Id + " ").Rows[0]) { }

        public bool Update()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("Rating", Rating),
                new DatabaseManager.DB_Field("Version", Version),
                new DatabaseManager.DB_Field("Product_Id", Product_id)
            };
            return DatabaseManager.Update("Game", fields, "Id = " + Id + " ") > 0 ? true : false;
        }
        public bool Add()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("Rating", Rating),
                new DatabaseManager.DB_Field("Version", Version)
            };
            return DatabaseManager.Insert("Game", fields) > 0 ? true : false;
        }
        public bool Remove()
        {
            return Remove(Id);
        }
        public static bool Remove(int id)
        {
            return DatabaseManager.Delete("Game", id) > 0 ? true : false;
        }
    }
}

