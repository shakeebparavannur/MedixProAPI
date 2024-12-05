using MedixProDAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedixProDAL.Entities
{
    public class Role:BaseEntity
    {
        public int Id { get; set; }
        public string RoleName {  get; set; }
    }
}
