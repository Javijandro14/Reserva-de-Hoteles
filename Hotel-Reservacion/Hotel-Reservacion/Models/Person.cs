using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Person
    {
        private int idPerson;
        private bool active;
        private String fName, sName, oName, fSurname, sSurname,
                mSurname, dob, gender, idNo, phone, email, ethnicity, dateCrea, dateMod;

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
        public String FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public String SName
        {
            get
            {
                return sName;
            }
            set
            {
                sName = value;
            }
        }
        public String OName
        {
            get
            {
                return oName;
            }
            set
            {
                oName = value;
            }
        }
        public String FSurname
        {
            get
            {
                return fSurname;
            }
            set
            {
                fSurname = value;
            }
        }
        public String SSurname
        {
            get
            {
                return sSurname;
            }
            set
            {
                sSurname = value;
            }
        }
        public String MSurname
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }
        public String Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public String Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public String IdNo
        {
            get
            {
                return idNo;
            }
            set
            {
                idNo = value;
            }
        }
        public String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public String Ethnicity
        {
            get
            {
                return ethnicity;
            }
            set
            {
                ethnicity = value;
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