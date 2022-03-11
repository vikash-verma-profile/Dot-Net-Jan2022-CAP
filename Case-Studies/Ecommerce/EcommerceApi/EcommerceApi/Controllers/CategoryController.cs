using EcommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        EcommerceDbContext _ecommerceDbContext;
        public CategoryController(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }
        [HttpGet]
        public IEnumerable<TblCategory> GetCategories()
        {
            return _ecommerceDbContext.TblCategories.ToList();
        }
    }
}

