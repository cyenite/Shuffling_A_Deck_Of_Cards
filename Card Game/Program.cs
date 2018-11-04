using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> mylist = new List<Card>();
            
            mylist.Add(new Card("KH"));
            mylist.Add(new Card("KD"));
            mylist.Add(new Card("KS"));
            mylist.Add(new Card("KF"));
            mylist.Add(new Card("QH"));
            mylist.Add(new Card("QD"));
            mylist.Add(new Card("QS"));
            mylist.Add(new Card("QF"));
            mylist.Add(new Card("JH"));
            mylist.Add(new Card("JD"));
            mylist.Add(new Card("JS"));
            mylist.Add(new Card("JF"));
            mylist.Add(new Card("10H"));
            mylist.Add(new Card("10D"));
            mylist.Add(new Card("10S"));
            mylist.Add(new Card("10F"));
            mylist.Add(new Card("9H"));
            mylist.Add(new Card("9D"));
            mylist.Add(new Card("9S"));
            mylist.Add(new Card("9F"));
            mylist.Add(new Card("8H"));
            mylist.Add(new Card("8D"));
            mylist.Add(new Card("8S"));
            mylist.Add(new Card("8F"));
            mylist.Add(new Card("7H"));
            mylist.Add(new Card("7D"));
            mylist.Add(new Card("7S"));
            mylist.Add(new Card("7F"));
            mylist.Add(new Card("6H"));
            mylist.Add(new Card("6D"));
            mylist.Add(new Card("6S"));
            mylist.Add(new Card("6F"));
            mylist.Add(new Card("5H"));
            mylist.Add(new Card("5D"));
            mylist.Add(new Card("5S"));
            mylist.Add(new Card("5F"));
            mylist.Add(new Card("4H"));
            mylist.Add(new Card("4D"));
            mylist.Add(new Card("4S"));
            mylist.Add(new Card("4F"));
            mylist.Add(new Card("3H"));
            mylist.Add(new Card("3D"));
            mylist.Add(new Card("3S"));
            mylist.Add(new Card("3F"));
            mylist.Add(new Card("2H"));
            mylist.Add(new Card("2D"));
            mylist.Add(new Card("2S"));
            mylist.Add(new Card("2F"));
            mylist.Add(new Card("AH"));
            mylist.Add(new Card("AD"));
            mylist.Add(new Card("AS"));
            mylist.Add(new Card("AF"));
            
            var rnd = new Random();
            var result = mylist.OrderBy(item => rnd.Next());
            
            List<string> shuffled =new List<string>();

            foreach (var item in result)
            {
                Console.WriteLine($" {item.Name}");

            }

            Console.ReadLine();
        }
    }

    public class Card
    {
        string name;

        public Card(string name)
        {
            Name = name;
        }
       public string Name
       {
           get => name;
           set => name = value;
       }   
    }
   
}