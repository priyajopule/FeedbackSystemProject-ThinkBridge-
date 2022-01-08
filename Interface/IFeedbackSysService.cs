using FeedbackSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeedbackSystem.Interface
{
    public interface IFeedbackSysService
    {
        public Task<List<Product>> GetProducts();

        public Product GetProductById(int id);
       
    }
}
