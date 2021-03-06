﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Projects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.Get();
        }

    }
}
