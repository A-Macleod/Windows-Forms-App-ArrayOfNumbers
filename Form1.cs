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
        private ArrayOfNumbers newArray;        // declare a refference to ArrayOfNumbers to be used by Form1 Class Methods
        private ArrayOfNumbers newArrayCopy;    // declare a refference to ArrayOfNumbers to be used by Form1 Class Methods
        private int buttonNumber = 0;           // integer variable to store which GUI button was pressed 

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// A Method to output user directions into TextBox2 and to set buttonNumber variable to 1. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            buttonNumber = 1;
            textBox2.Text = $"[1] Please Enter a Number for the Array Size, then click ENTER..";
  
        }


        /// <summary>
        /// A Method to output user directions into TextBox2 and to set the buttonNumber variable to 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            buttonNumber = 2;
            textBox2.Text = $"[2] Are you sure you want to COPY the array? Type YES, then click ENTER.. ";

        }


        /// <summary>
        /// A Method to output user directions into TextBox2 and to set the buttonNumber variable to 3 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            buttonNumber = 3;
            textBox2.Text = $"[3] Are you sure you want to DELETE the array COPY? Type DELETE, then click ENTER.. ";

        }


        /// <summary>
        /// A Method to output user directions into TextBox2 and to set the button Number variable to 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            buttonNumber = 4;
            textBox2.Text = $"[4] Enter ORIGINAL or COPY to select which array to show the Largest value from, then press Enter.";

        }


        /// <summary>
        /// A Method to clear the textBox1 text on the application GUI
        /// </summary>
        private void clearTextBox()
        {
            textBox1.Text = null;
        }


        /// <summary>
        /// A Method that contains a switch statement. The switch will run the operation number depending on the button value
        /// that was pressed on the GUI. Each operation button has its own number value that coresponds to its switch operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_Click(object sender, EventArgs e)
        {
            switch (buttonNumber) {

                case 0:
                break;

                // Create Array
                case 1: 
                
                    int result = 0;
                    bool isValid ;

                    string input = textBox1.Text;
                    isValid = int.TryParse(input, out result);

                    if (isValid && result > 0) {
                            
                        // If Methods do not work, remove the ArrayOfNumbers before "newArray"
                        newArray = new ArrayOfNumbers(result);
                        textBox2.Text = $"New array created. The array is {result} indices long.";
                        buttonNumber = 0;
                        clearTextBox();

                    } else {

                        textBox2.Text = $"Please Enter a Number for the array Size that is Greater than 0, then press ENTER..";
                        clearTextBox();

                    }

                break;


                // Copy Array
                case 2:

                    if(newArray != null) {

                        if (textBox1.Text == "YES") {

                            newArrayCopy = new ArrayOfNumbers(newArray.Array);
                            textBox2.Text = $"New COPY of Original Array Created. The COPIED array is {newArrayCopy.Array.Length} indices long.";
                            clearTextBox();

                        } else {

                            textBox2.Text = $"Please Enter YES to copy the array, othewise choose another option.";
                            clearTextBox();

                        }

                    } else {

                        clearTextBox();
                        textBox2.Text = $"There is NO ARRAY to Copy, Please select another option.";

                    }

                break;


                // Delete Array
                case 3:

                    if(newArrayCopy != null) {

                        if (textBox1.Text == "DELETE") {

                            newArrayCopy = null;
                            textBox2.Text = $"ARRAY COPY DELETED..";
                            clearTextBox();

                        } else {

                            textBox2.Text = $"Please Enter DELETE to remove the array, othewise choose another option.";
                            clearTextBox();

                        }

                    } else {

                        clearTextBox();
                        textBox2.Text = $"There is NO COPY to Delete, Please select another option.";

                    }

                break;


                // Return Largest value in Array
                case 4:

                    if (newArray != null && newArrayCopy != null) {

                        if (textBox1.Text == "ORIGINAL") {

                            textBox2.Text = $"The Largest value is {newArray.ReturnLargestValue().ToString()}";
                            clearTextBox();

                        } else if (textBox1.Text == "COPY") {

                            textBox2.Text = $"The Largest value is {newArrayCopy.ReturnLargestValue().ToString()}";
                            clearTextBox();

                        } else {

                            textBox2.Text = $"Please Enter either ORIGINAL or COPY then press ENTER, or select another option.";

                        }

                        textBox2.Text = $"Please Create array before returning Largest or choose another option.";

                    }

                //textBox2.Text = $"The Largest value in the array is : {newArray.ReturnLargestValue()} .";

                break;




                default:
                break;
            }
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
