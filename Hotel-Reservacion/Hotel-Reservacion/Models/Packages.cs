using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Packages
    {
        private int idPackage;
        private double cost;
        private String name;
        private bool active;

        public int IdPackage
        {
            get
            {
                return idPackage;
            }
            set
            {
                idPackage = value;
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