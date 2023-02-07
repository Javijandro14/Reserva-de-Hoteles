using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class EventAttendance
    {
        private int idEvents,idClient;

        public int IdEvents
        {
            get
            {
                return idEvents;
            }
            set
            {
                idEvents = value;
            }
        }
        public int IdClient 
        {
            get
            {
                return idClient;
            }
            set
            {
                idClient = value;
            }
        }
    }
}