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
        public string Rating { get; set; }
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
            Rating = row[1].ToString();
            Version = row[2].ToString();
            
        }
        public Game(int Id) : this(DatabaseManager.Select("Game", null, "Id = " + Id + " ").Rows[0]) { }

        public bool Update()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("Rating", Rating),
                new DatabaseManager.DB_Field("Version", Version)
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

