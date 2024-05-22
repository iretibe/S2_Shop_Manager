using Microsoft.EntityFrameworkCore;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.UI.Data;
using S2_Shop_Manager.Web.Client;

namespace S2_Shop_Manager.UI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ShopDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmployeeRepository(ShopDbContext context, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Employee> AddEmployee(Employee entity)
        {
            var addedEntity = await _context.Employees.AddAsync(entity);
            await _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var entity = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == employeeId);
            if (entity == null) return;
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            var result = await _context.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefaultAsync();

            return result;
        }

        public async Task<Employee> UpdateEmployee(Employee entity)
        {
            var employee = await _context.Employees.Where(x => x.EmployeeId == entity.EmployeeId).FirstOrDefaultAsync();

            if (employee != null)
            {
                if (employee.ImageContent != null)
                {
                    string currentUrl = _httpContextAccessor.HttpContext.Request.Host.Value;

                    var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{employee.ImageName}";
                    var fileStream = File.Create(path);

                    fileStream.Write(employee.ImageContent, 0, employee.ImageContent.Length);
                    fileStream.Close();

                    employee.ImageName = $"http://{currentUrl}/uploads/{employee.ImageName}";
                }


                employee.EmployeeId = entity.EmployeeId;
                employee.MaritalStatus = entity.MaritalStatus;
                employee.BirthDate = entity.BirthDate;
                employee.City = entity.City;
                employee.Country = entity.Country;
                employee.Email = entity.Email;
                employee.FirstName = entity.FirstName;
                employee.LastName = entity.LastName;
                employee.Gender = entity.Gender;
                employee.PhoneNumber = entity.PhoneNumber;
                employee.Smoker = entity.Smoker;
                employee.Street = entity.Street;
                employee.Zip = entity.Zip;
                employee.JobCategory = entity.JobCategory;
                employee.Comment = entity.Comment;
                employee.ExitDate = entity.ExitDate;
                employee.JoinedDate = entity.JoinedDate;
                employee.ImageContent = entity.ImageContent;
                employee.ImageName = entity.ImageName;

                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
            }

            return entity;
        }
    }
}
