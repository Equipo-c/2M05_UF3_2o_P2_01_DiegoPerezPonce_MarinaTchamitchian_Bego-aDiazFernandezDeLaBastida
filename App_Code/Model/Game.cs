using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;


namespace M05_UF3_P2_Template.App_Code.Model
{
    public class Game
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public Product Product_conection { get; set; }
        public float Rating { get; set; }
        public string Version { get; set; }

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
                Product_Id = (int)row[2];
            }
            catch
            {
                Product_Id = 0;
            }
            if (Product_Id > 0)
            {
                Product_conection = new Product(Product_Id);
            }
            

        }
        public Game(int id) : this(DatabaseManager.Select("Game").Rows[0]) { }

        public bool Update()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("ProductId", Product_Id),
                new DatabaseManager.DB_Field("Rating", Rating),
                new DatabaseManager.DB_Field("Version", Version)
            };
            return DatabaseManager.Update("Game", fields, "Id = " + Id + " ") > 0 ? true : false;

        }
        public bool Add()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
                {
                new DatabaseManager.DB_Field("ProductId", Product_Id),
                new DatabaseManager.DB_Field("Rating", Rating),
                new DatabaseManager.DB_Field("Version", Version)
            };
            return DatabaseManager.Insert("Game", fields) > 0 ? true : false;
        }
        public bool Remove()
        {
            return Remove(Id);
        }
        public bool Remove(int id)
        {
            return DatabaseManager.Delete("Product", id) > 0 ? true : false;
        }
    }
}
