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
    
    public partial class Rating
    {
        public Rating()
        {
            this.Translations = new HashSet<Translation>();
        }
    
        public int RatingsID { get; set; }
        public Nullable<int> Stars { get; set; }
    
        public virtual ICollection<Translation> Translations { get; set; }
    }
}
