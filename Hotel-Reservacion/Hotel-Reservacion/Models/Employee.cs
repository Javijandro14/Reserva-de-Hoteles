using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Employee
    {
        private int idEmployee;
        private bool active;
        private String dateCrea, dateMod;
        private Role role;
        private User user;

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
        public Role Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
        public User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
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