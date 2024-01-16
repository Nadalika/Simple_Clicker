using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Clicker
{
    public class GameStateManager
    {
        private static GameStateManager instance;

        public static GameStateManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameStateManager();
                }
                return instance;
            }
        }

        public int CollectedResources { get; set; }

        private GameStateManager()
        {
            // Inicjalizacja innych zmiennych stanu gry według potrzeb
        }
    }
}
