using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Objects__Class__RoomCalculatorApp
{
    // internal means class is only accessible from within the current project
    // public visibility modifier means class is accessible outside of current project
    public class Rectangle
    {
        // Define data fields to store data
        private double _length;
        private double _width;

        // Define properties to encapsulate access to the data fields
        public double Length
        {
            get 
            { 
                return _length;              
            }
            set // inside the set block you can use the value is keyword to check new value being assigned
            { 
                // Throw new exception if the new value is zero or negative
                if (value <= 0)
                { 
                    throw new Exception("Length must be a positive non-zero number");
                }
                _length = value;               
            }

        }

        public double Width
        {
            get 
            { 
                return _width; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Width must be a positive non-zero number");
                }
                _width = value;               
            }
        }

        // Define zero or more constructors to set the data fields or properties to meaningful values
        // If the class does not include any constructor the compiler will generate a default no-argument constructor
        // A constructor has no return type and is name the same as the Class name

        //public Rectangle() // Example of Default no-argument constructor
        //{

        //}
        // Define a parameterized (greedy) constructor that is passed in the length and width
        public Rectangle(double newLength, double newWidth)
        {
            // If the properties includes validation always assign the parameter values to the properties instead of the data fields
            //_length = newLength;
            //_width = newWidth;
            
            Length = newLength;
            Width = newWidth;   
        }

        // Define instance-level methods that perform operations using data fields or properties
        public double Area()
        {
            return _length * _width;
        }

        // Define class-level methods that does not use data fields or properties
        //public static double Area(double length, double width)
        //{
        //    return length * width;
        //}
    }
}
