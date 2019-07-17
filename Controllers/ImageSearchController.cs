using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace simple_search.Controllers
{
    [Route("api/[controller]")]
    public class ImageSearchController : Controller
    {
      private static Images image1 = new Images { ImageName = "cat1.jpg" };
      private static Images image2 = new Images { ImageName = "cat2.jpg" };
      private static Images[] AllImages = new Images[] { image1, image2 };

        [HttpGet("[action]")]
        public IEnumerable<Images> GetImages()
        {;
            return AllImages;
        }

        public class Images
        {
            public string ImageName { get; set; }
        }
    }
}
