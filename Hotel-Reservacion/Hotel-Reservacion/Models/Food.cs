using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Food
    {
        private int idFood, idRestaurant;
        private double cost;
        private String name, description, type, dateCrea, dateMod;
        private bool active;
        

        public int IdFood
        {
            get
            {
                return idFood;
            }
            set
            {
                idFood = value;
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
        public String Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
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