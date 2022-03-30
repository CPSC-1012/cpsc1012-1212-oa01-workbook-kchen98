using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Objects_Class__DieExercise
{
    public class Die
    {
        // Declare data fields for storing data
        private int _sides; // number of sides for the Die
        private int _value; // face value of the Die

        // Properties to encapsulate access to the data fields
        public int Sides
        {
            get // A read-only property contains only an acccessor
            {
                return _sides;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }

        // Define constructors to assign meaningful values to the fields/properties
        //public Die() // Default constructor but at this exercise it's not required
        //{
            //_sides = 6;
        //}
        public Die(int newSides)
        {
            _sides = newSides;
            Roll();
        }

        public void Roll()
        {
            Random random = new Random();
            _value = random.Next(1, Sides + 1);
        }
    }
}
