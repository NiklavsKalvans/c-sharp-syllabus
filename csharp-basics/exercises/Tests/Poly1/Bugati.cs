﻿using System;

namespace DragRace
{
    public class Bugati : ICar, IBoost
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed++;
        }

        public void SlowDown()
        {
            currentSpeed--;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed++;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
