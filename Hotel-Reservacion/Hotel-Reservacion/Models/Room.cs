using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Room 
    {
        private int idRoom, numShowers, numRooms, status;
        private String description, dateCrea, dateMod;
        private Area area;

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
        public int NumShowers
        {
            get
            {
                return numShowers;
            }
            set
            {
                numShowers = value;
            }
        }
        public int NumRooms
        {
            get
            {
                return numRooms;
            }
            set
            {
                numRooms = value;
            }
        }
        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public Area Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public String DateCrea
        {
            get
            {
                return dateCrea;
            }
            set
            {
                dateCrea = value;
            }
        }
        public String DateMod
        {
            get
            {
                return dateMod;
            }
            set
            {
                dateMod = value;
            }
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}