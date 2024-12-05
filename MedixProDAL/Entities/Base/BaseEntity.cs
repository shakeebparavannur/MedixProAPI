using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MedixProDAL.Entities.Base
{
    public class BaseEntity:IEntity
    {
       
        
            [Key]
            [Column("Id", TypeName = "bigint")]
            [Required]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public long Id { get; set; }

            [Column("CreatedBy", TypeName = "bigint")]
            public long? CreatedBy { get; set; }
            [Column("CreatedOn", TypeName = "datetime")]
            public DateTime? CreatedOn { get; set; }

            [Column("ModifiedBy", TypeName = "bigint")]
            public long? ModifiedBy { get; set; }
            [Column("ModifiedOn", TypeName = "datetime")]
            public DateTime? ModifiedOn { get; set; }

            [Column("DeletedBy", TypeName = "bigint")]
            public long? DeletedBy { get; set; }

            [Column("DeletedOn", TypeName = "datetime")]
            public DateTime? DeletedOn { get; set; }

            [Column("IsDeleted", TypeName = "bit")]
            [Required]
            public bool IsDeleted { get; set; }

            
        
    }
}
