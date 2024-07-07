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

        public static GameEvent OnStart, OnGameOver;
    }
}
