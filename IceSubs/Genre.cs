//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IceSubs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Genre
    {
        public Genre()
        {
            this.Media = new HashSet<Medium>();
        }
    
        public int GenreID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Medium> Media { get; set; }
    }
}
