using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7Interfaces
{
    interface IVehicle
    {
      //public abstract  void Start();
        void Start();
        void Stop();
        void Move();
        void Turn();
    }
}
