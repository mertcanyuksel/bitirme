
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
    
public partial class TBLAuthor
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TBLAuthor()
    {

        this.TBLBook = new HashSet<TBLBook>();

    }


    public int AuthorID { get; set; }

    public string AuthorName { get; set; }

    public string AuthorSurname { get; set; }

    public string AuthorDetail { get; set; }

    public Nullable<bool> AuthorStatus { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TBLBook> TBLBook { get; set; }

}

}