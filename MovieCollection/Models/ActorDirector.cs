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
    
    public partial class ActorDirector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActorDirector()
        {
            this.Movies = new HashSet<Movie>();
            this.Movies1 = new HashSet<Movie>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActor { get; set; }
        public bool IsDirector { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual Movie Movie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie> Movies1 { get; set; }
    }
}
