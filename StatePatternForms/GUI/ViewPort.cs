
using HeroGame.HeroNS;
using HeroGame.HeroNS.States;
using HeroGame.LoggerNS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HeroGame
{
    public partial class ViewPort : Form
    {
        private readonly Hero hero;
        private readonly Logger logger;

        public ViewPort()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // TODO: IoC container
            logger = Logger.CreateLogger();
            hero = new Hero(new IdleState(logger)); 
        }

        private void GUIUpdater(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(logger.Data.ToArray());
        }

        private void ViewPort_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    hero.MoveForward();
                    break;
                case Keys.S:
                    hero.Stop();
                    break;
                case Keys.A:
                    hero.TurnLeft();
                    break;
                case Keys.D:
                    hero.TurnRight();
                    break;
                case Keys.Space:
                    hero.Jump();
                    break;
                case Keys.F:
                    hero.Shoot();
                    break;
            }
            e.Handled = true;
        }

        private void ViewPort_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    hero.Stop();
                    break;
                case Keys.A:
                    break;
                case Keys.D:
                    break;
                case Keys.Space:
                    break;
                case Keys.F:
                    break;
            }
            e.Handled = true;
        }
    }
}