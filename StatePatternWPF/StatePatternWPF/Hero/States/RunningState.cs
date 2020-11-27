using HeroGame.LoggerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame.HeroNS.States
{
    class RunningState : State
    {
        public RunningState(Logger logger) : base(logger) { } // without logger state could be an interface


        public override void MoveForward()
        {
        }

        public override void Stop()
        {
            logger.Log("Stopped.");
            Hero.ChangeState(new IdleState(logger));
        }

        public override void Jump()
        {
            logger.Log("Jumping forward!");
            Hero.ChangeState(new JumpingState(logger));
        }

        public override void Shoot()
        {
            logger.Log("Terrible shot. Steady your weapon.");
        }

        public override void TurnLeft()
        {
            logger.Log("Turn left while running.");
        }

        public override void TurnRight()
        {
            logger.Log("Turn right while running.");
        }
    }
}
