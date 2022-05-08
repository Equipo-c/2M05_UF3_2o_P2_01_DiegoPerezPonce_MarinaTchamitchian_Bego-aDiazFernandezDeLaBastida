﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace M05_UF3_P2_Template.App_Code.Model
{
    public class Product
    {

        public int Id { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public string Trailer { get; set; }
        public float Price { get; set; }
        public DateTime Publishing { get; set; }
        public float Size { get; set; }
        public enum TYPE { Game, Video }
        public TYPE Type { get; set;  }
        public int Developer_id { get; set;  }
        public Company Developer { get; set; }
        public int Editor_id { get; set; }
        public Company Editor { get; set; }


        public Product()
        {
        }
        public Product(DataRow row)
        {
            try{ Id = (int)row[0];} catch {Id = 0;}
            try
            {
                Price = float.Parse(row[5].ToString());
            }
            catch
            {
                Price = 0;
            }
            try
            {
                Publishing = DateTime.Parse(row[6].ToString());
            }
            catch
            {
                Publishing = DateTime.MinValue;
            }
            try
            {
                Size = float.Parse(row[7].ToString());
            }
            catch
            {
                Size = 0;
            }
            try
            {
                Type = (TYPE)(int)row[8];
            }
            catch
            {
                Type = 0;
            }
            if (Type == 0)
            {
                Type = TYPE.Game;
            }
            else
            {
                Type = TYPE.Video;
            }
            if (Editor_id > 0)
            {
                Editor = new Company(Editor_id); 
            }
            if (Developer_id > 0)
            {
                Editor = new Company(Editor_id);
            }


            Summary = row[1].ToString();
            Icon = row[2].ToString();
            Banner = row[3].ToString();
            Trailer = row[4].ToString();


            try { Developer_id = (int)row[9]; } catch { Developer_id = 0; }
            try { Editor_id = (int)row[10]; } catch { Editor_id = 0; }
        }
        public Product(int Id) : this(DatabaseManager.Select("Product", null, "Id = " + Id + " ").Rows[0]) { }

        public bool Update()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("Summary", Summary),
                new DatabaseManager.DB_Field("Icon", Icon),
                new DatabaseManager.DB_Field("Banner", Banner),
                new DatabaseManager.DB_Field("Trailer", Trailer),
                new DatabaseManager.DB_Field("Price", Price),
                new DatabaseManager.DB_Field("Publishing", Publishing),
                new DatabaseManager.DB_Field("Size", Size),
                new DatabaseManager.DB_Field("Type", (int)Type),
                new DatabaseManager.DB_Field("Developed_id", Developer_id),
                new DatabaseManager.DB_Field("Editor_Id", Editor_id)
            };
            return DatabaseManager.Update("Product", fields, "Id = " + Id + " ") > 0 ? true : false;
        }
        public bool Add()
        {
            DatabaseManager.DB_Field[] fields = new DatabaseManager.DB_Field[]
            {
                new DatabaseManager.DB_Field("Summary", Summary),
                new DatabaseManager.DB_Field("Icon", Icon),
                new DatabaseManager.DB_Field("Banner", Banner),
                new DatabaseManager.DB_Field("Trailer", Trailer),
                new DatabaseManager.DB_Field("Price", Price),
                new DatabaseManager.DB_Field("Publishing", Publishing),
                new DatabaseManager.DB_Field("Size", Size)
            };
            return DatabaseManager.Insert("Product", fields) > 0 ? true : false;
        }
        public bool Remove()
        {
            return Remove(Id);
        }
        public static bool Remove(int id)
        {
            return DatabaseManager.Delete("Product", id) > 0 ? true : false;
        }
    }
}

