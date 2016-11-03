namespace blank_eye_tracking
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media.Animation;
    using System.Threading.Tasks;
    using System.Threading;
    using System;
    using System.Collections.Generic;
    using System.Windows.Media;
 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ActualPage is DisplayGrid&#039;s actual child
        UserControl ActualPage;
 
        // Instanciate the UserControls as MainWindow&#039;s attributes (to use them on any time)
        VentilationControls VentilationUC = new VentilationControls();
        VehicleControls VehicleControlsUC = new VehicleControls();
 
        public MainWindow()
        {
            InitializeComponent();
 
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }
 
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }
 
        private void Main_Button1_Click(object sender, RoutedEventArgs e)
        {
            //VentilationControls VentilationUC = new VentilationControls();
            changeUC(VentilationUC);
        }
 
        private void Main_Button2_Click(object sender, RoutedEventArgs e)
        {
            //VehicleControls VehicleControlsUC = new VehicleControls();
            changeUC(VehicleControlsUC);
        }
 
        private void changeUC(UserControl UCPage)
        {
            // Initial time when no UserControl is displayed
            if (ActualPage == null)
            {
                DisplayGrid.Children.Add(UCPage);
                ActualPage = (UserControl)VisualTreeHelper.GetChild(DisplayGrid, 0);    // Add new UC as ActualPage
            }
            // Check if actual UserControl displayed is a different one
            else if (!(ActualPage.Equals(UCPage)))
            {
                DisplayGrid.Children.Clear();                                           // Clear all DisplayGrid children
                DisplayGrid.Children.Add(UCPage);                                       // Add UserControl parameter as a child of DisplayGrid
                ActualPage = (UserControl)VisualTreeHelper.GetChild(DisplayGrid, 0);    // Refresh ActualPage to be used on "if-else if"
            }
        }
    }
}