using MedixProDAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedixProDAL.Entities
{
    public class CustomerProfile:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public string City { get; set; }
        public long Mobile {  get; set; }
        public int Gender { get; set; }
        public string? Email { get; set; }
        public long? EmergencyContact { get; set; }
        public string? BloodGroup { get; set; }
        public int Age { get; set; }
        public DateTime? DateofBirth { get; set; }

    }
}
