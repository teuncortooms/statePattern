using HeroGame.HeroNS;
using HeroGame.HeroNS.States;
using HeroGame.LoggerNS;
using System;
using System.Collections.Specialized;
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

            logger = Logger.GetInstance();
            hero = new Hero(new IdleState(logger));

            SetupListBox();
        }

        private void SetupListBox()
        {
            listBox1.Items.Clear();
            listBox1.ItemsSource = logger.Data;
            ((INotifyCollectionChanged) listBox1.ItemsSource).CollectionChanged +=
                new NotifyCollectionChangedEventHandler(ScrollDownOnCollectionChanged);
        }

        public void ScrollDownOnCollectionChanged(Object sender, NotifyCollectionChangedEventArgs e)
        {
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.UpdateLayout(); 
            listBox1.ScrollIntoView(listBox1.SelectedItem);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    hero.MoveForward();
                    break;
                case Key.S:
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
