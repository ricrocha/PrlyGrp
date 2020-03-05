using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Specifications
{
    public class StateProvinceWithCountrySpecification : BaseSpecification<StateProvince>
    {
        public StateProvinceWithCountrySpecification(int stateProvinceId)
            : base(s => s.Id == stateProvinceId)
        {
            AddInclude(s => s.Country);
        }

        public StateProvinceWithCountrySpecification(string stateCode)
            : base(s => s.Code == stateCode)
        {
            AddInclude(s => s.Country);
        }
    }
}
