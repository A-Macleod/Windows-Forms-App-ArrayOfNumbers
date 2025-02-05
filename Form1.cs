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



    public class ArrayOfNumbers
    {
        private int[] _arrayOfNumbers;    // Private field integer Array 

        // Constructor #1 
        // Accepts integer param that specifies the size of the Array.
        // Initialise all elements to zero.
        public ArrayOfNumbers(int sizeOfArray)
        {

            _arrayOfNumbers = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++) { // Loop through and set each index value to 0
                _arrayOfNumbers[i] = 0;
            }

        }

        // Constructor #2 
        // Accepts array of integers as input and creates a copy of it for internal storage.
        // Create a new array and copy each element.
        // (Research difference, reference types - primitive (value) types first)
        public ArrayOfNumbers(int[] arrayToCopy)
        {

            _arrayOfNumbers = new int[arrayToCopy.Length];  // Creates a new _arrayOfNumbers object using an arrayToCopys Length to determine its size

            for (int i = 0; i < arrayToCopy.Length; i++) {  // Loop through and set the new array indexs to the same as the copied array 
                _arrayOfNumbers[i] = arrayToCopy[i];
            }

        }

        // Property  Get/Set
        // Method to return element from array at specificed Index
        // Method to set an element at specificed index to the given value

        /// <summary>
        /// A Method to Return the value of an array index position
        /// </summary>
        /// <param name="indexNumber">The index number</param>
        /// <returns>The integer value of the index number</returns>
        public int ReturnElementValue(int indexNumber)
        {
            return _arrayOfNumbers[indexNumber];
        }

        /// <summary>
        /// A Method to Set the value of an index in an array 
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












    }   //  EO ArrayOfNumbers class



    /// <summary>
    /// Example Text Here
    /// </summary>
    /// <param name="PARAMNAME"> Description of param: Description of validation:</param>


    // DisplayAll() {
    // Foreach loop
    //}









}   // EO namespace
