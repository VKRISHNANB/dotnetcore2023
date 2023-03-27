using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d33ClassesNProperties.Activity2
{
    public class Candidate
    {
        private readonly int applicantID;
        private String applicantName=String.Empty;
        public Candidate(int aid)
        {
            if(aid<0)
            {
                Console.WriteLine("INVALID APPLICANT ID!!!!");
                return;
            }
            applicantID = aid;
        }
        public int CandidateID
        {
            get { return applicantID; }
        }
        public String Name
        {
            
            get { return applicantName;  }
            set
            {
                value = value.Trim();
                if(value==null || value.Equals(" ") || value=="")
                {
                    throw new Exception("Name Must Not Be Empty!!!");
                }
                if(value.Length<3)
                {
                    throw new Exception("Name Must Have atleast 3 char!!!");
                }
                if (value.Length > 15) throw new Exception("INVALID NAME!!! Name must be less than 16 char");
                char[] data = value.ToUpper().ToCharArray();
                foreach (char c1 in data)
                {
                    int x = (int)c1;
                    if (x < 65 || x > 90)
                        throw new Exception("INVALID NAME!!! Name must have only Alphabets");
                }
                applicantName = value;
            }
        }
    }
}
