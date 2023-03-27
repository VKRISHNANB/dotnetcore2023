using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Games
{
    class Game
    {
        protected int ProtectedValue;
        public int PublicValue;
        private int PrivateValue;
        internal int InternalValue;
    }
    class Tester
    {
        public static void TestGame()
        {
            Game game = new Game();
            game.InternalValue = 100;
            game.PublicValue = 200;
            // game.ProtectedValue = 300;
        }
    }
}
