using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventSwagger.Controllers
{
    [Route("api/shifi")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private static List<Event> event1 = new List<Event> { new Event { Id = 2,Title="birthday1", Start = new DateOnly(2023, 9, 17) }, new Event { Id = 4, Title = "birthday2", Start = new DateOnly(2023, 9, 15) }, new Event { Id = 6, Title = "birthday3", Start = new DateOnly(2023, 9, 13) } };

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return event1;
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post(Event eve)
        {
            event1.Add(eve);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event even)
        {
            var eve2 = event1.Find(e => e.Id == id);
            eve2.Id = even.Id;
            eve2.Title = even.Title;
            eve2.Start = even.Start;
            eve2.End = even.End;

        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve3 = event1.Find(e => e.Id == id);
            event1.Remove(eve3);
        }
    }
}