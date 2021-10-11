using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


// This controller to take an PDF input and return base64 encoded version of the pdf
namespace ASP_DB_TESTS.Controllers
{
    public class PDFUploadController
    {
        [HttpPost]
        public String Upload(IFormFile files)
        {
            var ms = new MemoryStream();
            files.CopyTo(ms);
            var fileBytes = ms.ToArray();
            string s = Convert.ToBase64String(fileBytes);
            return s;

        }
    }
}
