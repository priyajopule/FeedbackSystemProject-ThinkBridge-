using FeedbackSystem.Interface;
using FeedbackSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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
        /// <summary>
        ///-------- GET ALL PRODUCTS-------- 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("products")]

        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var response = await _feedbackSysService.GetProducts();
                return Ok(response);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// -------GET ALL QUESTIONS-------
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("questions")]
        public async Task<IActionResult> GetQuestions()
        {
            try
            {
                var response = await _feedbackSysService.GetQuestions();
                return Ok(response);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// -------GET LOGIN BY ADMIN USER------
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("login")]

        public async Task<IActionResult> GetLogin([FromBody] User user)
        {
            try
            {
                bool isValid = await _feedbackSysService.GetLogin(user);
                if (isValid)
                    return Ok("User logged in successfully");
                return Ok("Invalid userId or password");
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }



        /// <summary>
        /// -------GET USERS SURVEY-------
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("usersurvey")]
        public async Task<IActionResult> GetUserSurvey()
        {
            try
            {
                var response = await _feedbackSysService.GetUserSurvey();
                return Ok(response);
            }
            catch(Exception)
            {
                return BadRequest();
            }
            
        }



        /// <summary>
        /// ---------ADD USER SURVEY--------------
        /// </summary>
        /// <param name="addSurveyRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("survey")]

        public async Task<IActionResult> AddUserSurvey(SurveyModel addSurveyRequest)
        {
            try
            {
                await _feedbackSysService.AddUserSurvey(addSurveyRequest);
                return Ok();
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// -------------GET SERVEY BY PRODUCT ID------------------
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("survey")]
        public async Task<IActionResult> GetSurveyById([FromQuery] int id)
        {
            try
            {
                var response = await _feedbackSysService.GetSurveyById(id);
                return Ok(response);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }



        /// <summary>
        /// ---------DELETE SURVEY BY SURVEY ID--------------
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deletSurvey")]
        public async Task<IActionResult> DeleteSurvey([FromQuery] int id)
        {
            try
            {
                var response = await _feedbackSysService.DeleteSurvey(id);
                return Ok(response);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }
    }
}
