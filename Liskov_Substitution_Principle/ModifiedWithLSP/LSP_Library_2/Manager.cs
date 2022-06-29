﻿
namespace ModifiedWithLSP
{
    public class Manager : Employee, IManager
    { 
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing performance of direct report");
        }
    } 
    
}
