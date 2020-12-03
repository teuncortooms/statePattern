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

        public abstract void Jump();
        public abstract void MoveForward();
        public abstract void Stop();
        public abstract void Shoot();
        public abstract void TurnLeft();
        public abstract void TurnRight();
    }
}
