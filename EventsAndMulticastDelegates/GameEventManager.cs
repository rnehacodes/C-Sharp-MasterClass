using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    public class GameEventManager
    {
        public delegate void GameEvent();

        public static GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started...");
                //call all the methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameStop()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game has stopped...");
                //call all the methods subscribed to this event
                OnGameOver();
            }
        }
    }
}
