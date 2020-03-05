using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Specifications
{
    public class EavEntityWithEavAttributesSpecification : BaseSpecification<EavEntity>
    {
        public EavEntityWithEavAttributesSpecification(int eavEntityId)
            : base(e => e.Id == eavEntityId)
        {
            AddInclude(e => e.EavAttribute);
        }

        public EavEntityWithEavAttributesSpecification(string eavEntityShortName)
            : base(e => e.ShortName == eavEntityShortName)
        {
            AddInclude(e => e.EavAttribute);
        }
    }
}
