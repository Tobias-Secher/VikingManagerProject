//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VikingManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Building
    {
        public long ID { get; set; }
        public long BuildTypeID { get; set; }
        public long CityID { get; set; }
        public long Level { get; set; }
        public decimal Price { get; set; }
        public long Repair { get; set; }
        public long Food { get; set; }
        public long Equipment { get; set; }
        public long Mead { get; set; }
        public long HpReg { get; set; }
        public long Defence { get; set; }
    
        public virtual BuildType BuildType { get; set; }
        public virtual BuildType BuildType1 { get; set; }
        public virtual City City { get; set; }
    }
}
