using FeedbackSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeedbackSystem.Interface
{
    public interface IFeedbackSysService
    {
        public Task<List<Product>> GetProducts();

        public Task<List<Question>> GetQuestions();

        public Task<bool> GetLogin(User user);
        public Task<List<Survey>> GetUserSurvey();
        public Task AddUserSurvey (SurveyModel addSurveyRequest);
        public Task<SurveyModel> GetSurveyById(int id);

        /// <summary>
        /// Delete Survey
        /// </summary>
        /// <param name="id"></param>
        /// <returns>SuccessResponce</returns>
        public Task<string> DeleteSurvey(int id);

    }
}
