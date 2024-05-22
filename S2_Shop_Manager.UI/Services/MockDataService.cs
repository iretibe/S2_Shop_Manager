using S2_Shop_Manager.Shared.Domain;

namespace S2_Shop_Manager.UI.Services
{
    public class MockDataService
    {
        private static List<Employee> _employees = default!;
        private static List<JobCategory> _jobCategories = default!;
        private static List<Country> _countries = default!;

        public static List<Employee> Employees
        {
            get
            {
                _countries ??= InitializeMockCountries();

                _jobCategories ??= InitializeMockJobCategories();

                _employees ??= InitializeMockEmployees();

                return _employees;
            }
        }

        private static List<Employee> InitializeMockEmployees()
        {
            var e1 = new Employee
            {
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),
                City = "Accra",
                Email = "faruq.umar@gmail.com",
                EmployeeId = 1,
                FirstName = "Faruq",
                LastName = "Umar",
                Gender = Gender.Female,
                PhoneNumber = "0244342112",
                Smoker = false,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategory = _jobCategories[2],
                JobCategoryId = _jobCategories[2].JobCategoryId,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),
                Country = _countries[0],
                CountryId = _countries[0].CountryId,
                IsOnHoliday = false
            };

            var e2 = new Employee
            {
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1997, 1, 16),
                City = "Kumasi",
                Email = "Rahina@gmail.com",
                EmployeeId = 2,
                FirstName = "Rahina",
                LastName = "Abu",
                Gender = Gender.Female,
                PhoneNumber = "0578909453",
                Smoker = false,
                Street = "New Street",
                Zip = "2000",
                JobCategory = _jobCategories[1],
                JobCategoryId = _jobCategories[1].JobCategoryId,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24),
                Country = _countries[1],
                CountryId = _countries[1].CountryId,
                IsOnHoliday = false
            };

            var e3 = new Employee
            {
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1989, 1, 16),
                City = "Accra",
                Email = "rachida@gmail.com",
                EmployeeId = 3,
                FirstName = "Rachida",
                LastName = "Sanni",
                Gender = Gender.Female,
                PhoneNumber = "0245509997",
                Smoker = false,
                Street = "New Street",
                Zip = "2000",
                JobCategory = _jobCategories[1],
                JobCategoryId = _jobCategories[1].JobCategoryId,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24),
                Country = _countries[1],
                CountryId = _countries[1].CountryId,
                IsOnHoliday = false
            };

            return [e1, e2, e3];
        }

        private static List<JobCategory> InitializeMockJobCategories() => [
                new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
                new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
                new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
                new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
                new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}
            ];

        private static List<Country> InitializeMockCountries() => [
                new Country {CountryId = 1, Name = "Belgium"},
                new Country {CountryId = 2, Name = "Netherlands"},
                new Country {CountryId = 3, Name = "USA"},
                new Country {CountryId = 4, Name = "Japan"},
                new Country {CountryId = 5, Name = "China"},
                new Country {CountryId = 6, Name = "UK"},
                new Country {CountryId = 7, Name = "France"},
                new Country {CountryId = 8, Name = "Brazil"}
            ];
    }
}
