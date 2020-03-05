using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Specifications
{
    public class CountryWithStateProvincesSpecification : BaseSpecification<Country>
    {
        public CountryWithStateProvincesSpecification(int countryId)
            : base(c => c.Id == countryId)
        {
            AddInclude(c => c.StateProvince);
        }

        public CountryWithStateProvincesSpecification(string countryCode)
            : base(c => c.Code == countryCode)
        {
            AddInclude(c => c.StateProvince);
        }
    }
}
