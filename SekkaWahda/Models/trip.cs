
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SekkaWahda.Models
{

using System;
    using System.Collections.Generic;
    
public partial class trip
{

    public int ID { get; set; }

    public string FromCity { get; set; }

    public string ToCity { get; set; }

    public string PlaceToMeet { get; set; }

    public System.DateTime DateOfTrip { get; set; }

    public System.TimeSpan TimeOfTrip { get; set; }

    public Nullable<int> DriverId { get; set; }

    public Nullable<System.DateTime> TimeOfPost { get; set; }



    public virtual UserMaster UserMaster { get; set; }

}

}
