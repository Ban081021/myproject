namespace AssigmentManageStaff.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public bool Gender { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(50)]
        public string phoneNumber { get; set; }

        public long? IdPosition { get; set; }

        public bool isManager { get; set; }

        public bool isStaff { get; set; }

        public virtual Position Position { get; set; }
    }
}
