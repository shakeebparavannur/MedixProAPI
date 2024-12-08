using MedixProDAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedixProDAL.Entities
{
    public class User:BaseEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int RoleId {  get; set; }
        public Role Role {  get; set; }
    }
}
