using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserLoginService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserLoginService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

        public static List<UserLogin> userlogins = new List<UserLogin>();
        public static int currentuId = 101;
        
        // GET: api/<UserLoginController>
        [HttpGet]
        public IEnumerable<UserLogin> Get()
        {
            return userlogins;
        }

        // GET api/<UserLoginController>/5
        [HttpGet("{id}")]
        public UserLogin Get(int id)
        {
            var userlogin = userlogins.FirstOrDefault(t => t.Userid == id);
            return userlogin;
        }

         
        // POST api/<UserLoginController>
        // POST is Add record
        [HttpPost]
        public void Post([FromBody] UserLogin value)
        {
            value.Userid = currentuId++;
            value.DateCreated = DateTime.UtcNow;
            userlogins.Add(value);
        }

        // PUT api/<UserLoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserLogin value)
        {
            var userlogin = userlogins.FirstOrDefault(t => t.Userid == id);
            userlogin.Userid = id;
            userlogin.UserEmail = value.UserEmail;
            userlogin.UserPassword = value.UserPassword;
        }

        // DELETE api/<UserLoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userlogins.RemoveAll(t => t.Userid == id);
        }
    }
}
