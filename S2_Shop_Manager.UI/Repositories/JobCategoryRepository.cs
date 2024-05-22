using Microsoft.EntityFrameworkCore;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.UI.Contracts.Repositories;
using S2_Shop_Manager.UI.Data;

namespace S2_Shop_Manager.UI.Repositories
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private readonly ShopDbContext _context;

        public JobCategoryRepository(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await Task.FromResult(_context.JobCategories);
        }

        public async Task<JobCategory> GetJobCategoryById(int jobCategoryId)
        {
            return await _context.JobCategories.FirstOrDefaultAsync(c => c.JobCategoryId == jobCategoryId);
        }
    }
}
