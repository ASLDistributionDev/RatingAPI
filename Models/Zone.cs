//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RatingAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zone
    {
        public int ID { get; set; }
        public Nullable<int> TariffGroupID { get; set; }
        public string Name { get; set; }
        public string OriginFromPostal { get; set; }
        public string OriginToPostal { get; set; }
        public string DestinationFromPostal { get; set; }
        public string DestinationToPostal { get; set; }
    }
}
