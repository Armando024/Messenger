using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers
{
    public class User{
        public User(){
            this.Id = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.PasswordHash = "";
            this.Birthday = "99/99/99";
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Birthday { get; set; }
        public string FullName(){
            return FirstName + LastName;
        }
    }

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            User[] users=new User[4];
            users[0] = new User { Id = 123, FirstName = "IceBreaker", LastName = "idk", Email = "sd@sds.com", PasswordHash = "dsc2e2", Birthday = "12/12/12" };
            users[1] = new User { Id = 124, FirstName = "Fire", LastName = "idk2", Email = "ssdsd@sds.com", PasswordHash = "masterdsdsc2e2", Birthday = "01/12/12" };
            users[2] = new User();
            users[3] = new User();
            return Json(users);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
