using Ardalis.GuardClauses;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public static class CountryGuards
    {
        public static void NullCountry(this IGuardClause guardClause, int countryId, Country country)
        {
            if (country == null)
            {
                throw new CountryNotFoundException(countryId);
            }
        }
    }
}
