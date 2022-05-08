using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace M05_UF3_P2_Template.App_Code.Model
{
    public class Video
    {
        public int Id { get; set; }
        public float Duration { get; set; }
        public int Product_id { get; set; }


        public Video()
        {
        }
        public Video(DataRow row)
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
                Duration = float.Parse(row[1].ToString());
            }
            catch
            {
                Duration = 0;
            }
            try { Product_id = (int)row[2]; } catch { Product_id = 0; }

        }
        public Video(int Id) : this(DatabaseManager.Select("Product", null, "Id = " + Id + " ").Rows[0]) { }

        public bool Update()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("Duration", Duration),
                  new DatabaseManager.DB_Field("Product_Id", Product_id)

            };
            return DatabaseManager.Update("Video", fields, "Id = " + Id + " ") > 0 ? true : false;
        }
        public bool Add()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("Duration", Duration)
            };
            return DatabaseManager.Insert("Video", fields) > 0 ? true : false;
        }
        public bool Remove()
        {
            return Remove(Id);
        }
        public static bool Remove(int id)
        {
            return DatabaseManager.Delete("Video", id) > 0 ? true : false;
        }
    }
}
