//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DX_Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ClassRooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ClassRooms()
        {
            this.tb_Attended = new HashSet<tb_Attended>();
            this.tb_Courses = new HashSet<tb_Courses>();
        }
    
        public string col_RoomID { get; set; }
        public string col_RoomName { get; set; }
        public Nullable<int> col_Capacity { get; set; }
        public string col_CreateID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Attended> tb_Attended { get; set; }
        public virtual tb_Teachers tb_Teachers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Courses> tb_Courses { get; set; }
    }
}
