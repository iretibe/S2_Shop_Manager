using Microsoft.EntityFrameworkCore;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.UI.Contracts.Repositories;
using S2_Shop_Manager.UI.Data;

namespace S2_Shop_Manager.UI.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ShopDbContext _context;

        public CountryRepository(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await Task.FromResult(_context.Countries);
        }

        public async Task<Country> GetCountryById(int countryId)
        {
            return await _context.Countries.FirstOrDefaultAsync(c => c.CountryId == countryId);
        }
    }
}
