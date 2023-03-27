using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LessonATownplanningEfApp.ModelDOwnedType
{
    [Owned]
    public class Address
    {
        public Address(String doorNo, String flatName,
            String plotNo, String streetName)
        {
            DoorNo = doorNo;
            FlatName = flatName;
            PlotNo = plotNo;
            StreetName = streetName;
        }
        #region privateconstructor
        /**
         * Adding a private parameterless constructor 
         * 		ERROR Message	"No suitable constructor found for entity type 'Address'. 
         * 		The following constructors had parameters that could not be bound to properties of the entity type: 
         * 		cannot bind 'doorno', 'plotno', 'street' in 'Address(string doorno, string flatName, string plotno, string street)'."
         * Private constructor is not REQUIRED if the Parameters of the above constructors
         * are name as per convention- instead of doorno-> doorNo, plotno->plotNo,street->streetName
         */
        //private Address() { }
        #endregion
        public String DoorNo { get; set; }
        public String FlatName { get; set; }
        public String PlotNo { get; set; }
        public String StreetName { get; set; }
        public String FullAddress => $"{DoorNo},{FlatName},{PlotNo},{StreetName} ";
    }
}
