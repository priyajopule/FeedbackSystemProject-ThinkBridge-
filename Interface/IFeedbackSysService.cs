using FeedbackSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeedbackSystem.Interface
{
    public interface IFeedbackSysService
    {
        /// <summary>
        /// get all products
        /// </summary>
        /// <returns></returns>
        public Task<List<Product>> GetProducts();

        /// <summary>
        /// get all questions
        /// </summary>
        /// <returns></returns>
        public Task<List<Question>> GetQuestions();


        /// <summary>
        /// get login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> GetLogin(User user);

        /// <summary>
        /// get user survey
        /// </summary>
        /// <returns></returns>
        public Task<List<Survey>> GetUserSurvey();

        /// <summary>
        /// add user survey
        /// </summary>
        /// <param name="addSurveyRequest"></param>
        /// <returns></returns>
        public Task AddUserSurvey (SurveyModel addSurveyRequest);

        /// <summary>
        /// get survey by survey id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<SurveyModel> GetSurveyById(int id);

        /// <summary>
        /// Delete Survey
        /// </summary>
        /// <param name="id"></param>
        /// <returns>SuccessResponce</returns>
        public Task<string> DeleteSurvey(int id);

    }
}
