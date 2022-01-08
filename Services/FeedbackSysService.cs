using FeedbackSystem.Interface;
using FeedbackSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackSystem.Services
{
    public class FeedbackSysService : IFeedbackSysService
    {
        private FeedbackSysContext _context;
        public FeedbackSysService(FeedbackSysContext context)
        {
            _context = context;
        }

        public async Task AddUserSurvey(SurveyModel addSurveyRequest)
        {

            Survey surveyAdd = new Survey();
            surveyAdd = addSurveyRequest.Survey;

            var survey =  _context.Add(surveyAdd);
            _context.SaveChanges();
            var sid = surveyAdd.Sid;           
        }

        public async Task<bool> GetLogin(User user)
        {
            return _context.Set<User>().Any(x => string.Equals(x.UserId, user.UserId) && string.Equals(x.Password, user.Password) && x.Role == user.Role);
        }

        public async Task<List<Product>> GetProducts()
        {
            var productList = _context.Set<Product>().ToList();
            return productList;
        }

        public async Task<List<Question>> GetQuestions()
        {
            var questionList = _context.Set<Question>().ToList();
            return questionList;
        }

        public async Task<SurveyModel> GetSurveyById(int id)
        {
            var response = new SurveyModel();
            response.Survey = new Survey();
            response.Survey = _context.Set<Survey>().Where(x => x.Sid == id).FirstOrDefault();

            if (response.Survey != null) 
            { 
                    var transactions = _context.Set<Transaction>().Where(x => x.SurveyID == response.Survey.Sid).ToList();

                    if(transactions.Any())
                    {
                        response.Survey.surveyTransaction = new List<Transaction>();
                        response.Survey.surveyTransaction.AddRange(transactions);
                    }
            }
            return response;
        }

        public async Task<List<Survey>> GetUserSurvey()
        {
            var suveyList = _context.Set<Survey>().Distinct().ToList();
            return suveyList;
        }

        public async Task<string> DeleteSurvey(int id)
        {
            Survey recordToBeDeleted = _context.Set<Survey>().Where(x => x.Sid == id).FirstOrDefault();

            if (recordToBeDeleted != null)
            {
                _context.Set<Survey>().Remove(recordToBeDeleted);
                _context.SaveChanges();
                return "Record Deleted Successfully";
            }
            return "Record Deleted Failed";
        }
    }
}
