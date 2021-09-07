using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var parrot = new Parrot();
            var radio = new Radio();
            var firework = new Firework();
            var sounds = new List<ISound> { parrot, radio, firework };
            foreach (var sound in sounds)
            {
                sound.PlaySound();
            }
            
        }
    }
}