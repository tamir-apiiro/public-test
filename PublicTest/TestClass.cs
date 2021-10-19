using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
// using JetBrains.Annotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DefaultNamespace
{
    public abstract class A
    {
        [HttpGet("foo")]
        public async void Foo()
        {
            return null;
        }
    }
    
    public class B0 : A
    {
    }
    
    [Route("b1")]
    public class B1 : A
    {
    }
    
    [Route("b2")]
    public class B1 : A
    {
    }
}