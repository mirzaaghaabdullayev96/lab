using System.ComponentModel.DataAnnotations;
using System.Net.Security;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Result(4, 5, 61, 1, 3, 4, 5, 6, 12, 35, 4, 52, 62, 41, 3)); //task 1
            //Console.WriteLine(ReverseString("Hello")); //task 2
            //GetName(); //task3
            //Console.WriteLine(Calculate(5)); //task4
            //Console.WriteLine(Calculate(5,10)); //task4
            //Console.WriteLine(Sum(12523)); //task5
            //Console.WriteLine(IsPalindrome("atta")); //task 6
            //int[] array = {1,2,3};
            //var arr = ArrayDouble(array);
            //foreach (int i in arr)
            //{
            //    Console.Write(i);
            //}  //task 7

            //var student1 = new { Name = "Arif", Id = 213, Age = 10, Grade = 70, Class = 5 };
            //var student2 = new { Name = "Ali", Id = 223, Age = 11, Grade = 86, Class = 6 };
            //var student3 = new { Name = "Hesen", Id = 243, Age = 13, Grade = 78, Class = 7 };
            //var student4 = new { Name = "Ceyhun", Id = 216, Age = 14, Grade = 96, Class = 8 };
            //var student5 = new { Name = "Akif", Id = 266, Age = 15, Grade = 94, Class = 9 };
            //var student6 = new { Name = "Arif", Id = 253, Age = 16, Grade = 83, Class = 10 };
            //var student7 = new { Name = "Arif", Id = 273, Age = 17, Grade = 95, Class = 11 };
            //var student8 = new { Name = "Terlan", Id = 257, Age = 12, Grade = 60, Class = 6 };
            //var students = new[] { student1, student2, student3, student4, student5, student6, student7, student8 };

            ////AddingForArif(students);
            ////TheHighestScore(students);
            ////GetGradeOfSeven(students);
            ////GetStudentsLess5Classs(students); task 8
            //int[] hours = [ 5, 4, 6, 1, 2, 3, 5 ];
            //int target = 5;

            //GetResult(hours, target); task 9

            int[] arr = { 1, 3, 5, 8 };

            bool alreadyExists = false;

            int counterNew = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;

                for (int k = 0; k < i; k++)
                {
                    if (arr[k] == arr[i])
                    {
                        alreadyExists = true;
                        break;
                    }
                }


                if (alreadyExists)
                {
                    alreadyExists = false;
                    continue;
                }


                for (int j = i; j < arr.Length - 1; j++)
                {

                    if (arr[i] == arr[j + 1])
                    {
                        counter++;
                    }
                }

                counterNew += counter;
            }

            int[] newArray = new int[arr.Length - counterNew];
            //Console.WriteLine(newArray.Length);


            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    if (arr[k] == arr[i])
                    {
                        alreadyExists = true;
                        break;
                    }
                }


                if (alreadyExists)
                {
                    alreadyExists = false;
                    continue;
                }

                newArray[j] = arr[i];
                j++;

            }

            foreach(int i in newArray)
            {
                Console.Write(i);
            }



        }

        #region task 1
        //static int Result(params int[] x)
        //{
        //    int sumOfEven = 0;
        //    int sumOfOdd = 0;
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        if (x[i] % 2 == 0)
        //            sumOfEven += x[i];
        //        else
        //            sumOfOdd += x[i];
        //    }
        //    return sumOfEven - sumOfOdd;
        //}
        #endregion

        #region task 2

        //static string ReverseString(string myWord)
        //{
        //    string reversed="";
        //    for (int i = myWord.Length - 1; i >= 0; i--)
        //    {
        //        reversed += myWord[i];
        //    }
        //    return reversed;
        //}


        #endregion

        #region task 3

        //static void GetName()
        //{

        //    while (true)
        //    {
        //        Console.WriteLine("Enter your name");
        //        string name = Console.ReadLine();
        //        if (name.Length >= 8)
        //        {
        //            Console.WriteLine(name);
        //            break;
        //        }
        //    }
        //}


        #endregion


        #region task 4

        //static double Calculate(int radius)
        //{
        //    return Math.PI * radius * radius;
        //}



        //static int Calculate(int a, int b)
        //{
        //    return a * b;
        //}

        #endregion

        #region task 5


        //static int Sum(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}


        #endregion

        #region task 6 

        //static bool IsPalindrome(string myWord)
        //{
        //    for (int i = 0; i<=myWord.Length/2; i++)
        //    {
        //        if (myWord[i] != myWord[myWord.Length-1-i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;

        //}

        #endregion

        #region task 7 

        // 123 array 123123
        static int[] ArrayDouble(int[] array)
        {
            int[] newarray = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i];
                newarray[i + array.Length] = array[i];
            }

            return newarray;
        }

        #endregion

        #region task 8


        //static void AddingForArif(dynamic[] students)
        //{
        //    foreach (var item in students)
        //    {
        //        if (item.Name == "Arif")
        //        {
        //            item.Grade += 15;
        //        }

        //        if (item.Grade > 100)
        //            Console.WriteLine($"{item.Name} - new grade is 100 ");
        //        else Console.WriteLine($"{item.Name} - new grade is {item.Grade}");
        //    }
        //}

        //static void GetGradeOfSeven(dynamic[] students)
        //{
        //    double sum = 0;
        //    int counter = 0;
        //    foreach (var item in students)
        //    {
        //        if (item.Class == 7)
        //        {
        //            counter++;
        //            sum += item.Grade;
        //        }
        //    }
        //    Console.WriteLine(sum / counter);
        //}

        //static void GetStudentsLess5Classs(dynamic[] students)
        //{
        //    foreach (var item in students)
        //    {
        //        if (item.Grade > 60 && item.Class < 5)
        //        {
        //            Console.WriteLine(item.Name);
        //        }
        //    }
        //}


        //static void TheHighestScore(dynamic[] students)
        //{
        //    int max = students[0].Grade;
        //    int index = 0;
        //    for (int i = 1; i < students.Length; i++)
        //    {
        //        if (students[i].Grade > max)
        //        {
        //            max = students[i].Grade;
        //            index = i;

        //        }

        //    }
        //    Console.WriteLine($"{ students[index].Name} has highest score which is {students[index].Grade}");
        //}




        #endregion

        #region task 9

        //static void GetResult(int[] array, int target)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] >= target)
        //            counter++;
        //    }
        //    Console.WriteLine(counter);
        //}


        #endregion

        #region task 10


        #endregion

    }
}
