using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment1_Task2
{
    class DLL
    {
        //Declaring head and tail.
        public DLLNode head;
        public DLLNode tail;
        //Constructor
        public DLL() { head = null; tail = null; }
        //Checks for the middle node
        public string Middle(DLLNode p)
        {
            if (p == null)
                return head.num.ToString();

            DLLNode SP = head, FP = head;
            //loops until FP reaches the end (Null)
            while(FP != null && FP.next != null)
            {
                //Moves slow put to next node
                SP = SP.next;
                //Fast Pointer moves double the slow pointer
                FP = FP.next.next;
                
            }
            if ((getLength(p) % 2 == 0)) 
            {
                return SP.num.ToString();
            }
            //if(getLength(p) <= 1)
            //{
            //    return SP.num.ToString();
            //}
            //returns the middle node as Sp
            int SP2 = SP.prev.num;
            return SP2.ToString()+", " + SP.num.ToString();

        }
        //Method to Print out the list
        public void printH(DLLNode head)
        {
            DLLNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.num + " ");
                temp = temp.next;
            }
            Console.WriteLine("");
            return;
        }

        public static Boolean isPrime(int n)
        {
            //Sets to Bool so that all Numbers are Prime numbers until Calculated not
            Boolean b = true;
            //Sqrs the number
            int number2 = (int)Math.Sqrt(n);
            //Checks if number is greater than 1 since any number below is not a prime
            if (!(n <= 1))
            {
                for (int num = 2; num <= number2; num++)
                {
                    //if the remainer is a 0
                    if ((n % num) == 0)
                    {
                        //Bool is set to Fale which means number is not a prime number
                        b = false;
                        //Breaks loops
                        break;
                    }
                }
                //Returns Prime number
                return (b);
            }
            //Otherwise Returns false
            return false;
        }
        //Method to check a give number is a prime
        public void PrimeCheck(DLLNode node)
        {
            //Counter for how many primes are in a list
            int count = 0;
            string printp = "";
            //Loops until node is 0
            while (node != null)
            {
                //Calls method isPrime and if number returns true then adds 1 to counter
                if (isPrime(node.num))
                {
                    count += 1;
                    if (count == 5)
                    {
                        Console.WriteLine(Environment.NewLine);
                    }

                    printp = printp + " " + node.num.ToString();
                }
                //goes to next node
                node = node.next;
            }
            if(count == 0) { printp = " No Primes"; }
            //Returns the count of nodes
            Console.WriteLine("Prime Numbers:"+printp);
        }
        public int count1 = 1;
        //Adds to tail method
        public void addToTail(DLLNode p)
        {
            while (tail == null)
            {
                head = p;
                tail = p;
                return;
            }
            count1 += 1;
            tail.next = p;
            p.prev = tail;
            tail = p;
            return;
        }
        public int getLength(DLLNode p)
        {
            DLLNode temp = p;
            int amount = 1;
            while(temp != null)
            {
                amount++;
                temp = temp.next;
            }
            return amount;
        }

    }
}
