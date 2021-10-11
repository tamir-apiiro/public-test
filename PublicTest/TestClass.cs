using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using JetBrains.Annotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DefaultNamespace
{
    public class TestClass
    {
        [HttpGet("{a}/b")]
        public void Foo(string a)
        {
        }
        
        [HttpPost("{c}/d")]
        public void Bar(string c)
        {
        }

        [HttpPost("e")]
        public void Func()
        {
        }
    }
}