using HeroGame.LoggerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame.HeroNS.States
{
    class IdleState : State
    {
        public IdleState(Logger logger) : base(logger)
        {
        }

        public override void Jump()
        {
            logger.Log("Jump up");
            Hero.ChangeState(new JumpingState(logger));
        }

        public override void MoveForward()
        {
            logger.Log("Moving forward");
            Hero.ChangeState(new RunningState(logger));
        }

        public override void Shoot()
        {
            logger.Log("Precision shot!");
        }

        public override void Stop()
        {
            logger.Log("Already idle!");
        }

        public override void TurnLeft()
        {
            logger.Log("Looking left");
        }

        public override void TurnRight()
        {
            logger.Log("Looking right");
        }
    }
}
