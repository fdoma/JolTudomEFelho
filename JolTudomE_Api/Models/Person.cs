//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JolTudomE_Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Sessions = new HashSet<Sessions>();
        }
    
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Prefix { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime Created { get; set; }
        public string Password { get; set; }
        public System.Guid UserGuid { get; set; }
    
        public virtual ICollection<Sessions> Sessions { get; set; }
    }
}
