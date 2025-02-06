using System;
using System.CodeDom;
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
    /// <summary>
    /// Form class for the application GUI
    /// </summary>
    public partial class Form1 : Form
    {
        private ArrayOfNumbers newArray;   // Declare a refference to ArrayOfNumbers to be used by Form1 Class Methods
        

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// OnClick Method to create array at given size. Takes size value from TextBox1. Catch error exception and output
        /// error message if the try parse from textBox1 does not contain a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            try {

                string input = textBox1.Text;
                int result = int.Parse(input);

                if (result > 0) {

                    newArray = new ArrayOfNumbers(result);
                    textBox2.Text = $"New Array of size '{result}' Created.";
                    clearTextBox();

                } else {
                    textBox2.Text = $"Please Enter a Number for the Array Size that is Greater than 0";
                }


            } catch (Exception ex) {

                textBox2.Text = $"Please Enter a Number for the Array Size, then press ENTER.. + {ex.Message}";

            }
  
        }


        /// <summary>
        /// A Method to clear the textBox1 text on the application GUI
        /// </summary>
        private void clearTextBox()
        {
            textBox1.Text = null;
        }




    

        /// Add a ReadMe Doc.. week 3 notes
























    }   // EO Form1 class


    /// <summary>
    /// Represents a fixed size collection that can change its stored numbers and perform mathematic operations  
    /// </summary>
    public class ArrayOfNumbers
    {
        private int[] _array;    // Private field integer Array 

        /// <summary>
        /// Property to get the array object
        /// </summary>
        public int[] Array 
        {
            get { return _array; }
            //set { _array = value; }
        }

        /// <summary>
        /// Constructor #1
        /// Accepts integer param that specifies the size of the Array. 
        /// Initialise all elements to zero.
        /// </summary>
        /// <param name="sizeOfArray">The integer value to create an array of this given size</param>
        public ArrayOfNumbers(int sizeOfArray)
        {

            _array = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++) { // Loop through and set each index value to 0
                _array[i] = 0;
            }

        }


        /// <summary>
        /// Constructor #2 
        /// Accepts array of integers as input and creates a copy of it for internal storage
        /// Create a new array and copy each element
        /// </summary>
        /// <param name="arrayToCopy">The initial object reference</param>
        public ArrayOfNumbers(int[] arrayToCopy)
        {

            _array = new int[arrayToCopy.Length];  // Creates a new _arrayOfNumbers object using an arrayToCopys Length to determine its size

            for (int i = 0; i < arrayToCopy.Length; i++) {  // Loop through and set the new array indexs to the same as the copied array 
                _array[i] = arrayToCopy[i];
            }

        }


        /// <summary>
        /// A Method to Return the value at a specificed array index position
        /// </summary>
        /// <param name="indexNumber">The index number</param>
        /// <returns>The integer value of the index number</returns>
        public int ReturnElementValue(int indexNumber)
        {
            return _array[indexNumber];
        }


        /// <summary>
        /// A Method to Set an element at the specificed array index to the given value 
        /// </summary>
        /// <param name="indexNumber">The number of the index</param>
        /// <param name="value">The value you want to insert</param>
        public void SetElementValue(int indexNumber, int value)
        {
            _array[indexNumber] = value;
        }


        /// <summary>
        /// A Method to Return the highest value in an array. It will loop through all indexs in the array
        /// and if its value is higher than the stored variable it will set that number to the new largest var number  
        /// </summary>
        /// <returns>The largest integer value in the array</returns>
        public int ReturnLargestValue()
        {
            int largest = 0;

            for(int i = 0; i < _array.Length; i++) {   // Loop through the array
                if (_array[i] > largest) {             // If the index value is greater than var largest
                    largest = _array[i];               // set var largest to that array index value
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

            for (int i = 0; i < _array.Length; ++i) {

                  a = _array[elementA];
                  b = _array[elementB];

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
            return _array.Length;
        }


        /// <summary>
        /// A Method to Return the total of the array index values
        /// </summary>
        /// <returns>The total sum of the array</returns>
        public int ReturnSum()
        {
            int sum = 0;

            for (int i = 0; i < _array.Length; i++) {

                sum += _array[i];

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

            for (int i = 0; i < _array.Length; i++) {
                value[_array.Length] += _array[i].ToString();   
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

            for(int i = 0; i < _array.Length; i++) {   // Loop through and multiply each index value by the scalar value 
                _array[i] *= scalarValue;
                value = _array[i];

            }

            return value;

        }


        /// <summary>
        /// A Method to Return the values of each element in the array after the constant has been added to it
        /// </summary>
        /// <returns>Returns the value of each new index value</returns>
        public int ReturnAddConstant()
        {
            
            const int constantValue = 100;  // A Constant is a var whose value cannot be changed after assignemnt
            int value = 0;

            for (int i = 0; i < _array.Length; i++) {
                _array[i] += constantValue;
                value = _array[i];

            }

            return value;

        }



    }   //  EO ArrayOfNumbers class
}   // EO namespace
