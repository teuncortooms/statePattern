using HeroGame.LoggerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame.HeroNS.States
{
    class RunningState : State
    {
        public RunningState(Logger logger) : base(logger)
        {
        }

        public override void Jump()
        {
            logger.Log("Jumping forward!");
            Hero.ChangeState(new JumpingState(logger));
        }

        public override void MoveForward()
        {
        }

        public override void Shoot()
        {
            logger.Log("Pew pew! Running and shooting.");
        }

        public override void TurnLeft()
        {
            logger.Log("Turning left while running.");
        }

        public override void TurnRight()
        {
            logger.Log("Turning right while running.");
        }

        public override void Stop()
        {
            logger.Log("Stopped.");
            Hero.ChangeState(new IdleState(logger));
        }
    }
}
