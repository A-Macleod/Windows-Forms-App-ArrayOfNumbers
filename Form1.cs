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
        private ArrayOfNumbers newArrayOfNumbers;   // Declare a refference to ArrayOfNumbers to be used by Form1 Class Methods

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    /// Add a ReadMe Doc.. week 3 notes

    }   // EO Form1 class






    private class ArrayOfNumbers
    {
        private int[] _arrayOfNumbers;    // Private field integer Array 

        // Constructor #1 
        // Accepts integer param that specifies the size of the Array.
        // Initialise all elements to zero.
        public ArrayOfNumbers(int A)
        {

            _arrayOfNumbers = new int[A];

            int X = 0;
            for (int i = 0; i < A; i++) {
                _arrayOfNumbers[i] = X;
            }

        }

        // Constructor #2 
        // Accepts array of integers as input and creates a copy of it for internal storage.
        // Create a new array and copy each element.
        // (Research difference, reference types - primitive (value) types first)


        // Property  Get/Set
        // Method to return element from array at specificed Index
        // Method to set an element at specificed index to the given value

        //public int[] ArrayOfInts()
        //{
        //    get
        //        {
        //        // Get logic in here
        //    }

        //    set
        //        {
        //        // Set logic in here
        //    }
        //}


    }   //  EO ArrayOfNumbers class



    /// <summary>
    /// Example Text Here
    /// </summary>
    /// <param name="PARAMNAME"> Description of param: Description of validation:</param>












}   // EO namespace
