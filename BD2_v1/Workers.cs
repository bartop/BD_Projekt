//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD2_v1
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    [KnownType(typeof(Roles))]
    [KnownType(typeof(Applications))]
    [KnownType(typeof(Stage))]
    
    public partial class Workers
    {
        public Workers()
        {
            this.Applications = new HashSet<Applications>();
            this.Applications1 = new HashSet<Applications>();
        }
    
    	[DataMember]
        public int Id { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public string PasswordHash { get; set; }
    	[DataMember]
        public string PrehashString { get; set; }
    
    	[DataMember]
        public virtual Roles Roles { get; set; }
    	[DataMember]
        public virtual ICollection<Applications> Applications { get; set; }
    	[DataMember]
        public virtual ICollection<Applications> Applications1 { get; set; }
    	[DataMember]
        public virtual Stage Stage { get; set; }
    }
}
