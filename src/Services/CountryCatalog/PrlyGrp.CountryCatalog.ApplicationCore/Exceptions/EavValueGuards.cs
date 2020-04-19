using Ardalis.GuardClauses;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public static class EavValueGuards
    {
        public static void NullEavValue(this IGuardClause guardClause, int eavValueId, EavValue eavValue)
        {
            if (eavValue == null)
            {
                throw new EavValueNotFoundException(eavValueId);
            }
        }
    }
}
