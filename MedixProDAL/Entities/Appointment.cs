using MedixProDAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedixProDAL.Entities
{
    public class Appointment:BaseEntity
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId {  get; set; }
        public DateTime AppointmentDate { get; set; }
        public int TokenNumber {  get; set; }
        public string TimeSlot { get; set; }
        public long ConsultationFee { get; set; }
        public string Notes { get; set; }
        public bool IsEmergency { get; set; }


    }
}
