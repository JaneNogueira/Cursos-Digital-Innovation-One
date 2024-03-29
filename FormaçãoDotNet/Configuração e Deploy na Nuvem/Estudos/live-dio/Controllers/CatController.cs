﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace live_dio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        public static string URLBase = "https://fotosgatinhos.blob.core.windows.net/fotos/";
        private readonly ILogger<CatController> _logger;
        private readonly IConfiguration Configuration;

        public CatController(ILogger<CatController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get(bool image) 
        {
            var random = new Random();
            var url = URLBase + random.Next(1, 10) +".jpg";
            if (image)
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(url);
                    return File(imageBytes, "image/jpg");
                }
            }
            else
            {
                return Ok(url);
            }
        }
    }
}
