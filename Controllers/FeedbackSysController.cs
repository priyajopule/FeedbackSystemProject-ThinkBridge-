using FeedbackSystem.Interface;
using FeedbackSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeedbackSystem.Controllers
{
    [Route("api/feedback")]
    [ApiController]
    public class FeedbackSysController : ControllerBase
    {
        IFeedbackSysService _feedbackSysService;
        public FeedbackSysController(IFeedbackSysService feedbackSysService)
        {
            _feedbackSysService = feedbackSysService;
        }
        // GET: api/<FeedbackSysController>
        [HttpGet]

        [Route("products")]

        public async Task<List<Product>> GetProducts()
        {
            var response = await _feedbackSysService.GetProducts();
            return response;
        }

        

        // GET api/<FeedbackSysController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FeedbackSysController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FeedbackSysController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FeedbackSysController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
