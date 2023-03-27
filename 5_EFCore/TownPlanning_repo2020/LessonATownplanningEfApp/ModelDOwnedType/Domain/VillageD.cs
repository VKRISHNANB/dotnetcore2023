using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonATownplanningEfApp.ModelDOwnedType
{
    public class VillageD
    {
        public int VillageDId{get;set;}
        public String Name{get;set;}
        public String City{get;set;}
        public String State{get;set;}
        public int Pincode{get;set;}
        // Navigation Property
        // One to Many - One Village Many People
        public List<PersonD> Residents{get;set;} 
    }
}