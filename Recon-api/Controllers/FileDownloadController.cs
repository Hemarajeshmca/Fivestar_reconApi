using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recon_api.Controllers
{
    public class FileDownloadController : Controller
    {
        // GET: FileDownload
        public ActionResult Index()
        {
            return View();
        }

        [Route("FileDownload")]
        [HttpGet]
        public void DownloadFile(String filePath)
        { 
            
        }
    }
}