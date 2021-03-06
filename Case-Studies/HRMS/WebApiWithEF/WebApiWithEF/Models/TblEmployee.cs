using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiWithEF.Models
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public int? Age { get; set; }
        public int? Salary { get; set; }
        public int? Gender { get; set; }
        public string EmailId { get; set; }
        public string AlternateEmailId { get; set; }
        public int? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
