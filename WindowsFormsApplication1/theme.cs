//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class theme
    {
        public theme()
        {
            this.livres = new HashSet<livre>();
        }
    
        public int codeTh { get; set; }
        public string intitule { get; set; }
    
        public virtual ICollection<livre> livres { get; set; }
    }
}