using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Restaurant
    {
        private int idRestaurant, idArea;
        private String name, startTime, endTime, dateCrea, dateMod;
        private bool active;

        public int IdRestaurant
        {
            get
            {
                return idRestaurant;
            }
            set
            {
                idRestaurant = value;
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
        public String StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }
        public String EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }
        public int IdArea
        {
            get
            {
                return idArea;
            }
            set
            {
                idArea = value;
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