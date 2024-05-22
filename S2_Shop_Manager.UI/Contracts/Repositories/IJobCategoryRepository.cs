using S2_Shop_Manager.Shared.Domain;

namespace S2_Shop_Manager.UI.Contracts.Repositories
{
    public interface IJobCategoryRepository
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
