using System;
using System.Collections.Generic;
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

namespace operadorLogicoNAO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string tipoUsuario;
            tipoUsuario = txtTipo.Text.ToUpper();

            if(tipoUsuario != "ADMINISTRADOR")
            {
                MessageBox.Show("Atenção, usuário sem poderes administrativos." +
                   " Algumas tarefas serão bloqueadas", "Login",
                   MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else
            {

                MessageBox.Show("Olá Administrador", "Login",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}