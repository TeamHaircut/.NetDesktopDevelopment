using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUIFunctionalTest0.Views
{
    /// <summary>
    /// Interaction logic for Participant.xaml
    /// </summary>
    public partial class Participant : Page
    {
        public Participant()
        {
            InitializeComponent();
        }

        private void ParticipantClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Views.Overview());
        }
    }
}
