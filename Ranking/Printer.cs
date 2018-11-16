using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    public static class Printer
    {
        //public static void printAllOutputsLevel1(List<string> inputs)
        //{

        //    List<string> outputs = new List<string>();

        //    foreach (string input in inputs)
        //    {
        //        List<DateTime> times = Splitter.SplitIntoDates(input);
        //        long diff = Processor.calculateDifference(times);

        //        string line = diff.ToString();

        //        outputs.Add(line + "\n");
        //    }

        //    System.IO.File.WriteAllLines(@"C:\Users\Berger Elias\Downloads\Output\output.txt", outputs);
        //}

        //public static void printAllOutputsLevel2(List<string> inputs)
        //{

        //    List<string> outputs = new List<string>();

        //    foreach (string input in inputs)
        //    {
        //        List<Submission> times = Splitter.SplitIntoSubmissions(input);
        //        DateTime startingTime = Splitter.GetStartTime(input);

        //        Submission winner = Processor.calculateWinner(times, startingTime);

        //        string line = winner.Id.ToString() + " " + winner.SubmissionTime.ToString("HH:mm:ss");

        //        outputs.Add(line + "\n");
        //    }

        //    System.IO.File.WriteAllLines(@"C:\Users\Berger Elias\Downloads\Output\output.txt", outputs);
        //}

        //public static void printAllOutputsLevel3(List<string> inputs)
        //{

        //    List<string> outputs = new List<string>();

        //    foreach (string input in inputs)
        //    {
        //        List<Submission> times = Splitter.SplitIntoSubmissions(input);
        //        DateTime startingTime = Splitter.GetStartTime(input);

        //        List<Submission> winners = Processor.calculateWinners(times, startingTime);

        //        string line = "";

        //        line += winners.Count.ToString();

        //        foreach(Submission winner in winners)
        //        {
        //            line += winner.Id.ToString() + " " + winner.SubmissionTime.ToString("HH:mm:ss") + " ";
        //        }

        //        line = line.TrimEnd(' ');

        //        outputs.Add(line + "\n");
        //    }

        //    System.IO.File.WriteAllLines(@"C:\Users\Berger Elias\Downloads\Output\output.txt", outputs);
        //}





        public static void printAllOutputsLevel5(List<string> inputs)
        {

            List<string> outputs = new List<string>();

            foreach (string input in inputs)
            {
                List<Submission> times = Splitter.SplitIntoSubmissions(input);


                List<User> winners = Processor.sortUsers(times, Splitter.GetStartTime(input), Splitter.GetMaxPoints(input), Processor.getAllUsers(times), Processor.getHighestTaskID(times));

                string line = "";             

                foreach(User user in winners)
                {
                    line += user.Points + " " + user.Uid + " ";
                }

                line = line.TrimEnd(' ');

                outputs.Add(line + "\n");
            }

            System.IO.File.WriteAllLines(@"C:\Users\Berger Elias\Downloads\Output\output.txt", outputs);
        }


    }
}
