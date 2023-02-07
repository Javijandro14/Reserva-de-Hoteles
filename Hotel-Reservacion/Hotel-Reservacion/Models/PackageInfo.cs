using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class PackageInfo
    {
        private String name;
        private bool active;
        private int idPackages;

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
        public int IdPackages
        {
            get
            {
                return idPackages;
            }
            set
            {
                idPackages = value;
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