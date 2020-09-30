using System;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution19 : ISolution
    {
        public string GetSolution()
        {
            var date = new DateTime(1901, 1, 1);
            var finishDate = new DateTime(2001, 1, 1);
            var sundays = 0;

            while (date < finishDate) {
                if (date.DayOfWeek == DayOfWeek.Sunday) sundays++;
                date = date.AddMonths(1);
            }            

            return sundays.ToString();
        }
    }    
}