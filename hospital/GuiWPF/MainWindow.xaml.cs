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
using Storage;

namespace GuiWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UICalendarBridge bridge;

        public MainWindow()
        {
            InitializeComponent();
            bridge = new UICalendarBridge();
        }

        private void save_Click(object sender,RoutedEventArgs e)
        {
            string pName = patientName.Text;
            string dName = doctorName.Text;
            string stime = timeOfDay.Text;
            string sdate = date.Text;
            bridge.ScheduleSingleAppointment(pName, dName, stime, sdate);
        }
    }
}
