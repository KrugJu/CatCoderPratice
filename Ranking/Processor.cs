using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    public static class Processor
    {

        //public static long calculateDifference(List<DateTime> times)
        //{
        //    long diffTicks = Convert.ToInt64((times[1] - times[0]).TotalSeconds);

        //    return diffTicks;
        //}

        //public static Submission calculateWinner(List<Submission> submissions, DateTime startTime)
        //{
        //    List<Submission> validSubmissions = new List<Submission>();

        //    foreach(Submission submission in submissions)
        //    {
        //        if (submission.Status == "correct") validSubmissions.Add(submission);
        //    }

        //    List<Submission> sortedValidSubmissions = validSubmissions.OrderBy(s => (s.SubmissionTime - startTime).TotalSeconds).ToList();

        //    return sortedValidSubmissions[0];

        //}

        //public static List<Submission> calculateWinners(List<Submission> submissions, DateTime startTime, int taskID)
        //{
        //    List<Submission> validSubmissions = new List<Submission>();

        //    foreach (Submission submission in submissions)
        //    {
        //        if (submission.Status == "correct" && submission.TaskID == taskID) validSubmissions.Add(submission);
        //    }

        //    List<Submission> sortedValidSubmissions = validSubmissions.OrderBy(s => (s.SubmissionTime - startTime).TotalSeconds).ToList();

        //    return sortedValidSubmissions;

        //}




        public static List<User> sortUsers(List<Submission> submissions, DateTime startTime, int maxPoints, List<User> users, int highestTaskID)
        {
            
            for(int i = 1; i <= highestTaskID; i++)
            {
                List<Submission> validSubmissions = new List<Submission>();

                foreach (Submission submission in submissions)
                {
                    if (submission.Status == "correct" && submission.TaskID == i) validSubmissions.Add(submission);
                }

                List<Submission> sortedValidSubmissions = validSubmissions.OrderBy(s => (s.SubmissionTime - startTime).TotalSeconds).ToList();


                int points = maxPoints;

                for (int k = 0; k < sortedValidSubmissions.Count; k++)
                {
                    foreach (User user in users)
                    {
                        if (sortedValidSubmissions[k].Id == user.Uid)
                            user.Points += points;
                    }
                   
                    points--;
                }      


            }

            List<User> sortedUsers = users.OrderBy(u => -u.Uid).ToList();
            sortedUsers = users.OrderBy(u => -u.Points).ToList();

            return sortedUsers;

        }

        public static List<User> getAllUsers(List<Submission> submissions)
        {
            int currentID = 0;
            List<User> users = new List<User>();

            List<Submission> sortedSubmissions = submissions.OrderBy(s => s.Id).ToList();


            foreach(Submission submission in sortedSubmissions)
            {
                if (submission.Id != currentID)
                {
                    users.Add(new User(submission.Id));
                    currentID = submission.Id;
                }
            }

            return users;
        }

        public static int getHighestTaskID(List<Submission> submissions)
        {
            int currentID = 0;

            foreach (Submission submission in submissions)
            {
                if (submission.TaskID > currentID)
                {
                    currentID = submission.TaskID;
                }
            }

            return currentID;
        }



        //public static List<long> calculateDifferences(List<List<DateTime>> timesList)
        //{
        //    List<long> diffs = new List<long>();

        //    foreach(List<DateTime> times in timesList)
        //    {
        //        diffs.Add(Processor.calulateDifference(times));
        //    }

        //    return diffs;
        //}
    }
}
