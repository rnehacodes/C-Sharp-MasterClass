using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    public class Player
    {
        public string PlayerName { get; set; }
        public Player(string playerName)
        {
            PlayerName = playerName;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += StopGame;
        }
        private void StartGame()
        {
            Console.WriteLine($"Spawning player: {PlayerName}");
        }

        private void StopGame()
        {
            Console.WriteLine($"Removing player: {PlayerName}");
        }
    }
}
