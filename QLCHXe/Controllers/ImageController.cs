
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QLCHXe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        public static IWebHostEnvironment _environment;

        public ImageController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var image = System.IO.File.OpenRead("Uploads/" + id);
                return File(image, "image/jpeg");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        public async Task<string> Post(IFormFile files)
        {
            try
            {
                if (files.Length > 0)
                {

                    using (FileStream filestream = System.IO.File.Create("Uploads/" + files.FileName))
                    {
                        await files.CopyToAsync(filestream);
                        filestream.Flush();
                        return "/Uploads/" + files.FileName;
                    }
                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }
    }
}

