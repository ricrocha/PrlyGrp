﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Entities
{
    public partial class EavEntity : DbBaseEntity
    {
        public EavEntity()
        {
            EavAttribute = new HashSet<EavAttribute>();
            EavValue = new HashSet<EavValue>();
        }

        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<EavAttribute> EavAttribute { get; set; }
        public virtual ICollection<EavValue> EavValue { get; set; }
    }
}