using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Module
    {
        private int idModule, idFatherModule;
        private String name, description, path, level, order, dateCrea, dateMod;
        private bool active;

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
        public String Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
        public String Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        public String Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
            }
        }
        public int IdFatherModule
        {
            get
            {
                return idFatherModule;
            }
            set
            {
                idFatherModule = value;
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