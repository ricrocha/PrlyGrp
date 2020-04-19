using Ardalis.GuardClauses;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public static class EavAttributeGuards
    {
        public static void NullEavAttribute(this IGuardClause guardClause, int eavAttributeId, EavAttribute eavAttribute)
        {
            if (eavAttribute == null)
            {
                throw new EavAttributeNotFoundException(eavAttributeId);
            }
        }
    }
}
