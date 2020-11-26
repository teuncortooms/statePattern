using HeroGame.HeroNS.States;
using HeroGame.LoggerNS;
using System;

namespace HeroGame.HeroNS
{
    public class Hero
    {
        private State state;

        public Hero(State initialState)
        {
            ChangeState(initialState);
        }

        public void ChangeState(State state)
        {
            this.state = state;
            state.Hero = this; // lazy loading
        }

        public void Jump()
        {
            state.Jump();
        }

        public void Stop()
        {
            state.Stop();
        }

        public void MoveForward()
        {
            state.MoveForward();
        }

        public void Shoot()
        {
            state.Shoot();
        }

        public void TurnLeft()
        {
            state.TurnLeft();
        }

        public void TurnRight()
        {
            state.TurnRight();
        }
    }
}
