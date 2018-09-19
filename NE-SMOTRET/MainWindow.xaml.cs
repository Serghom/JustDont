using System.Windows;

namespace NE_SMOTRET
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Calcs.withButton().Show();
        }
        private void ButtonNo_Click(object sender, RoutedEventArgs e)
        {
            new Calcs.withoutButt().Show();
        }
        private void Piatnashki_Click(object sender, RoutedEventArgs e)
        {
            new Piatnashki.main().Show();
        }
    }
}
