using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using PrlyGrp.CountryCatalog.ApplicationCore.Helpers.Query;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Specifications
{
    public class EavValueWithEavEntityAndEavAttributeSpecification : BaseSpecification<EavValue>
    {
        public EavValueWithEavEntityAndEavAttributeSpecification(int eavEntityId, int entityId)
            : base(e => e.EavEntityId == eavEntityId && e.EntityId == entityId)
        {
            AddIncludes(query => query.Include(e => e.EavEntity).ThenInclude(e => e.EavAttribute));
        }
    }
}