using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class MealInfo
    {
        private int idMeal,idFood;

        public int IdFood
        {
            get
            {
                return idFood;
            }
            set
            {
                idFood = value;
            }
        }
        public int IdMeal
        {
            get
            {
                return idMeal;
            }
            set
            {
                idMeal = value;
            }
        }
    }
}