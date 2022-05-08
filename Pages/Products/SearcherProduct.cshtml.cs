using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using M05_UF3_P2_Template.App_Code.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M05_UF3_P2_Template.Pages.Products
{
    public class SearcherProductModel : PageModel
    {
        public List<Product> products = new List<Product>();
        public void OnGet()
        {
            DataTable dt = DatabaseManager.Select("Product", new string[] { "*" }, "");
            foreach (DataRow dataRow in dt.Rows)
            {
                products.Add(new Product(dataRow));
            }
        }
        public void OnPostDelete(int id)
        {
            Product.Remove(id);
            OnGet();
        }
    }
}
