using System;

namespace Assessment3
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("------------------Question 1--------------\nWrite a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. ");
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m : ");
        int m = int.Parse(Console.ReadLine());
        for(int i = n; i <= m; i++)
        {
            if(i % 5 == 0)
            {
          Console.WriteLine($"The numbers that are divisible by 5 without a remainder is : {i}");
            }
        }

        Console.WriteLine("---------Question 2---------\n2.	Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 2.	Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 2.	Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 2.	Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … ");
        int n1 = 0;
        int n2 = 1;
        int n3;
        int i;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for(i = 2; i <= 100; i++)
        {
            n3 = n1 + n2;
            Console.WriteLine(n3);
            n1 = n2;
            n2 = n3;
        }

        Console.WriteLine(" Question 3 \nWrite a program that finds the greatest of given 5 numbers.");
        Console.WriteLine("Number 1 : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 2 : ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 3 : ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 4 :");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 5 : ");
        int fifthNumber = int.Parse(Console.ReadLine());
        if ((firstNo >= secondNo) && (firstNo >= thirdNo) && (firstNo >= fourthNo) && (firstNo >= fifthNo))
        {
            Console.WriteLine($"The biggest number is: {firstNo}");
            
        }
        if ((secondNo >= firstNo) && (secondNo >= thirdNo) && (secondNo >= fourthNo) && (secondNo >= fifthNo))
        {
            Console.WriteLine($"The biggest number is: {secondNo}");
            
        }
        if ((thirdNo >= firstNo) && (thirdNo >= secondNo) && (thirdNo >= fourthNo) && (thirdNo >= fifthNo))
        {
            Console.WriteLine("The biggest number is: {0}", thirdNo);
            
        }
        if ((fourthNo >= firstNo) && (fourthNo >= secondNo) && (fourthNo >= thirdNo) && (fourthNo >= fifthNo))
        {
            Console.WriteLine("The biggest number is: {0}", fourthNo);
            
        }
        if ((fifthNo >= firstNo) && (fifthNo >= secondNo) && (fifthNo >= thirdNo) && (fifthNo >= fourthNo))
        {
            Console.WriteLine("The biggest number is: {0}", fifthNo);
            
        }

            Console.WriteLine(" Question 4 \nWrite a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist)");
            Console.Write("Input the value of a : ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Input the value of b : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input the value of c : ");
            int c = int.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            double firstRoot;
            double secondRoot;
            if(discriminant==0)
            {
               Console.Write("Both roots are equal");
                firstRoot = -b / (2.0 * a);
                secondRoot = firstRoot;
               Console.Write("First  Root = {0}", firstRoot);
               Console.Write("Second Root = {0}", secondRoot);
            }
            else if(discriminant > 0)
	        {
	           Console.Write("Both roots are real and different");
               firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
	           secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
               Console.WriteLine("First  Root = {0}", firstRoot);
	           Console.WriteLine("Second Root = {0}", secondRoot);
	        }
	        else
            {
	          Console.Write("Roots are imaginary");
            }

        Console.WriteLine("---------------Question 5------- \nWrite a program that applies bonus points to given scores in the range [1…9] by the following rules: "); 

        Console.WriteLine("Enter score : ");
        int score = int.Parse(Console.ReadLine());
           if(score != 0)
           {
            Console.WriteLine(score);
           }
           else
           {
               Console.WriteLine("Error!");
           }
           if(score <= 3)
            {
                Console.WriteLine($"Final score is : {score * 10}");
            }
            else if(score <= 6)
            {
                Console.WriteLine($"Final score is : {score * 100}");
            }
            else if(score <= 9)
            {
                Console.WriteLine($"Final score is : {score * 1000}");
            }
           else
            {
                Console.WriteLine("Error!");
            }

        Console.WriteLine("-------Question 6-----\nWrite a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.");
        Console.WriteLine("n : ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            if(i % 3 != 0 && i % 7 != 0 )
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine($" Question 7 \nWrite a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards). ");
           for (int suits = 0; suits < 4; suits++)
            {
                if(suits != 0)
                { 
                Console.WriteLine();
                }
                for (int cards = 0; cards < 13; cards++)
                {
                    switch (suits)
                    {
                        case 0: 
                        Console.Write("Hearts "); 
                        break;
                        case 1:
                         Console.Write("Diamonds ");
                        break;
                        case 2: 
                        Console.Write("Spades "); 
                        break;
                        case 3: 
                        Console.Write("Clubs ");
                        break;
                    }
                    switch(cards)
                    {
                        case 0: 
                        Console.WriteLine("2"); 
                        break;
                        case 1: 
                        Console.WriteLine("3"); 
                        break;
                        case 2: 
                        Console.WriteLine("4"); 
                        break;
                        case 3: 
                        Console.WriteLine("5");
                        break;
                        case 4:
                        Console.WriteLine("6"); 
                        break;
                        case 5: 
                        Console.WriteLine("7"); 
                        break;
                        case 6: 
                        Console.WriteLine("8"); 
                        break;
                        case 7: 
                        Console.WriteLine("9"); 
                        break;
                        case 8: 
                        Console.WriteLine("10"); 
                        break;
                        case 9: 
                        Console.WriteLine("J"); 
                        break;
                        case 10: 
                        Console.WriteLine("Q"); 
                        break;
                        case 11: 
                        Console.WriteLine("K"); 
                        break;
                        case 12: 
                        Console.WriteLine("A"); 
                        break;
                    }
                }
            }
            Console.WriteLine(" Question 8 \nWrite a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence");
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($" {firstNo}, {secondNo}");

            for(int i = 2; i < n; i++)
            {
                
                 int thirdNo = firstNo + secondNo;
                Console.Write(" {0},", thirdNo);
                firstNo = secondNo;
                secondNo = thirdNo;
                sum += i;
           }	
           Console.WriteLine($"The sum is : {sum}");

            Console.WriteLine(" Questionn 9 \nWrite a program that for a given number n, outputs a matrix in the form of a spiral.");
            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());            
            int[,] matrix = new int[n, n];
            int row = 0, col = 0, direction = 0;

            for (int i = 1; i <= n * n; i++)
            {
                switch(direction)
                {
                    case 0:
                            if (col > n - 1 || matrix[row, col] != 0)
                            {
                                direction = 1;
                                col--;
                                row++;
                            }
                            break;
                    case 1:
                            if (row > n - 1 || matrix[row, col] != 0)
                            {
                                direction = 2;
                                row--;
                                col--;
                            }
                            break;
                    case 2:
                            if (col < 0 || matrix[row, col] != 0)
                            {
                                direction = 3;
                                col++;
                                row--;
                            }
                            break;
                    case 3:
                            if (row < 0 || matrix[row, col] != 0)
                            {
                                direction = 0;
                                row++;
                                col++;
                            }
                            break;
                }

                matrix[row, col] = i;                

                switch(direction)
                {
                    case 0:
                             col++;
                    break;
                    case 1:
                            row++; 
                    break;
                    case 2: 
                            col--; 
                    break;
                    case 3: 
                            row--; 
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 10) Console.Write("{0}  ", matrix[i, j]);
                    else Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

          Console.WriteLine(" Question 10 \nWrite a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console");
          int [] integers = new int [20];
          for(int i = 0; i < 20; i++)
             {
                 integers[i] = i * 5;
                 Console.WriteLine(integers[i]);
             }

            Console.WriteLine("Question 11 \nWrite a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal)");
              bool arraysEqual = true;

            Console.Write("Enter length of first array : ");
            int lengthOfFirstArray = int.Parse(Console.ReadLine());

            int[] firstArray = new int[lengthOfFirstArray];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter length of second array : ");

            if (lengthOfFirstArray != int.Parse(Console.ReadLine()))
            { 
            Console.WriteLine("Arrays have different lengths.");
            }
            else
            {
                int[] secondArray = new int[lengthOfFirstArray];

                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("Arrays are different");
                        arraysEqual = false;
                        break;
                    }
                }
                if (arraysEqual) 
                 {
                   Console.WriteLine("Arrays are the same");
                 }
            }

             Console.WriteLine(" Question 13 \nWrite a program, which finds the most frequently occurring element in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} 4 (5 times)");
             int counter = 0, tempCounter = 1, foundNumber = 0;

             Console.Write("Enter array length: ");
             int arrayLength = int.Parse(Console.ReadLine());

             int[] arrayL = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arrayL[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrayL);

            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (arrayL[i] == arrayL[i + 1]) 
                {
                tempCounter++;
                }
                else 
                {
                tempCounter = 1;
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = arrayL[i];
                }
            }
              Console.WriteLine("{0} was found {1} times.", foundNumber, counter);

              //No Number 12

            Console.WriteLine("Question 14 \n");
            Console.WriteLine("Enter A Binary Number");
            string binaryNumber = Convert.ToString(Console.ReadLine());
            int decimalValue = Convert.ToInt32(binaryNumber, 2);
            Console.WriteLine($"It's Decimal Number is equivalent to : {decimalValue}");
 
 
            Console.WriteLine("Question 15 \n");
            Console.WriteLine("Enter A Decimal Number");
            string decimalNumber = Convert.ToString(Console.ReadLine());
            int binaryValue = Convert.ToInt32(decimalNumber, 10);
            string convertBinary = Convert.ToString(binaryValue, 2);
            Console.WriteLine($"It's equivalent Binary Value is : {convertBinary}");
  
            Console.WriteLine(" Question  16 \n");
            int i;
            Console.Write("Enter A Decimal Number : ");
            int decimalNo = int.Parse(Console.ReadLine());
            char [] hexadecimalNumber = new char[100];
            for(i = 0; i < decimalNo; i++)
            {
                int remainder = decimalNo % 16;
                
                if(decimalNo < 10)
                {
                    hexadecimalNumber[i] = (char)(remainder + 48);
                }
                else
                {
                    hexadecimalNumber[i] = (char)(remainder + 55);
                }
                decimalNo /= 16;
            }
            Console.Write("It's equivalent hexadecimal number is : ");
            for(int k = hexadecimalNumber.Length - 1; k >= 0; k--)
            {
                Console.Write(hexadecimalNumber[k]);
            }

           Console.WriteLine(" Questions 17  \nWrite a program that converts a hexadecimal number to decimal one. ");
           Console.WriteLine("Enter a Hexadecimal Number");
           string hexdecNo = Convert.ToString(Console.ReadLine());
           int deciValue = Convert.ToInt32(hexdecNo, 16);
           Console.Write($"It's equivalent DecimalValue is : {deciValue}");

           Console.WriteLine("Question 18 \nWrite a program that converts a hexadecimal number to binary one. ");
           Console.WriteLine("Enter a Hexadecimal Number");
           string hdNo = Convert.ToString(Console.ReadLine());
           int dValue = Convert.ToInt32(hdNo, 16);
           Console.WriteLine($"It's equivalent DecimalValue is : {dValue}");
           string convertedBinary = Convert.ToString(dValue, 2);
           Console.WriteLine($"It's equivalent Binary Value is : {convertedBinary}");*/

           Console.WriteLine("Question 19 \nWrite a program that converts a binary number to hexadecimal one");
           Console.Write("Enter a Binary Number : ");
           string bNo = Convert.ToString(Console.ReadLine());
           int deciVal = Convert.ToInt32(bNo, 2);
           Console.WriteLine($"It's equivalent Decimal Value is : {deciVal}");
           string hexVal = Convert.ToString(deciVal, 16);
           Console.WriteLine($"It's equivalent hexadecimal Value is : {hexVal}");



        }
    }
}
