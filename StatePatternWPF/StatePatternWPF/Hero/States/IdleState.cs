using HeroGame.LoggerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame.HeroNS.States
{
    class IdleState : State
    {
        public IdleState(Logger logger) : base(logger) { } // without logger state could be an interface

        public override void MoveForward()
        {
            logger.Log("Running forward");
            Hero.ChangeState(new RunningState(logger));
        }

        public override void Stop()
        {
        }
        
        public override void Jump()
        {
            logger.Log("Jumping up");
            Hero.ChangeState(new JumpingState(logger));
        }

        public override void Shoot()
        {
            logger.Log("Precision shot!");
        }

        public override void TurnLeft()
        {
            logger.Log("Look left");
        }

        public override void TurnRight()
        {
            logger.Log("Look right");
        }
    }
}
