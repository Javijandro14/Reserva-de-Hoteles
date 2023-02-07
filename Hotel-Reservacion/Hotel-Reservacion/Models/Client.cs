using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Client
    {
        private int idClient;
        private bool active;
        private String dateCrea, dateMod;
        private User user;

        public int IdClient
        {
            get
            {
                return idClient;
            }
            set
            {
                idClient = value;
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