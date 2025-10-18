using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.Core.ExtentionMthods
{
    public static class Uplodimg
    {
        public static string Createimage(IFormFile file)
        {
            try
            {
                string imgname = GeneratCode.GuidCode() + Path.GetExtension(file.FileName);
                string pathImg = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SiteCss/images", imgname);

                using (var stream = new FileStream(pathImg, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                return imgname;
            }
            catch (Exception e)
            {
                return "false";
            }
        }

        public static bool DeleteImg(string path , string imagename)
        {
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/SiteCss/" + path + "/" + imagename);
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
