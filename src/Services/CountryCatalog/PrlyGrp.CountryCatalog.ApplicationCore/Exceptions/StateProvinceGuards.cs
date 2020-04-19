using Ardalis.GuardClauses;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public static class StateProvinceGuards
    {
        public static void NullStateProvince(this IGuardClause guardClause, int stateProvinceId, StateProvince stateProvince)
        {
            if (stateProvince == null)
            {
                throw new StateProvinceNotFoundException(stateProvinceId);
            }
        }
    }
}
