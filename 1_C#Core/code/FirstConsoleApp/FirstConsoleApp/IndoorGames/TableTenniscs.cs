using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstConsoleApp.Games;
namespace FirstConsoleApp.IndoorGames
{
    class TableTenniscs:Game
    {
        public override string ToString()
        {
            //String result = $"{this.PublicValue}, {this.InternalValue}, {this.ProtectedValue},{this.PrivateValue}  ";
            String result = $"{this.PublicValue}, {this.InternalValue}, {this.ProtectedValue}  ";
            return result;
        }
    }
}
