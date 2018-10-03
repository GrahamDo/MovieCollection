//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieCollection.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public System.Guid Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.Guid> ActorId { get; set; }
        public System.Guid LocationId { get; set; }
        public string LocationUrl { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Location Location { get; set; }
    }
}
