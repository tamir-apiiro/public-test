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
    // public abstract class Base
    // {
    //     // [HttpGet("{key}/riskTriggers")]
    //     // [AuthorizeResource(RoleResource.Risk)]
    //     // public async Task<ProfileRiskTriggers> GetProfileRiskTriggersAsync(string key)
    //     // {
    //     //     return null;
    //     // }
    //     
    //     // [HttpPost("f")]
    //     // public void Func2()
    //     // {
    //     // }
    // }
    public abstract class TestClass // : Base
    {
        [HttpPost("{key}/riskTriggers")]
        // [AuthorizeResource(RoleResource.Risk)]
        public async Task<ProfileRiskTriggers> PostProfileRiskTriggersAsync(string key)
        {
            return null;
        }
        
        // [HttpGet("{a}/b")]
        // public void Foo(string a)
        // {
        // }
        //
        // [HttpPost("{c}/d")]
        // public void Bar(string c)
        // {
        // }
        //
        // [HttpPost("e")]
        // public void Func()
        // {
        // }
    }

    public class ProfileRiskTriggers
    {
    }
    
    public class AuthorizeResourceAttribute : AuthorizeAttribute
    {
        public AuthorizeResourceAttribute(RoleResource resourceType) : base(resourceType.ToString())
        {
        }
    }

    public enum RoleResource
    {
        Risk
    }
}