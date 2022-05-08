using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M05_UF3_P2_Template.App_Code.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M05_UF3_P2_Template.Pages.Products
{
    public class ProductModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public int helper_id;
        [BindProperty]
        public Product product { get; set; }
        public void OnGet()
        {
            if (Id > 0)
            {
                product = new Product(Id);
                if (product.Type == Product.TYPE.Game)
                {
                    helper_id = (int)DatabaseManager.Select("Game", new string[] { "Id" }, "Product_Id = " + Id).Rows[0][0];
                }
               /* else if (product.Type == Product.TYPE.Video)
                {
                    helper_id = (int)DatabaseManager.Select("Video", new string[] { "Id" }, "Product_Id = " + Id).Rows[0][0];
                }*/
            }
        }

        public void OnPost()
        {
            product.Id = Id;
            if (Id > 0) //Si existe
            {
                product.Update();
            }
            else //Si no existe
            {
                product.Add();
                Id = (int)DatabaseManager.Scalar("Product", DatabaseManager.SCALAR_TYPE.MAX, new string[] { "Id" }, "");
                
                if(product.Type == Product.TYPE.Game)
                {
                    Game temp = new Game();
                    temp.Product_Id = Id;
                    temp.Add();
                }
                if (product.Type == Product.TYPE.Video)
                {
                    Video temp = new Video();
                    temp.Product_Id = Id;
                    temp.Add();
                }

                OnGet();
            }
        }
    }
}

