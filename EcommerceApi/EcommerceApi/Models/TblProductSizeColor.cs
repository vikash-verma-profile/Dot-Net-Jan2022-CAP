using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class TblProductSizeColor
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? SizeId { get; set; }
        public int? ColorId { get; set; }
        public int? CatId { get; set; }
        public int? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
