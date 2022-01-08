using FeedbackSystem.Interface;
using FeedbackSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackSystem.Services
{
    public class FeedbackSysService: IFeedbackSysService
    {
        private FeedbackSysContext _context;
        public FeedbackSysService(FeedbackSysContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProducts()
        {
            var productList = _context.Set<Product>().ToList();
            return productList;
        }

        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
