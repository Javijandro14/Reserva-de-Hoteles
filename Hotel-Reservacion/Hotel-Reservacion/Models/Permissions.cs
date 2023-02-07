using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Permissions
    {
        private int idPermission;
        private String dateCrea, dateMod;
        private Module module;
        private Role role;
        private bool active;

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