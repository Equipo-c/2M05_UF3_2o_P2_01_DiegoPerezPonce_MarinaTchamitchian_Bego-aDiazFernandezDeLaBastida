using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using M05_UF3_P2_Template.App_Code.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M05_UF3_P2_Template.Pages.Videos
{
    public class SearcherVideoModel : PageModel
    {
        public List<Video> videos = new List<Video>();
        public void OnGet()
        {
            DataTable dt = DatabaseManager.Select("Video", new string[] { "*" }, "");
            foreach (DataRow dataRow in dt.Rows)
            {
                videos.Add(new Video(dataRow));
            }
        }
        public void OnPostDelete(int id)
        {
            Video.Remove(id);
            OnGet();
        }
    }
}
