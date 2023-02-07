using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class User
    {
        private int idUser, idPerson;
        private String username, pass, type, dateCrea, dateMod;
        private bool active;

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
        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public String Pass
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
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
        public int IdPerson
        {
            get
            {
                return idPerson;
            }
            set
            {
                idPerson = value;
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