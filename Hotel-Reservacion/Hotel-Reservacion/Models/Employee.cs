using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Employee
    {
        private int idEmployee, idRole, idUser;
        private bool active;
        private String dateCrea, dateMod;
        

        public int IdEmployee
        {
            get
            {
                return idEmployee;
            }
            set
            {
                idEmployee = value;
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
        public int IdUser
        {
            get
            {
                return idUser;
            }
            set
            {
                idUser = value;
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