using System.Drawing.Design;

namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        
        }


        ///<summary>
        ///Displays the string that is sent to the method.
        ///Requires descriptive text and result both in one string. 
        ///Third parameter is to clear the label before writing to it.
        /// </summary>
        /// <param name="descText"></param>
        /// <param name="result"></param>
        private void DisplayResults(string descText, bool clearLabel)
        {
            if (clearLabel)
            {
                lblResults.Text = "";
            }
            //Display the results in the label
            lblResults.Text += string.Format("{0}\n", descText);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button click event handler to execute the methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecuteMethods(object sender, EventArgs e)
        {
            //This will be considered our Main Method and our goal is to keep
            //this method clean (nologic jsut calling methods)
            //Declare and Initialize 
            int num1 = 2, num2 = 3, num3 = 4;
            int randomSum = 0;
            double double1 = 1.1D, double2 = 2.2D, double3 = 3.3D;
            double double4 = 4.4D, double5 = 5.5D;
            string firstString = "This is text number 82.";
            string secondString = "The sky is blue today";
            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };
            int int9 = 6;
            double double9 = 5.24D;
            
            
            //First Method Example
            SumInts(num1, num2);

            //Second Method
            DisplayResults("Method 2: Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), false);

            //Third method( break this out to multiple lines so it is easier to understand)
            randomSum = RandomInt();
            DisplayResults(string.Format("Method 3: Sum of random ints = {0}", randomSum.ToString()), false);

            //fourth method
            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo, false);

            //fifth method
            FewestChars(firstString, secondString);

            //Sixth method
            double maxDouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest Double: {0}", maxDouble.ToString()), false);

            //seventh method
            int[] ints = IntegerArray();
            DisplayResults("Method 7: A random array of ten numbers: " + string.Join(", ", ints), false);

            //Eight method
            AreBoolEqual();


            //Nineth Method
            double product = ProductReturn(int9, double9);
            DisplayResults("Method 9: The product of an integer and double: " + product, false);
        }

        ///<summary>
        ///Write a method that takes two integers and displays their sum with descriptive text.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void SumInts(int num1, int num2)
        {
            //Find the sun
            int sum = num1 + num2;
            //Display needs to be it's own method
            DisplayResults("Method 1: The sum of " + num1 + " + " + num2 + " = " + sum, true);
        }

        ///<summary>
        ///Find the average of the 5 doubles and then return the average
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        /// <return></return>
        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            //Find the average of 5 doubles
            //Declare and initialize 
            const double AvgDenominator = 5.0D;
            //Find and return the average of the 5 doubles
            return ((num1 + num2 + num3 + num4 + num5) / AvgDenominator);
        }

        ///<summary>
        ///Returns a randomly denterated int
        /// </summary>
        /// <returns></returns>
        private int RandomInt()
        {
            //Declare and initialize
            int num1 = 0, num2 = 0, sum = 0;
            //Get the random numbers
            //C# provides a Random class to generate random numbers
            //Instantiate random number generator create an object called rand
            //Syntax --> ClassName object/variable name = new ClassName()
            Random rand = new Random();
            //Within the Random class there are several methods that have access modifier set to OPublic that we can use
            //One of these methods is Next(int min, int max) that returns random number >= 1 and < 101
            num1 = rand.Next(1, 101);
            num2 = rand.Next(1, 101);
            //Generate the sum and return it.
            //Break this out to multiple lines so it is easier to understand
            sum = num1 + num2;
            return sum;
        }
        

       

        ///<summary>
        /// Return bool true or false if the sum of the ints are divisible by 2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        private bool DivByTwo(int num1, int num2, int num3)
        {
            //Find the sum
            int sum = num1 + num2 + num3;
            //Is the sum divisible by 2
            if(sum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ///<summary>
        ///Write a method that atkes two strings and displays the string that ahs the fewer letters with descriptive text
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private void FewestChars(string string1, string string2)
        {
            //Declare and initialize
            int countChar1 = 0, countChar2 = 0, pointer = 0;
            //Iterate through the strings using a do while loop
            //Exit loop when both strings have vbeen fully iterated through
            do
            {
                //string1 --> try and test if the char being pointed to is a letter
                try
                {
                    if (char.IsLetter(string1[pointer]))
                    {
                        //Now we know this index contains a letter and not number
                        countChar1++;
                    }
                }
                catch(Exception e)
                {
                    //If we are here then we know string1 is at the end of the length and we do want to do anything
                }
                //Inc the pointer to point to next char
                pointer++;
            }
            while ((pointer < string1.Length) || (pointer < string2.Length));
            //Now we have the count of chars for each sting
            if(countChar1 < countChar2)
            {
                DisplayResults("Method 5: string 1 has fewer letters", false);
            }
            else if(countChar2 < countChar1)
            {
                DisplayResults("Method 5: string 2 has fewer letters", false);
            }
            else
            {
                DisplayResults("Method 5: Both strings have the same number of letters", false);
            }    
        }
        ///<summary>
        ///Write a method that takes an array of doubles and returns the largest value in the array.
        /// </summary>
        /// <param name="arrDoubles"></param>"
        /// <returns></returns>
        private double LargestDouble(double[] arrDoubles)
        {
            //Declare and initialize
            int arrPointer = 0;
            double valueAtIndex = 0D;
            double biggestDouble = 0D;
            //Iterate through array using while loop
            while(arrPointer < arrDoubles.Length)
            {
                //Read double from array at the index of pointer
                valueAtIndex = arrDoubles[arrPointer];

                //Now test the double against biggestDouble
                //If the value we just read is larger than value
                //in biggestDouble - replace with valueAtIndex
                if(valueAtIndex > biggestDouble)
                {
                    //We just found a larger double
                    biggestDouble = valueAtIndex;
                }
                //Inc the pointer so it points to the next index.
                arrPointer++;
                //show how arrDoubles[arrPointer++] would do same
            }

            //All done so return the biggest double
            return biggestDouble;
        }

        ///<summary>
        ///Write a method that generates and returns an array of ten integer values. 
        ///Display the value of the array with descriptive text.
        ///Display the result with descriptive text.
        /// </summary>
        private static int[] IntegerArray()
        {
            //create the array and set the length to 10
            int[] array = new int[10];
            //Use random to create a random number to put into the array
            Random random = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                //Generates the random number between 1 and 101 and assigns it to spot i in the array
                array[i] = random.Next(1, 101);
            }
            //We need to return the random integer array
            return array;
        }




        ///<summary>
        ///Write a method that takes two bool variables and returns true if they have the same value, false otherwise. 
        ///Display the reults with descriptive text
        /// </summary>
        private void AreBoolEqual()
        {
            //Creating the syntax to set the random generator for bool1 abnd bool2
            Random random = new Random();
            //the bool statement checks to see if random.Next(2) is 0
            //It can only be 0 or 1
            //If it is 0, it will be true
            bool bool1 = random.Next(2) == 0;
            bool bool2 = random.Next(2) == 0;

            //Check the two bool statements against each other to see if they are equal or not 
            //set it to a new bool
            bool boolResults = bool1 == bool2;

            //Use an if statement to check if boolResults is true or false
            //set the statements to return for both true and false cases
            if (boolResults == false)
            {
                DisplayResults("Method 8: The two random booleans are not equal", false);
            }
            else
            {
                DisplayResults("Method 8: The two random booleans are equal", false);
            }

        }
        

        ///<summary>
        /// Write a method that takes an int and a double and returns their product. 
        /// Display the product with descriptive text
        /// </summary>
        private static double ProductReturn(int int9, double double9)
        {
            //Create a double that will have the value of the prodcut of the int and double
            double product = int9 * double9;
            
            //Return the product of the double and int
            return product;
        }

    
    }
}
