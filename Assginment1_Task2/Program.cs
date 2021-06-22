using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            String path1 = @"";
            String path2 = @"";
            String path3 = @"";

            //Try Catch for Errors
            try
            {
                //Reading in Files and creating an String Array for each File
                string[] lines1 = File.ReadAllLines(path1);
                string[] lines2 = File.ReadAllLines(path2);
                string[] lines3 = File.ReadAllLines(path3);



                //Declaring Doubly Linked Lists
                DLL list1 = new DLL();
                DLL list2 = new DLL();
                DLL list3 = new DLL();

                if (lines1.Length == 0 || lines2.Length == 0 || lines3.Length == 0) { Console.WriteLine("File is Empty!!!"); Console.ReadKey(); return; }
                else
                {

                    //Converts String Arrays to int Arrays
                    int[] array1 = Array.ConvertAll(lines1, int.Parse);
                    int[] array2 = Array.ConvertAll(lines2, int.Parse);
                    int[] array3 = Array.ConvertAll(lines3, int.Parse);
                    Console.WriteLine("#########################################");

                    //Prints out title for File 1
                    Console.Write("File 1 Content: ");
                    newList(array1, list1);
                    //Calls Print Function to print out List1 Nodes
                    list1.printH(list1.head);
                    //Prints and gets the middle node number
                    Console.Write("List 1 Middle Node: "); Console.WriteLine(list1.Middle(list1.head));
                    //Declares and sets the prime nubmer
                    list1.PrimeCheck(list1.head); Console.WriteLine("");
                    Console.WriteLine("#########################################");


                    //Same thing as List 1 but for list 2
                    Console.Write("File 2 Content: ");
                    newList(array2, list2);
                    list2.printH(list2.head);
                    Console.Write("List 2 Middle Node: "); Console.WriteLine(list2.Middle(list2.head));
                    list2.PrimeCheck(list2.head); Console.WriteLine("");
                    Console.WriteLine("#########################################");

                    //Same thing as List 2 but for list 3
                    Console.Write("File 3 Content: ");
                    newList(array3, list3);
                    list3.printH(list3.head);
                    Console.Write("List 3 Middle Node: "); Console.WriteLine(list3.Middle(list3.head));
                    list3.PrimeCheck(list3.head); Console.WriteLine("");
                    Console.WriteLine("#########################################");

                    Console.ReadLine();
                }

            }//Catches Most errors for this program
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.ReadLine(); }
            //catch (FormatException) { Console.WriteLine("*** Can't Format all Lines ***"); Console.ReadLine(); }
            //catch (FileNotFoundException) { Console.WriteLine("*** File Not Found ***"); Console.ReadLine(); }
            //catch (DirectoryNotFoundException) { Console.WriteLine("*** File Not Found ***"); Console.ReadLine(); }
            //catch (System.ArgumentException) { Console.WriteLine("*** Error ***"); Console.ReadLine(); }
        }

        static void newList(int[] arr, DLL list)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                DLLNode a = new DLLNode(arr[i]);
                list.addToTail(a);//Adds to Tail
                //list1.addToHead(a);//Adds to Head
            }

        }
    }
}
