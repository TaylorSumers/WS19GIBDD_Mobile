using System;
using System.Collections.Generic;
using System.Text;

namespace GIBDD_Mobile.Entities
{
    class DbContext
    {
        public static List<Accident> Accidents = new List<Accident>()
        {
            new Accident
            {
                ID = 1,
                Date = DateTime.Now,
                Type = "Столкновение",
                ParticipantsAmount = 2,
                Victims = 0
            }
        };
    }
}
