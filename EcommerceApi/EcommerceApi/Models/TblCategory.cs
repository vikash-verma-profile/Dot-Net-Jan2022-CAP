using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class TblCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public int? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
