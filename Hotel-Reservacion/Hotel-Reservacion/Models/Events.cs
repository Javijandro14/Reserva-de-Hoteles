using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Events
    {
        private int idEvent;
        private double cost;
        private String name, description, startDate, endDate, duration, dateCrea, dateMod;
        private Area area;

        public int IdEvent
        {
            get
            {
                return idEvent;
            }
            set
            {
                idEvent = value;
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
        public String StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public String EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public String Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
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
    }
}