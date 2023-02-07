using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Meal
    {
        private int idMeal;
        private String name, description;
        private double cost;
        private Boolean active;

        public int IdMeal
        {
            get
            {
                return idMeal;
            }
            set
            {
                idMeal = value;
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
        public Double Cost
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