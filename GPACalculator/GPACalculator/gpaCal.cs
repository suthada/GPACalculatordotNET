using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    internal class gpaCal
    {
        private string name;
        private double score = 0;
        private SortedList<string, double> sortlist = new SortedList<string,double>();
        private double min = 0;
        private double max = 0;
        private double gpa = 0;
        
        public void getScore(string name,double score)
        {
            this.name = name;
            this.score = score;
            sortlist.Add(name, score);
        }

        public double getGpa()
        {
            double sum = 0;
            for (int i = 0; i < sortlist.Count; i++)
            {
                sum = sum + sortlist.Values[i];
            }
            gpa = sum / sortlist.Count;
            return gpa;
        }

        public double getMinScore()
        {
            min = sortlist.Values.Min();
            return min;
        }

        public double getMaxScore()
        {
            max = sortlist.Values.Max();
            return max;
        }

        public string getMinName()
        {
            string minName = sortlist.Keys.Last();
            return minName;
        }

        public string getMaxName()
        {
            string maxName = sortlist.Keys.First();
            return maxName;
        }
    }
}
