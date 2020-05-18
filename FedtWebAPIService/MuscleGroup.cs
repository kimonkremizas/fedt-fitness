namespace FedtWebAPIService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MuscleGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Muscles_ID { get; set; }

        [StringLength(50)]
        public string MGName{ get; set; }
    }
}
