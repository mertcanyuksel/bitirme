
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MVC5Library.Models
{

using System;
    using System.Collections.Generic;
    
public partial class TBLMessage
{

    public int MessageID { get; set; }

    public string MessageSender { get; set; }

    public string MessageBuyer { get; set; }

    public string MessageSubject { get; set; }

    public string MessageContents { get; set; }

    public string MessageLabel { get; set; }

    public Nullable<System.DateTime> MessageDate { get; set; }

    public Nullable<bool> MessageStatus { get; set; }

}

}
