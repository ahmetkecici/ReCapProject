using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private IBrandService _brandservice;

        public BrandsController(IBrandService brandService)
        {
            _brandservice = brandService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
       
   

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandservice.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandservice.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandservice.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
