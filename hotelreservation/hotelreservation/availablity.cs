//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hotelreservation
{
    using System;
    using System.Collections.Generic;
    
    public partial class availablity
    {
        public string availablityid { get; set; }
        public string roomid { get; set; }
        public Nullable<int> roomsavailable { get; set; }
        public System.DateTime dateofavailablity { get; set; }
    
        public virtual roomfacility roomfacility { get; set; }
    }
}
