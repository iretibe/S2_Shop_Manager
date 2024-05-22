using S2_Shop_Manager.Shared.Domain;

namespace S2_Shop_Manager.UI.Contracts.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
