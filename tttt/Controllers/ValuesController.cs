using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Web.Http;
using tttt.Models;
using tttt.App_Data;
using System.Web.UI.WebControls;

namespace tttt.Controllers
{
    public class ValuesController : ApiController

        private readonly imageContext _context;
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string images)
        {

            {
                imageContext.Add('images');
                await Image.SaveChangesAsync();

                //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
                return CreatedAtAction(nameof(GetImages), new { id = image.Id }, image);
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string images)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
