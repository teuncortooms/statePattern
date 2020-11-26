using HeroGame.LoggerNS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace HeroGame.HeroNS.States
{
    class JumpingState : State
    {
        readonly Timer timer;

        public JumpingState(Logger logger) : base(logger)
        {
            timer = new Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.Start();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            logger.Log("Landed.");
            timer.Stop();
            Hero.ChangeState(new IdleState(logger));
        }

        public override void Jump()
        {
            logger.Log("I cannot jump while jumping.");
        }

        public override void MoveForward()
        {
            logger.Log("I cannot move while jumping");
        }

        public override void Shoot()
        {
            logger.Log("Pew pew! Aiming down.");
        }

        public override void TurnLeft()
        {
            logger.Log("I cannot turn while jumping.");
        }

        public override void TurnRight()
        {
            logger.Log("I cannot turn while jumping.");
        }

        public override void Stop()
        {
            logger.Log("Cannot stop mid-air.");
        }
    }
}
