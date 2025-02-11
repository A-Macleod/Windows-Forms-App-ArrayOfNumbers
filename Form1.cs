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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        /// A Method to output user directions into TextBox2 and to set the buttonNumber variable to 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            buttonNumber = 4;
            textBox2.Text = $"[4] Enter ORIGINAL or COPY to select which array to show the Largest value from, then press Enter.";

        }


        /// <summary>
        /// A Method to output user directions into TextBox2 and to set the buttonNumber variable to 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            buttonNumber = 5;
            textBox2.Text = $"[5] To check for Equality, type two array indice Numbers. The Numbers have to be Positive, then press ENTER ";

        }

        /// <summary>
        /// A Method to output user direction into TextBox2 and to set the buttonNumber variable to 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            buttonNumber = 6;
            textBox2.Text = $"[6] To check the GCD of two values in the array, type either the [ORIGINAL or COPY] followed by two Positive indice Numbers, then press ENTER..";

        }

        /// <summary>
        /// A Method to output user direction into TextBox2 and to set the buttonNumber variable to 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            buttonNumber = 7;
            textBox2.Text = $"[7] To check the Count of the array indices, type either [ORIGINAL or COPY] then press ENTER..";
        }

        /// <summary>
        /// A Method to output user direction into TextBox2 and to set the buttonNumber variable to 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            buttonNumber = 8;
            textBox2.Text = $"[8] To check the Sum of all elements in the array, type either [ORIGINAL or COPY] then press ENTER..";
        }

        /// <summary>
        /// A Method to output user direction into TextBox2 and to set the buttonNumber variable to 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            buttonNumber = 9;
            textBox2.Text = $"[9] To check the Average of all elements in the array, type either [ORIGINAL or COPY] then press ENTER..";
        }

        /// <summary>
        /// A Method to output user direction into TextBox2 and to set the buttonNumber variable to 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {   
            buttonNumber = 10;
            textBox2.Text = $"[10] To Multiply all elements in the array by a Scalar value, type either [ORIGINAL or COPY] and [SCALAR NUMBER] then press ENTER.."; 
        }

        /// <summary>
        /// A Method to output user direction into TextBox2 and to set the buttonNumber variable to 11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            buttonNumber = 11;
            textBox2.Text = $"[11] To Add a Constant to all elements in the array, type either [ORIGINAL or COPY] then press ENTER..";
        }

        /// <summary>
        /// A Method to output user direction into TextBox2 and to set the buttonNumber variable to 12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            buttonNumber = 12;
            textBox2.Text = $"[12] To see the String Formatted Representation of the array, type either [ORIGINAL or COPY] then press ENTER..";
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
                bool isValid;

                string input = textBox1.Text;
                isValid = int.TryParse(input, out result);

                if (isValid && result > 0) {

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

                if (newArray != null) {

                    if (textBox1.Text == "YES") {

                        newArrayCopy = new ArrayOfNumbers(newArray.Array);
                        textBox2.Text = $"New COPY of Original Array Created. The COPIED array is {newArrayCopy.Array.Length} indices long.";
                        buttonNumber = 0;
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

                if (newArrayCopy != null) {

                    if (textBox1.Text == "DELETE") {

                        newArrayCopy = null;
                        textBox2.Text = $"ARRAY COPY DELETED..";
                        buttonNumber = 0;
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

                // Validate the string in textBox1
                if (newArray != null && textBox1.Text == "ORIGINAL") {

                    textBox2.Text = $"The Largest value is {newArray.ReturnLargestValue().ToString()}";
                    buttonNumber = 0;
                    clearTextBox();

                } else if (newArrayCopy != null && textBox1.Text == "COPY") {

                    textBox2.Text = $"The Largest value is {newArrayCopy.ReturnLargestValue().ToString()}";
                    buttonNumber = 0;
                    clearTextBox();

                } else {

                    if (newArray == null && newArrayCopy == null) {

                        textBox2.Text = $"There is NO ARRAY to return the Largest value. Please Create array and try again.";
                        clearTextBox();
                    }
                }

                break;


                // Return true if two integer values are the same at specified index
                case 5:

                /// Add user prompt to select which array to work on

                int a = 0;
                int b = 0;
                bool isValidA;
                bool isValidB;
                string[] indexString = textBox1.Text.Split(' '); // seperate the input with a space


                try {

                    isValidA = int.TryParse(indexString[0], out a); // return true if array index 0 is an integer, and output to int a
                    isValidB = int.TryParse(indexString[1], out b); // return true if array index 1 is an integer, and output to int b

                    if (isValidA && isValidB) { // if they are true, and both integers

                        if (a > -1 && b > -1) { // if they are both greater than -1, the array starts at position 0

                            textBox2.Text = $"Are Array Indices {a} & {b} Equal Values? : {newArray.ReturnIsEqual(a, b)}.  First Value: {newArray.ReturnElementValue(a)} Second Value: {newArray.ReturnElementValue(b)} ";
                            buttonNumber = 0;
                            indexString = null;
                            clearTextBox();
                            return;

                        } else { // Error Message, if there is a negative index number

                            textBox2.Text = $"Please type two Positive Numbers seperated by a space, then press ENTER.";
                            clearTextBox();
                            textBox1.Focus();

                        }

                    } else { // Error Message, if there is no integer and not valid

                        textBox2.Text = $"Please type two Positive Indice Numbers. Type the Numbers seperated by a space, then press ENTER ";
                        clearTextBox();
                        textBox1.Focus();
                    }

                } catch (Exception ex) { // Error Message, if there is a missing argument or too many arguments (arrayOutOfBounds)

                    textBox2.Text = $"You must type two Positive Array Indice Numbers, within the size of the array:  {ex.Message}";
                    clearTextBox();
                    textBox1.Focus();

                }

                //do {
                //    textBox2.Text = $"Thank you, First Index Position = {a} . " + $"Type SECOND Number, then press ENTER..";

                //    if (!isValidA) { // Error Message

                //        textBox2.Text = $"Please type a Positive Number and press Enter, or choose another operation.";
                //        clearTextBox();

                //    }

                //} while (!isValidA && a > 0);

                //do {
                //    isValidB = int.TryParse(textBox1.Text, out b); // Validate textBox1 user input, firstNumber
                //    clearTextBox();

                //    if (b > 0) {

                //        textBox2.Text = $"Thank you, Second Index Position = {b} . ";
                //        clearTextBox();

                //    } else { // Error Message

                //        textBox2.Text = $"Please type a Positive Number and press Enter, or choose another operation.";
                //        clearTextBox();

                //    }

                //} while (!isValidB);

                //if (isValidA == true && isValidB == true) {

                //}

                break;


                /// Return the GCD of two array index values. Taking 3 inputs from textBox1and validating these inputs.
                case 6:

                int x, y = 0;
                bool isValidAGCD;
                bool isValidBGCD;
                string[] indexStringGCD = textBox1.Text.Split(' '); // seperate array input with a space


                try {

                    if (indexStringGCD.Length != 3) { // if textBox1 does not contain 3 arguments, display error

                        textBox2.Text = $"[1] Please type Array [ORIGINAL or COPY] and [Index Number #1] and [Index Number #2]";
                        textBox1.Focus();
                        clearTextBox();
                        return;

                    }


                    if (indexStringGCD[0] != "ORIGINAL" && indexStringGCD[0] != "COPY") { // if index 0 does not equal this or this, display error

                        textBox2.Text = $"[2] Please type Array [ORIGINAL or COPY] and [Index Number #1] and [Index Number #2]";
                        textBox1.Focus();
                        clearTextBox();
                        return;

                    }


                    isValidAGCD = int.TryParse(indexStringGCD[0], out x);
                    isValidBGCD = int.TryParse(indexStringGCD[1], out y);

                    if (isValidAGCD != true && isValidBGCD != true) { // if the parsed numbers are not valid, display error

                        textBox2.Text = $"[3] Please type Array [ORIGINAL or COPY] and [Index Number #1] and [Index Number #2]";
                        textBox1.Focus();
                        clearTextBox();
                        return;

                    }


                    if (x < 0 || y < 0) { // if index numbers are less than 0, display error

                        textBox2.Text = $"[4] Please type Array [ORIGINAL or COPY] and [Index Number #1] and [Index Number #2]";
                        textBox1.Focus();
                        clearTextBox();
                        return;

                    }


                    if (indexStringGCD[0] == "ORIGINAL" && newArray != null) { // display GCD of newArray using these indices values

                        textBox2.Text = $"The Greatest Common Divisor of {newArray.ReturnElementValue(x)} and {newArray.ReturnElementValue(y)} is {newArray.GCD(x,y).ToString()}";
                        buttonNumber = 0;
                        clearTextBox();

                    } else if (indexStringGCD[0] == "COPY" && newArrayCopy != null) { // display GCD of newArrayCopy using these indices values

                        textBox2.Text = $"The Greatest Common Divisor of {newArrayCopy.ReturnElementValue(x)} and {newArrayCopy.ReturnElementValue(y)} is {newArrayCopy.GCD(x, y).ToString()}";
                        buttonNumber = 0;
                        clearTextBox();

                    } else { // Error Message

                        textBox2.Text = $"[5] That Array does not exist. Please create that Array type then try again.";
                        clearTextBox();

                    }

                } catch (Exception ex) {

                    textBox2.Text = $"[6] Please type Array [ORIGINAL or COPY] and [Index Number #1] and [Index Number #2]: {ex.Message}";
                    textBox1.Focus();
                    clearTextBox();
                    return;

                }

                break;


                /// Return the Count of elements in the array
                case 7:

                string arrayTypeCount = textBox1.Text.Trim(); // Trim removes whitespace at end of textBox1 input

                try {

                    if (arrayTypeCount != "ORIGINAL" && arrayTypeCount != "COPY") { // if wrong user input, display error

                        textBox2.Text = $"[1] Please type either [ORIGINAL or COPY] to Count the total amount of array Indices";
                        clearTextBox();
                        return;

                    }


                    if (arrayTypeCount == "ORIGINAL" && newArray == null) { // if array does not exist, display error

                        textBox2.Text = $"[2] Please create a new array, or select another operation";
                        clearTextBox();
                        return;

                    }


                    if (arrayTypeCount == "COPY" && newArrayCopy == null) { // if array copy does not exist, display error

                        textBox2.Text = $"[3] Please create a new array copy, or select another operation ";
                        clearTextBox();
                        return;
                    }


                    if (arrayTypeCount == "ORIGINAL") {

                        textBox2.Text = $"The Index Count for ORIGINAL array is : {newArray.ReturnCount().ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                    if (arrayTypeCount == "COPY") {

                        textBox2.Text = $"The Index Count for COPY array is : {newArrayCopy.ReturnCount().ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                } catch (Exception ex) {

                    textBox2.Text = $"{ex.Message}";
                    return;

                }

                break;


                /// Display the sum of all elements in the array
                case 8:

                    string arrayTypeSum = textBox1.Text.Trim();

                try {

                    if (arrayTypeSum != "ORIGINAL" && arrayTypeSum != "COPY") { // if wrong user input, display error

                        textBox2.Text = $"[1] Please type either [ORIGINAL or COPY] to Count the Sum of all elements in the array";
                        clearTextBox();
                        return;

                    }


                    if (arrayTypeSum == "ORIGINAL" && newArray == null) { // if array does not exist, display error

                        textBox2.Text = $"[2] Please create a new array, or select another operation";
                        clearTextBox();
                        return;

                    }


                    if (arrayTypeSum == "COPY" && newArrayCopy == null) { // if array copy does not exist, display error

                        textBox2.Text = $"[3] Please create a new array copy, or select another operation ";
                        clearTextBox();
                        return;
                    }


                    if (arrayTypeSum == "ORIGINAL") {

                        textBox2.Text = $"The Sum Total for ORIGINAL array is : {newArray.ReturnSum().ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                    if (arrayTypeSum == "COPY") {

                        textBox2.Text = $"The Index Count for COPY array is : {newArrayCopy.ReturnSum().ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                } catch (Exception ex) {

                    textBox2.Text = $"{ex.Message}";
                }

                break;


                /// Display the Average value of the elements in the array
                case 9:

                    string arrayTypeAverage = textBox1.Text.Trim();

                try {

                    if (arrayTypeAverage != "ORIGINAL" && arrayTypeAverage != "COPY") { // if wrong user input, display error

                        textBox2.Text = $"[1] Please type either [ORIGINAL or COPY] to see the Average of all elements in the array";
                        clearTextBox();
                        return;

                    }


                    if (arrayTypeAverage == "ORIGINAL" && newArray == null) { // if array does not exist, display error

                        textBox2.Text = $"[2] Please create a new array, or select another operation";
                        clearTextBox();
                        return;

                    }


                    if (arrayTypeAverage == "COPY" && newArrayCopy == null) { // if array copy does not exist, display error

                        textBox2.Text = $"[3] Please create a new array copy, or select another operation ";
                        clearTextBox();
                        return;
                    }


                    if (arrayTypeAverage == "ORIGINAL") {

                        textBox2.Text = $"The Average for ORIGINAL array is : {newArray.ReturnAverage().ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                    if (arrayTypeAverage == "COPY") {

                        textBox2.Text = $"The Average for COPY array is : {newArrayCopy.ReturnAverage().ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                } catch (Exception ex) {

                    textBox2.Text = $"{ex.Message}";
                }

                break;


                // Multiplies each element in the array by the given scalar value
                case 10:
                
                int z = 0;
                bool isValidZ = false;
                string[] scalarArrayValue = textBox1.Text.Split(' '); // sepperates array values with a space

                try {

                    if (scalarArrayValue.Length != 2) { // Take in exactly 2 arguments, if not error. We want the Array name and the Scalar string value 

                        textBox2.Text = $"[1] Please type either [ORIGINAL or COPY] then [Postive Scalar Numeric Value] then press ENTER..";
                        clearTextBox();
                        return; // exit early

                    }


                    if (scalarArrayValue[0] != "ORIGINAL" && scalarArrayValue[0] != "COPY") {

                        textBox2.Text = $"[2] Please type either [ORIGINAL or COPY] then [Postive Scalar Numeric Value] then press ENTER..";
                        clearTextBox();
                        return;

                    }


                    isValidZ = int.TryParse(scalarArrayValue[1], out z); // try parse the string value in the array, output to variable z, if not isValid is false
                    if (!isValidZ) {    // if false, display error

                        textBox2.Text = $"[3] Please type either [ORIGINAL or COPY] then [Postive Scalar Numeric Value] then press ENTER..";
                        clearTextBox();
                        return;

                    }


                    if (z <= 0) { // if z is less or equal to zero, display error. We don't want to multiply by zero.

                        textBox2.Text = $"[4] Please type either [ORIGINAL or COPY] then [Postive Scalar Numeric Value] then press ENTER.. ";
                        clearTextBox();
                        return;
                    }


                    if (scalarArrayValue[0] == "ORIGINAL" && newArray != null) {

                        newArray.ScalarMultiply(z); 
                        textBox2.Text = $"Each Original Array Index has been Multiplied by : {z}  ";
                        buttonNumber = 0;
                        clearTextBox();

                    }else if (scalarArrayValue[0] == "COPY" && newArrayCopy != null){

                        newArrayCopy.ScalarMultiply(z);
                        textBox2.Text = $"Each Copy Array Index has been Multiplied by : {z}  ";
                        buttonNumber = 0;
                        clearTextBox();

                    } else {

                        textBox2.Text = $"[5] That Array does not exist. Please create that Array type then try again.";
                        clearTextBox();
                        return;
                    }


                } catch (Exception ex) {

                    textBox2.Text = $"{ex.Message}";
                }

                break;


                // Add Constant to array indice values, ie 3.14159 Pi
                case 11:

                string arrayTypeConstant = textBox1.Text.Trim(); // removes whitespace at end of input

                try {

                    // if string is not ORIGINAL and not COPY, display error
                    if (arrayTypeConstant != "ORIGINAL" && arrayTypeConstant != "COPY") {

                        textBox2.Text = $"[1] To Add a Constant to all elements in the array, type either [ORIGINAL or COPY] then press ENTER..\"";
                        clearTextBox() ;
                        return; // exit early

                    }

                    // if string is ORIGINAL or COPY and newArray is null and newArrayCopy is null, display error
                    if (arrayTypeConstant == "ORIGINAL" && newArray == null || arrayTypeConstant == "COPY" && newArrayCopy == null) {

                        textBox2.Text = $"[2] That Array does not exist. Please create that Array type then try again ";
                        clearTextBox();
                        return;
                    }


                    // if string is ORIGINAL and newArray is not null, do this
                    if (arrayTypeConstant == "ORIGINAL" && newArray != null) {

                        newArray.ReturnAddConstant();
                        textBox2.Text = $"Each Index in the ORIGINAL array has been added with a Constant value";
                        clearTextBox();

                    }


                    // if string is COPY and newArrayCopy is not null, do this
                    if (arrayTypeConstant == "COPY" && newArrayCopy != null) {

                        newArrayCopy.ReturnAddConstant();
                        textBox2.Text = $"Each Index in the COPY array has been added with a Constant value";
                        clearTextBox();

                    }

                } catch (Exception ex) {

                    textBox2.Text = $"{ex.Message}";
                }

                break;


                // Displays the string formatted representation of the array 
                case 12:

                string arrayTypeToString = textBox1.Text.Trim(); // This 'removes' spaces at the end of textBox1

                try {

                    if (arrayTypeToString != "ORIGINAL" && arrayTypeToString != "COPY") { // if wrong user input, display error

                        textBox2.Text = $"[1] Please type either [ORIGINAL or COPY] to see the string formatted representation of the array";
                        clearTextBox();
                        return; // exit early

                    }


                    if (arrayTypeToString == "ORIGINAL" && newArray == null) { // if array does not exist, display error

                        textBox2.Text = $"[2] Please create a new array, or select another operation";
                        clearTextBox();
                        return;

                    }


                    if (arrayTypeToString == "COPY" && newArrayCopy == null) { // if array copy does not exist, display error

                        textBox2.Text = $"[3] Please create a new array copy, or select another operation ";
                        clearTextBox();
                        return;
                    }


                    if (arrayTypeToString == "ORIGINAL") {

                        textBox2.Text = $"The string formatted representation of ORIGINAL array is : {newArray.ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                    if (arrayTypeToString == "COPY") {

                        textBox2.Text = $"The string formatted representation of COPY array is : {newArrayCopy.ToString()}";
                        clearTextBox();
                        buttonNumber = 0;

                    }


                } catch (Exception ex) {

                    textBox2.Text = $"{ex.Message}";
                }

                break;

                default:
                break;

                    
            
            } // EO switch
        } // EO Enter_Click


        /// Add a ReadMe Doc.. week 3 notes
























    }   // EO Form1 class


    /// <summary>
    /// Represents a fixed size collection that can change its stored numbers and perform mathematic operations  
    /// </summary>
    public class ArrayOfNumbers
    {
        private int[] _array;    // Private field integer Array 

        /// <summary>
        /// Property to get and set the array object
        /// </summary>
        public int[] Array 
        {
            get { return _array; }
            set { _array = value; }
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
                _array[i] = 10;
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
        /// A Method to Return true or false if the integer arguments are equal. 
        /// </summary>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        /// <returns></returns>
        public bool ReturnIsEqual(int firstIndex, int secondIndex)
        {
            int a = 0;
            int b = 0;
            bool isEqual;

            for (int i = 0; i < _array.Length; i++) {
                a = _array[firstIndex];
                b = _array[secondIndex];
            }

            if (a == b) {
                isEqual = true;
            } else {
                isEqual = false;
            }

            return isEqual;

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
            string value = "";

            for (int i = 0; i < _array.Length; i++) {
                value += _array[i].ToString();  
                
                if (i < _array.Length -1) { // Add a comma to the value variable (inbetween the array index values) if not the last index
                    value += ", ";
                }

            }

            return value;

        }


        /// <summary>
        /// A Method to multiply each array index value by a scalar value
        /// </summary>
        /// <param name="scalarValue">The number to multiply by</param>
        public void ScalarMultiply(int scalarValue)
        {
            // v = k x v
            //int value = 0;
            //array = _array;

            for(int i = 0; i < _array.Length; i++) {   // Loop through and multiply each index value by the scalar value 
                _array[i] *= scalarValue;
                //value = _array[i];

            }

             //value; // maybe remove return and make Method void. Use ToString Method to return index values

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
