using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    public class Submission
    {
        private int id;
        private DateTime submissionTime;
        private string status;
        private int taskID;
        private int points;


        public Submission(int id, string time, string status, int taskID)
        {
            this.id = id;
            this.submissionTime = DateTime.ParseExact(time, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            this.status = status;
            this.taskID = taskID;
            this.points = 0;
        }



        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime SubmissionTime
        {
            get
            {
                return submissionTime;
            }

            set
            {
                submissionTime = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int TaskID
        {
            get
            {
                return taskID;
            }

            set
            {
                taskID = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }
    }
}
