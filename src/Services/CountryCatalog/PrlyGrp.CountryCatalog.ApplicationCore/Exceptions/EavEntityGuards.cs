using Ardalis.GuardClauses;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public static class EavEntityGuards
    {
        public static void NullEavEntity(this IGuardClause guardClause, int eavEntityId, EavEntity eavEntity)
        {
            if (eavEntity == null)
            {
                throw new EavEntityNotFoundException(eavEntityId);
            }
        }
    }
}
