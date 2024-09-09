using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d33ClassesNProperties.Activity2
{
    public enum PostType { Clerks=0,PO=1 }
    public enum ApplicationStatus { Accepted=0,Pending=1,Rejected=2}
    public class Application
    {
        private readonly Candidate appnt;
        private readonly int appNo;
        private DateTime interviewDate;
        private  PostType postappliedfor;
        private ApplicationStatus appstatus;
        public Application(Candidate  c,int ano)
        {
            if (c == null)
            {
                throw new Exception("In Valid Customer. Customer is NULL");
            }
            appnt = c;
            if (ano < 0)
            {
                throw new Exception("In Valid Application No. Application Number Must be Greater than 0");
            }
            appNo = ano;
        }
        public DateTime InterviewDate
        {
            get { return interviewDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("In Valid Application Date. Date Must be in the Future");
                }
                interviewDate = value;
            }
        }
        public PostType AppliedFor
        {
            get { return postappliedfor; }
            set
            {
                if(!Enum.IsDefined(typeof(PostType),value) )
                {
                    throw new Exception("In Valid Application Post.Post Must be Clerks/PO");
                }
                postappliedfor = value;
            }
        }
        public ApplicationStatus Status
        {
            get { return appstatus; }
            set
            {
                if (!Enum.IsDefined(typeof(ApplicationStatus), value))
                {
                    throw new Exception("In Valid Status.Status must be Accepted/Pending/Rejected");
                }
                appstatus = value;
            }
        }

        //readonly properties
        public Candidate Applicant
        {
            get { return appnt; }
        }
        public int ApplicationNo
        {
            get { return appNo; }
        }
    }
}
