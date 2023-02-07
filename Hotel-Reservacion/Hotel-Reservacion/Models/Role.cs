using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Role
    {
        private int idRole;
        private String name, description, dateCrea, dateMod;
        private bool active;

        public int IdRole
        {
            get
            {
                return idRole;
            }
            set
            {
                idRole = value;
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