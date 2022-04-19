using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlGridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Persona> personas = new ObservableCollection<Persona>();   
        private PersonasDaoObjects personaDao = new PersonasDaoObjects();
        public MainWindow()
        {
            InitializeComponent();
            personas = new ObservableCollection<Persona>( personaDao.listar());
            listViewAgenda.ItemsSource = personas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void mail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
