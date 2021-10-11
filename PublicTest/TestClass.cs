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
    public class Base
    {
        [HttpGet("{key}/riskTriggers")]
        public async Task<ProfileRiskTriggers> GetProfileRiskTriggersAsync(string key)
        {
            return null;
        }
        
        [HttpPost("f")]
        public void Func2()
        {
        }
    }
    public abstract class TestClass // : Base
    {
        [HttpGet("{key}/riskTriggers")]
        public async Task<ProfileRiskTriggers> GetProfileRiskTriggersAsync(string key)
        {
            return null;
        }
        
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

    public class ProfileRiskTriggers
    {
    }
}