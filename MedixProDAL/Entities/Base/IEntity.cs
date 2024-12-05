using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedixProDAL.Entities.Base
{
    public interface IEntity
    {
        long Id { get; set; }
    }
}
