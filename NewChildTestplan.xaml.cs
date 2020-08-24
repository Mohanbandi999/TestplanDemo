using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace TestplanDemo
{
    /// <summary>
    /// Interaction logic for NewChildTestplan.xaml
    /// </summary>
    public partial class NewChildTestplan : Window
    {
        List<NewTestPlan> tp = new List<NewTestPlan>();
        
        public NewChildTestplan()
        {
            InitializeComponent();
            //NewTestPlan nw = new NewTestPlan();
            //nw.Name = "tp-10502";
            // Nametext.Text = nw.Name;
        }

        private void SaveDetails(object sender, RoutedEventArgs e)
        {
            
            if (tp.Where(t => t.ID.Equals(Idtext.Text)).Any() == false)
            {

                tp.Add(new NewTestPlan
                {
                    Name = Nametext.Text,
                    ID = Idtext.Text,
                    Version = Versiontext.Text,
                    Description = Descriptiontext.Text,
                    Logo = Logotext.Text
                });
                Nametext.Clear();
                Idtext.Clear();
                Versiontext.Clear();
                Descriptiontext.Clear();
                Logotext.Clear();
            }
            else
            {
                MessageBox.Show("With this ID already details are exist you can update only");
                Idtext.IsReadOnly = true;
            }           
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

            if (tp.Where(t => t.ID.Equals(Idtext.Text)).Any() == true)
            {                
                ///tp.Where(w => w.ID == Idtext.Text).ToList().ForEach(s => s.ID = Idtext.Text);
                tp.Where(w => w.ID == Idtext.Text).ToList().ForEach(s => s.Description = Descriptiontext.Text);
                tp.Where(w => w.ID == Idtext.Text).ToList().ForEach(s => s.Version = Versiontext.Text);
                tp.Where(w => w.ID == Idtext.Text).ToList().ForEach(s => s.Name = Nametext.Text);
                tp.Where(w => w.ID == Idtext.Text).ToList().ForEach(s => s.Logo = Logotext.Text);
            }
            Nametext.Clear();
            Idtext.Clear();
            Versiontext.Clear();
            Descriptiontext.Clear();
            Logotext.Clear();
            Idtext.IsReadOnly = false;
        }
    }
}
