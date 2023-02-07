using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Reservation
    {
        private String idReservation, dateCrea, dateMod;
        private bool active;
        private int idClient, idRoom, idPackages;


        public String IdReservation
        {
            get
            {
                return idReservation;
            }
            set
            {
                idReservation = value;
            }
        }
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
        public int IdRoom
        {
            get
            {
                return idRoom;
            }
            set
            {
                idRoom = value;
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