using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Permissions
    {
        private int idPermission, idModule, idRole;
        private String dateCrea, dateMod;
        private bool active;

        public int IdPermission
        {
            get
            {
                return idPermission;
            }
            set
            {
                idPermission = value;
            }
        }
        public int IdModule
        {
            get
            {
                return idModule;
            }
            set
            {
                idModule = value;
            }
        }
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