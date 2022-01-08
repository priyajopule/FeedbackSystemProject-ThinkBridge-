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

        public async Task<IActionResult> GetProducts()
        {
            var response = await _feedbackSysService.GetProducts();
            return Ok(response);
        }

        [HttpGet]
        [Route("questions")]
        public async Task<IActionResult> GetQuestions()
        {
            var response = await _feedbackSysService.GetQuestions();
            return Ok(response);
        }

        [HttpGet]
        [Route("login")]

        public async Task<IActionResult> GetLogin([FromBody] User user)
        {
            bool isValid = await _feedbackSysService.GetLogin(user);
            if (isValid)
                return Ok("User logged in successfully");
            return Ok("Invalid userId or password");
        }

        [HttpGet]
        [Route("usersurvey")]
        public async Task<IActionResult> GetUserSurvey()
        {
            var response = await _feedbackSysService.GetUserSurvey();
            return Ok(response);
        }

        [HttpPost]
        [Route("survey")]

        public async Task<IActionResult> AddUserSurvey(SurveyModel addSurveyRequest)
        {
            await _feedbackSysService.AddUserSurvey(addSurveyRequest);
            return Ok();

        }

        [HttpGet]
        [Route("survey")]
        public async Task<IActionResult> GetSurveyById([FromQuery] int id)
        {
            var response = await _feedbackSysService.GetSurveyById(id);
            return Ok(response);
        }

        [HttpGet]
        [Route("deletSurvey")]
        public async Task<IActionResult> DeleteSurvey([FromQuery] int id)
        {
            var response = await _feedbackSysService.DeleteSurvey(id);
            return Ok(response);
        }
    }
}
