using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class EventAttendance
    {
        private Events events;
        private Client client;

        public Events Events
        {
            get
            {
                return events;
            }
            set
            {
                events = value;
            }
        }
        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }
    }
}