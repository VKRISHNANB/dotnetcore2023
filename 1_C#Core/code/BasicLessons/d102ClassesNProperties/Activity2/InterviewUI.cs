using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d33ClassesNProperties.Activity2
{
    class InterviewUI
    {
        public static void GetApplicatDetails()
        {
            Console.WriteLine("Enter Candidate ID >0");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Candidate Name Length >3");
            String name = Console.ReadLine();
            Candidate c1 = new Candidate(id);
            c1.Name = name;

            Console.WriteLine("Enter Application ID >0");
            int applinno = int.Parse(Console.ReadLine());
            Application appln = new Application(c1, applinno);

            Console.WriteLine("Enter Interview Date mm/dd/yyyy > Today");
            DateTime interDate = DateTime.Parse(Console.ReadLine());
            appln.InterviewDate = interDate;

            Console.WriteLine("Enter Post Applied For Clerks/PO");
            String spost = Console.ReadLine();
            Type t1 = typeof(PostType);
            PostType post = (PostType)Enum.Parse(t1, spost);
            appln.AppliedFor = post;

            Console.WriteLine("Enter ApplicationStatus Accepted/Pending/Rejected");
            String strstatus = Console.ReadLine();
            Type t2 = typeof(ApplicationStatus);
            ApplicationStatus status = (ApplicationStatus)Enum.Parse(t2, strstatus);
            appln.Status = status;
            //----------------Display the out put-----------
            Console.WriteLine("Candidate ID "+c1.CandidateID);
            Console.WriteLine("Candidate Name "+c1.Name);
            Console.WriteLine("ApplicationNo " + appln.ApplicationNo);
            Console.WriteLine("Post Applied For " + appln.AppliedFor);
            Console.WriteLine("Application Status " + appln.Status);
            Console.WriteLine("InterviewDate " + appln.InterviewDate.ToShortDateString());
        }

    }
}
