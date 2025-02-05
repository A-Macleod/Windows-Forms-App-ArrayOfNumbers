using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOfNumbers
{
    public partial class Form1 : Form
    {
        //private ArrayOfNumbers newArrayOfNumbers;   // Declare a refference to ArrayOfNumbers to be used by Form1 Class Methods

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// Add a ReadMe Doc.. week 3 notes

    }   // EO Form1 class


    /// <summary>
    /// Represents a fixed size collection that can change its stored numbers and perform mathematic operations  
    /// </summary>
    public class ArrayOfNumbers
    {
        private int[] _arrayOfNumbers;    // Private field integer Array 


        /// <summary>
        /// Constructor #1
        /// Accepts integer param that specifies the size of the Array. 
        /// Initialise all elements to zero.
        /// </summary>
        /// <param name="sizeOfArray">The integer value to create an array of this given size</param>
        public ArrayOfNumbers(int sizeOfArray)
        {

            _arrayOfNumbers = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++) { // Loop through and set each index value to 0
                _arrayOfNumbers[i] = 0;
            }

        }


        /// <summary>
        /// Constructor #2 
        /// Accepts array of integers as input and creates a copy of it for internal storage.
        /// Create a new array and copy each element.
        /// </summary>
        /// <param name="arrayToCopy">The initial object reference</param>
        public ArrayOfNumbers(int[] arrayToCopy)
        {

            _arrayOfNumbers = new int[arrayToCopy.Length];  // Creates a new _arrayOfNumbers object using an arrayToCopys Length to determine its size

            for (int i = 0; i < arrayToCopy.Length; i++) {  // Loop through and set the new array indexs to the same as the copied array 
                _arrayOfNumbers[i] = arrayToCopy[i];
            }

        }


        /// <summary>
        /// A Method to Return the value at a specificed index position.
        /// </summary>
        /// <param name="indexNumber">The index number</param>
        /// <returns>The integer value of the index number</returns>
        public int ReturnElementValue(int indexNumber)
        {
            return _arrayOfNumbers[indexNumber];
        }


        /// <summary>
        /// A Method to Set an element at the specificed index to the given value 
        /// </summary>
        /// <param name="indexNumber">The number of the index</param>
        /// <param name="value">The value you want to insert</param>
        public void SetElementValue(int indexNumber, int value)
        {
            _arrayOfNumbers[indexNumber] = value;
        }


        /// <summary>
        /// A Method to Return the highest value in an array. It will loop through all indexs in the array
        /// and if its value is higher than the stored variable it will set that number to the new largest var number  
        /// </summary>
        /// <returns>The largest integer value in the array</returns>
        public int ReturnLargestValue()
        {
            int largest = 0;

            for(int i = 0; i < _arrayOfNumbers.Length; i++) {   // Loop through the array
                if (_arrayOfNumbers[i] > largest) {             // If the index value is greater than var largest
                    largest = _arrayOfNumbers[i];               // set var largest to that array index value
                }
            }

            return largest;                                     

        }


        /// <summary>
        /// A Method to Return the GCD of two integers. The Method takes in two integer arguments and loops through
        /// the array object to find the index values of those integers. The values are then used in the GCD algorithm
        /// and the GCD is returned
        /// </summary>
        /// <param name="elementA">the first element number</param>
        /// <param name="elementB">the second element number</param>
        /// <returns>The GCD of the values at index position A and B in the array</returns>
        public int GCD(int elementA, int elementB)
        {

            int a = 0;
            int b = 0;

            for (int i = 0; i < _arrayOfNumbers.Length; ++i) {

                  a = _arrayOfNumbers[elementA];
                  b = _arrayOfNumbers[elementB];

            }

            while (a != b) {    // Euclids Algorithm 

                if (a > b) {

                    a = a - b;

                } else {

                    b = b - a;
                }

            }

            return a;   // Return the Greatest Common Divisor

        }


        /// <summary>
        /// A Method to Return the array length 
        /// </summary>
        /// <returns>The length of the array</returns>
        public int ReturnCount()
        {
            return _arrayOfNumbers.Length;
        }


        /// <summary>
        /// A Method to Return the total of the array index values
        /// </summary>
        /// <returns>The total sum of the array</returns>
        public int ReturnSum()
        {
            int sum = 0;

            for (int i = 0; i < _arrayOfNumbers.Length; i++) {

                sum += _arrayOfNumbers[i];

            }

            return sum;
        }


        /// <summary>
        /// A Method to Return the Average integer number in the array
        /// </summary>
        /// <returns>The average integer value, average = total / count </returns>
        public int ReturnAverage()
        {
            int count = ReturnCount();
            int total = ReturnSum();
            int average = total / count ;
            
            return average;

        }


        /// <summary>
        /// A Method to Return entire array as a string
        /// </summary>
        /// <returns>The value of the array as a string</returns>
        public override string ToString()
        {
            string[] value = { " ," };

            for (int i = 0; i < _arrayOfNumbers.Length; i++) {
                value[_arrayOfNumbers.Length] += _arrayOfNumbers[i].ToString();   
            }

            return value.ToString();

        }


        /// <summary>
        /// A Method to Return the value of each element in the array when multiplied by a scalar value
        /// </summary>
        /// <param name="scalarValue">The number to multiply by</param>
        /// <returns>The new value of the array index</returns>
        public int ReturnScalarMultiply(int scalarValue)
        {
            // v = k x v
            int value = 0;

            for(int i = 0; i < _arrayOfNumbers.Length; i++) {   // Loop through and multiply each index value by the scalar value 
                _arrayOfNumbers[i] *= scalarValue;
                value = _arrayOfNumbers[i];

            }

            return value;

        }


        /// <summary>
        /// A Method to Return the values of each element in the array after the constant has been added to it
        /// </summary>
        /// <returns>Returns the value of each new index value</returns>
        public int ReturnAddConstant()
        {
            
            const int constantValue = 10;  // A Constant is a var whose value cannot be changed after assignemnt
            int value = 0;

            for (int i = 0; i < _arrayOfNumbers.Length; i++) {
                _arrayOfNumbers[i] += constantValue;
                value = _arrayOfNumbers[i];

            }

            return value;

        }



    }   //  EO ArrayOfNumbers class
}   // EO namespace
