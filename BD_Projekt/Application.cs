//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Application()
        {
            this.StageGrade = new HashSet<StageGrade>();
        }
    
        public int Id { get; set; }
    
        public virtual Recruited Recruited { get; set; }
        public virtual Job Job { get; set; }
        public virtual Worker Assistant { get; set; }
        public virtual Decision Decision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StageGrade> StageGrade { get; set; }
    }
}
