using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    public static class Splitter
    {
        public static List<DateTime> SplitIntoDates(string s)
        {
            string[] values = s.Split(' ');

            List<DateTime> timeList = new List<DateTime>();

            foreach (string value in values)
            {
                timeList.Add(DateTime.ParseExact(value, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
            }


            return timeList;
        }

        public static List<Submission> SplitIntoSubmissions(string s)
        {
            string[] values = s.Split(' ');

            List<Submission> submissionList = new List<Submission>();

            for(int i = 3; i < values.Length; i += 4)
            {
                submissionList.Add(new Submission(Convert.ToInt32(values[i]), values[i + 1], values[i + 2], Convert.ToInt32(values[i+3])));
            }


            return submissionList;
        }

        public static DateTime GetStartTime(string s)
        {
            return DateTime.ParseExact(s.Split(' ').GetValue(0).ToString(), "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static int GetMaxPoints(string s)
        {
            return Convert.ToInt32(s.Split(' ').GetValue(1));
        }
    }
}
