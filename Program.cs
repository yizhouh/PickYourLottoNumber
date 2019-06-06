using System;
using System.Collections.Generic;

namespace cs_PickYourLottoNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter barrel numbers range: Start from 1 to ___    ");
            int endOfBarrelNUmbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many numbers you want to pick from barrel numbers:  ");
            int numberOfBarrelNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter supplementary numbers range: Start from 1 to __  ");
            int endOfSuppleMentaryNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many numbers you want to pick from supplementary numbers:  ");
            int numberOfSuppleMentaryNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("How many entries you want to have:  ");
            int numberOfEntries = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Lotto lotto = new Lotto(numberOfBarrelNumbers,numberOfSuppleMentaryNumbers,endOfBarrelNUmbers,endOfSuppleMentaryNumbers);
            for(int i = 0; i < numberOfEntries; i++)
            {
                var listOfBarrelNumbers = lotto.GetBarrelNumbers();
                var listOfSuppleMentaryNumbers = lotto.GetSuppleMentaryNumbers();
                PrintList(listOfBarrelNumbers);
                PrintList(listOfSuppleMentaryNumbers);
            }



        }

        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }
    }
}
