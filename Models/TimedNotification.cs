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
    
    public partial class TimedNotification
    {
        public int id { get; set; }
        public string TimedNotificationType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> ElapsedTime { get; set; }
        public Nullable<int> MaxAllowableTime { get; set; }
        public Nullable<System.DateTime> LastEmailSentOut { get; set; }
        public Nullable<int> EmailInterval { get; set; }
        public Nullable<bool> Enabled { get; set; }
    }
}
