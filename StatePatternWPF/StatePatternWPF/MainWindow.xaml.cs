using HeroGame.HeroNS;
using HeroGame.HeroNS.States;
using HeroGame.LoggerNS;
using System;
using System.Windows;
using System.Windows.Input;

namespace StatePatternWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Hero hero;
        private readonly Logger logger; 
        
        public MainWindow()
        {
            InitializeComponent();

            // TODO: IoC container?
            logger = Logger.CreateLogger();
            hero = new Hero(new IdleState(logger));
            listBox1.ItemsSource = logger.Data;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    hero.MoveForward();
                    break;
                case Key.S:
                    hero.Stop();
                    break;
                case Key.A:
                    hero.TurnLeft();
                    break;
                case Key.D:
                    hero.TurnRight();
                    break;
                case Key.Space:
                    hero.Jump();
                    break;
                case Key.F:
                    hero.Shoot();
                    break;
            }
            e.Handled = true;
        }
        

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    hero.Stop();
                    break;
                case Key.A:
                    break;
                case Key.D:
                    break;
                case Key.Space:
                    break;
                case Key.F:
                    break;
            }
            e.Handled = true;
        }
    }
}
