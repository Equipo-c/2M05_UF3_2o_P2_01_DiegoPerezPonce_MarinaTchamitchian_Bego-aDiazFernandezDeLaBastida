using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M05_UF3_P2_Template.App_Code.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M05_UF3_P2_Template.Pages.Videos
{
    public class VideoModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty]
        public Video video { get; set; }
        public void OnGet()
        {
            if (Id > 0)
            {
                video = new Video(Id);
            }
        }
        public void OnPost()
        {
            video.Id = Id;
            if (Id > 0)
            {
                video.Update();
            }
            else
            {
                video.Add();
                Id = (int)DatabaseManager.Scalar("Company", DatabaseManager.SCALAR_TYPE.MAX, new string[] { "Id" }, "");
                OnGet();
            }
        }
    }
}
