//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace Moon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MCRN
    {
        
        public int id { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "Please Enter a Valid name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please Enter a Valid name")]
        public string Email { get; set; }

        [Required]
        //[RegularExpression("[0-9]+",ErrorMessage ="Please enter a valid 4 digit pin")]
        //[MaxLength(4,ErrorMessage ="Please enter a 4 digit pin")]
        public Nullable<int> Pin { get; set; }
    }
}
