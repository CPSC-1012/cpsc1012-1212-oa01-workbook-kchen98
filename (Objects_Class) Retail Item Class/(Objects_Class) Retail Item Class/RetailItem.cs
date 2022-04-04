using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Objects_Class__Retail_Item_Class
{
    public class RetailItem
    {
        private string _description;
        private int _unitsOnHand;
        private decimal _price;

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Description cannot be blank");
                }
                else
                {
                    _description = value;
                }
            }
        }

        public int UnitsOnHand
        {
            get 
            { 
                return _unitsOnHand; 
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Must have a positive integer value");
                }
                else
                {
                    _unitsOnHand = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set 
            {
                if (value < 0)
                {
                    throw new Exception("Must have a positive decimal value");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public RetailItem (string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Description}, {UnitsOnHand}, {TotalValue():c}";
        }

        public decimal TotalValue()
        {          
            return _unitsOnHand * _price;
        }
    }
}
