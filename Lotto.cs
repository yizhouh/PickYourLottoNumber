using System;
using System.Collections.Generic;

namespace cs_PickYourLottoNumber
{
    public class Lotto
    {
        public int NumberOfBarrelNumbers {get; private set;}
        public int NumberOfSuppleMentaryNumbers {get; private set;}
        public int EndRangeOfBarrelNumbers {get; private set;}
        public int EndRangeOfSuppleMentaryNumbers{get; private set;}

        private static readonly System.Random _rand = new System.Random();
        private const int _startNumber = 1;

        public Lotto(int numberOfBarrelNumbers, int numberOfSuppleMentaryNumbers, 
        int endRangeOfBarrelNumbers, int endRangeOfSuppleMentaryNumbers)
        {
            this.EndRangeOfBarrelNumbers = endRangeOfBarrelNumbers;
            this.EndRangeOfSuppleMentaryNumbers = endRangeOfSuppleMentaryNumbers;
            this.NumberOfBarrelNumbers = numberOfBarrelNumbers;
            this.NumberOfSuppleMentaryNumbers = numberOfSuppleMentaryNumbers;
        }

        //generate random numbers in the range of barrel numbers
        public List<int> GetBarrelNumbers()
        {
            List<int> listOfBarrelNumbers = new List<int>();
            for(int i = 0; i < this.NumberOfBarrelNumbers; i++)
            {
                int number = _rand.Next(_startNumber, this.EndRangeOfBarrelNumbers);
                do
                {
                    number = _rand.Next(_startNumber, this.EndRangeOfBarrelNumbers);
                } while (listOfBarrelNumbers.Contains(number));

                listOfBarrelNumbers.Add(number); 
            }
            
            return listOfBarrelNumbers;
        }

        //generate random numbers in the range of supplementary numbers
        public List<int> GetSuppleMentaryNumbers()
        {
            List<int> listOfSuppleMentaryNumbers = new List<int>();
            for (int i = 0; i < this.NumberOfSuppleMentaryNumbers; i++)
            {
                int number = _rand.Next(_startNumber, this.EndRangeOfSuppleMentaryNumbers);
                do
                {
                    number = _rand.Next(_startNumber, this.EndRangeOfSuppleMentaryNumbers);
                } while(listOfSuppleMentaryNumbers.Contains(number));
                
                listOfSuppleMentaryNumbers.Add(number);
            }

            return listOfSuppleMentaryNumbers;
        }

    
    }
}