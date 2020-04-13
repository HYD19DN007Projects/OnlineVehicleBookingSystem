//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team5Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer_Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer_Profile()
        {
            this.Customer_Vehicle_Booking1 = new HashSet<Customer_Vehicle_Booking1>();
        }

        [Required(ErrorMessage = "Id Cannot Be  Blank!")]
        [RegularExpression("^[a-zA-Z0-9]{6,20}$", ErrorMessage = "Enter Aplhanumerics only no Special Characters allowed")]
        public string Customer_id { get; set; }

        [Required(ErrorMessage = "Name Cannot Be  Blank!")]
        [RegularExpression("^[a-zA-Z]{1,15}$", ErrorMessage = "Enter only alphabets")]
        public string Customer_name { get; set; }

        [Required(ErrorMessage = "Password Cannot Be Blank!")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,20}$", ErrorMessage = "Password Should contain atleast one Number and one Special Character  ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Date of Birth Cannot be Blank")]
        public Nullable<System.DateTime> Date_of_Birth { get; set; }


        [Required(ErrorMessage = "Address Cannot Be Blank")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "no special characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Mail_id Cannot Be Blank!")]
        [EmailAddress(ErrorMessage = "Not a Valid Email_id")]
        public string Mail_id { get; set; }

        [Required(ErrorMessage = "Phoneno Cannot Be Blank!")]
        [RegularExpression(@"^[0-9]\d{2}-\d{7}$", ErrorMessage = "Phone should be given with std code Ex:(011-5575525)")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Occupation Cannot Be Blank")]
        public string Occupation { get; set; }


        public string Status { get; set; }


        public string Role_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Vehicle_Booking1> Customer_Vehicle_Booking1 { get; set; }
    }
}
