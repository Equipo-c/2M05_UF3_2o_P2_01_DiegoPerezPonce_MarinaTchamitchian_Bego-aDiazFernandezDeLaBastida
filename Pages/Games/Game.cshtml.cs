using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M05_UF3_P2_Template.App_Code.Model;

namespace M05_UF3_P2_Template.Pages.Games
{
    public class GameModel : PageModel
    {
        public void OnGet()
        {
            [BindProperty(SupportsGet = true)]
            public int Id { get; set; }

            [BindProperty]
            public Game product { get; set; }
            public void OnGet()
            {
                if (Id > 0)
                {
                    product = new Game(Id);
                }
            }
        }
    }
    }
}
