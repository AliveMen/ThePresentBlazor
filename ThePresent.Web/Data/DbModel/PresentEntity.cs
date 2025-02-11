﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThePresent.Web.Core.Common;

namespace ThePresent.Web.Data.DbModel
{
    public class PresentEntity : AuditableEntity
    {
        public string UserId { get; set; }

        public virtual CustomerEntity Customer { get; set; }

        [StringLength(256)]
        public string Name { get; set; }
        public string Description { get; set; }

        public string LinkToProduct { get; set; }
        public string LinkToPicture { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }


    }
}