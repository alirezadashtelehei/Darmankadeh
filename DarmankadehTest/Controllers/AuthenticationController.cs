using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using DarmankadehTest.Model;
using DarmankadehTest.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DarmankadehTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationRepository _authentication;
        public AuthenticationController(AuthenticationRepository authentication)
        {
            _authentication = authentication;
        }
        
        // GET: api/Authentication/
        [HttpGet("{MobileNo}", Name = "Get")]
        public IActionResult Get(string mobileNo)
        {
            var auth = _authentication.GetAuthenticationByPhone(mobileNo);
            return new OkObjectResult(auth);
        }

        // POST: api/Authentication
        [HttpPost]
        public IActionResult Post([FromBody] Authentication authentication)
        {
            using (var scope = new TransactionScope())
            {
                _authentication.InsertAuthentication(authentication);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { MobileNo = authentication.MobileNo }, authentication);
            }
        }
      

       
    }
}
