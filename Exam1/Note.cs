//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Note
    {
        public int id { get; set; }
        public string Author { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastEdited { get; set; }
        public string Comments { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int userID { get; set; }
    
        public virtual User User { get; set; }
    }
}
