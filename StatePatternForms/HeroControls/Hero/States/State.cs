using HeroGame.LoggerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame.HeroNS.States
{
    public abstract class State
    {
        protected Logger logger;
        public Hero Hero { get; set; } // needed for lazy loading (constructor geeft kip-ei probleem)

        public State(Logger logger)
        {
            this.logger = logger;
        }

        abstract public void Jump();
        abstract public void MoveForward();
        abstract public void Stop();
        abstract public void Shoot();
        abstract public void TurnLeft();
        abstract public void TurnRight();
    }
}
