using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GIBDD_Mobile.Entities
{
    public class Accident
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int Victims { get; set; }
        public string Note { get; set; }
        public List<AccidentParticipant> Participants = new List<AccidentParticipant>();
        public AccidentPlace Place = new AccidentPlace();
        public List<Vehicle> Vehicles = new List<Vehicle>();

        public string Type { get; set; }
        public int ParticipantsAmount { get; set; } // Override
        public string Color
        {
            get
            {
                if (Victims == 0) return "Green";
                else if (Victims == 1) return "Yellow";
                else return "Red";
            }
        }
    }
}
