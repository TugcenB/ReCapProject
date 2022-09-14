using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImage;

        public CarImagesController(ICarImageService carImage)
        {
            _carImage = carImage;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm]CarImage carImage)
        {
            
             var result = _carImage.Add(carImage);
            return Ok();
        }
    }
}
