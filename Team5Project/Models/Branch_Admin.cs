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

    public partial class Branch_Admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Branch_Admin()
        {
            this.Vehicle_Availability = new HashSet<Vehicle_Availability>();
            this.Branch_Vehicle_Request = new HashSet<Branch_Vehicle_Request>();
        }

        [Required(ErrorMessage = "Id Cannot Be  Blank!")]
        [RegularExpression("^[a-zA-Z0-9]{4,10}$", ErrorMessage = "Enter Aplhanumerics only no Special Characters allowed")]
        public string Branch_id { get; set; }

        [Required(ErrorMessage = "Password Cannot Be Blank!")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,20}$", ErrorMessage = "Password Should contain atleast one Number and one Specail Character  ")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Name Cannot Be  Blank!")]
        [RegularExpression("^[A-Za-z]{1,15}$", ErrorMessage = "Enter only Alphabets")]
        public string Branch_Location { get; set; }

        [Required(ErrorMessage = "Address Cannot Be Blank")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "no special characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Mail_id Cannot Be Blank!")]
        [EmailAddress(ErrorMessage = "Not a Valid Email_id")]
        public string Mail_id { get; set; }

        [Required(ErrorMessage = "Phoneno Cannot Be Blank!")]
        [RegularExpression(@"^[0-9]\d{2}-\d{7}$", ErrorMessage = "Phone should be given with std code Ex:(011-557525)")]
        public string Phone { get; set; }
        public string Status { get; set; }
        public string Role_Type { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle_Availability> Vehicle_Availability { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branch_Vehicle_Request> Branch_Vehicle_Request { get; set; }
    }
}
