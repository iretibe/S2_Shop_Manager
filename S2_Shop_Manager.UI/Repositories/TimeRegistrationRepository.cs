using Microsoft.EntityFrameworkCore;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.UI.Contracts.Repositories;
using S2_Shop_Manager.UI.Data;

namespace S2_Shop_Manager.UI.Repositories
{
    public class TimeRegistrationRepository : ITimeRegistrationRepository
    {
        private readonly ShopDbContext _context;

        public TimeRegistrationRepository(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId)
        {
            var result = await _context.TimeRegistrations
                .Where(t => t.EmployeeId == employeeId)
                .OrderBy(t => t.StartTime)
                .ToListAsync();

            return result;
        }

        public async Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start)
        {
            return await _context.TimeRegistrations.Where(t => t.EmployeeId == employeeId).OrderBy(t => t.StartTime).Skip(start).Take(pageSize).ToListAsync();
        }

        public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
        {
            return await _context.TimeRegistrations.Where(t => t.EmployeeId == employeeId).CountAsync();
        }
    }
}
