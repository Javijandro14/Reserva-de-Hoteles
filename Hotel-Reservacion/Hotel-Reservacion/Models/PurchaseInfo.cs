using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class PurchaseInfo
    {
        private double cost, discounts, total;
        private String description;
        private int idPurchase;

        public int IdPurchase
        {
            get
            {
                return idPurchase;
            }
            set
            {
                idPurchase = value;
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
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        public double Discounts
        {
            get
            {
                return discounts;
            }
            set
            {
                discounts = value;
            }
        }
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
    }
}