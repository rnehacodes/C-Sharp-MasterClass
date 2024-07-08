using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    public class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += StopGame;
        }
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started.");
            Console.WriteLine("Drawing Visuals....");
        }

        private void StopGame()
        {
            Console.WriteLine("Rendering Engine Stopped.");
        }
    }
}
