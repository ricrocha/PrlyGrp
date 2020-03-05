using System;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Entities
{
    public class DbBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset ChangedOn { get; set; }
        public string ChangedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}