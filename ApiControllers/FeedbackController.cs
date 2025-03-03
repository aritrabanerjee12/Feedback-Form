using ASPCoreWebAppWithAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreWebAppWithAPI.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        CustomerDB customerDB;
        public FeedbackController(CustomerDB customerDB)
        {
            this.customerDB = customerDB;
        }

        /* // GET: api/<FeedbackController>
         [HttpGet]
         public IEnumerable<string> Get()
         {
             return new string[] { "value1", "value2" };
         }

         // GET api/<FeedbackController>/5
         [HttpGet("{id}")]
         public string Get(int id)
         {
             return "value";
         }*/

        // POST api/<FeedbackController>
        [HttpPost]
        public ActionResult Post([FromBody] Feedback feedback)
        {
            /* Random random = new Random();
             int num = random.Next(1, 1000);

             return Ok(new { DocketNumber = num, Message = "Feedback Successfully submited!" });*/

            customerDB.Feedbacks.Add(feedback);

            customerDB.SaveChanges();



            return Ok(new { DocketNumber = feedback.Id, Message = "Feedback Successfully submited!" });
        }

       /* // PUT api/<FeedbackController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FeedbackController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
