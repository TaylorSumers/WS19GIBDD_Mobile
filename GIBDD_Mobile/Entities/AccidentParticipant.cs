using System;
using System.Collections.Generic;
using System.Text;

namespace GIBDD_Mobile.Entities
{
    public class AccidentParticipant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string LicenseNum { get; set; }
    }
}
