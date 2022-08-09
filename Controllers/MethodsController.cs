﻿using DrugApi.Data;
using DrugApi.Models;
using DrugApi.Repos.cs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MethodsController : ControllerBase
    {

        private readonly  DummyRepo obj1;

        public MethodsController()
        {
            obj1 = new DummyRepo(new DataContext());
        }
        [HttpPost]
        public Dummy Buy(Dummy b)
        {
            var c = obj1.Buy(b);
            return c;
        }
    }
}
