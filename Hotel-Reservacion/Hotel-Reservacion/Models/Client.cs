using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Client
    {
        private int idClient, idUser;
        private bool active;
        private String dateCrea, dateMod;
        

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