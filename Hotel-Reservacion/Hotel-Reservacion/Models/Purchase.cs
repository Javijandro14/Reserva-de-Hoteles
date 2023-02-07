using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservacion.Models
{
    public class Purchase
    {
        private int idPurchase,idClient;
        private String description, transactionDate;
        private double total;

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
        public String TransactionDate
        {
            get
            {
                return transactionDate;
            }
            set
            {
                transactionDate = value;
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