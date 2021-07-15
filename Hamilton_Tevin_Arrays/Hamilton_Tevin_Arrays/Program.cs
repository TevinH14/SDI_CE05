using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*
             Tevin Hamilton
             03/05/2018
             Arrays Assignment
             */

            //Create your own project and call it Lastname_Firstname_Arrays
            //Copy this code inside of this Main section into your Main Section
            //Work through each of the sections

            /* 
              -Use the 2 arrays below
              -Do Not Re-Declare or Re-Define the elements inside of it.
              -Find the total sum of each individual array  
              -Store each sum in a variable and output that variable to console
              
              -Find the average value of each individual array
              -Store each average in a variable and output that variable to console
            */


            //This is the Declare and Definition of the 2 Starting Number Arrays
            int[] firstArray = new int[4] { 7, 24, 30, 12 };
            double[] secondArray = new double[4] { 9, 20.5, 35.9, 237.24 };


            // complete totel for the first arry 
            double firstArraysum1 = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];
            //console ouput1
            Console.WriteLine("the complete totel of the first array is " + firstArraysum1);
            // mean for arry 1 

            double firstArrymean = firstArraysum1 / 4;
            // console mean output
            Console.WriteLine("The mean to the first array is " + firstArrymean);

            double secondArraySum2 = secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3];
            // console output 2
            Console.WriteLine("the complete totel of the second array is " + secondArraySum2);

            //2nd array mean 
            double secondArrayMean = secondArraySum2 / 4;
            // mean output
            Console.WriteLine("The mean to the second array is " + secondArrayMean);
            /*
             
               Create a 3rd number array.  
               The values of this array will come from the 2 given arrays.
                -You will take the first item in each of the 2 number arrays, add them together and then store this sum inside of the new array.
                -For example Add the index#0 of array 1 to index#0 of array2 and store this inside of your new array at the index#0 spot.
                    -This would make the first element of this array = 16
                -Repeat this for each index #.
                -Do not add them by hand, the computer must add them.
                -Do not use the numbers themselves, use the array elements.
                -After you have the completed new array, output this to the Console.
             */

            //Your code for the 3d Array goes here

            double[] thirdArray = new double[4];

            //Fill the array
            thirdArray[0] = firstArray[0] + secondArray[0];
            thirdArray[1] = firstArray[1] + secondArray[1];
            thirdArray[2] = firstArray[2] + secondArray[2];
            thirdArray[3] = firstArray[3] + secondArray[3];
            //Output to the console
            Console.WriteLine("Thhe third array is complete! Here are the 4 numbers of the tired array ");
            Console.WriteLine(+thirdArray[0]);
            Console.WriteLine(+thirdArray[1]);
            Console.WriteLine(+thirdArray[2]);
            Console.WriteLine(+thirdArray[3]);
           


            /*
               Given the array of strings below named MixedUp.  
               You must create a string variable that puts the items in the correct order to make a complete sentence 
               that is a famous phrase by Bill Gates.
                -Use each element in the array, do not re-write the strings themselves.
                - Do Not Re-Declare or Re-Define the elements inside of it.
                -Concatenate them in the correct order to form a sentence.
                -Store this new sentence string inside of a string variable you create.
                -Output this new string variable to the console.
             */

            //Declare and Define The String Array
            string[] MixedUp = new string[] { " is like measuring ", "Measuring programming progress", "aircraft building progress ", " by lines of code", "by weight." };
            string orderQoutes = MixedUp[1] + MixedUp[3] + MixedUp[0] + MixedUp[2] + MixedUp[4];
            Console.WriteLine(orderQoutes);

            /* caculations 
             * 7 + 24 + 30 + 12 =73 (Frist Array totel)
             * 9 + 20.5+ 35.9 + 237.24 =302.64 (second Array totel)
             * 73/4= 18.25
             * 302.64/4=75.66
             * 7+9=16
             * 24+20.5=44.5
             * 30+25.9=55.9
             * 12+237.24=249.24
             * */
        }
    }
}
