using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class RoomItems
    {
        private int idRoom;
        private String name;
        private Boolean active;

        public int IdRoom
        {
            get
            {
                return idRoom;
            }
            set
            {
                idRoom = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
    }
}