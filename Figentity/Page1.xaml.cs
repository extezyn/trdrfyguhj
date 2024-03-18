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
using System.Xml.Linq;

namespace Figentity
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private FitnessClub1Entities fit = new FitnessClub1Entities();
        public Page1()
        {
            InitializeComponent();
            FirstGrid.ItemsSource = fit.Members.ToList();
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Members mem = new Members();
            mem.FirstName = FN.Text;
            mem.LastName = LN.Text;

            fit.Members.Add(mem);

            fit.SaveChanges();
            FirstGrid.ItemsSource = fit.Members.ToList();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (FirstGrid.SelectedItem != null)
            {
                var selected = FirstGrid.SelectedItem as Members;

                selected.FirstName = FN.Text;
                selected.LastName = LN.Text;
              
            }

            fit.SaveChanges();
            FirstGrid.ItemsSource = fit.Members.ToList();



          

         
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                fit.Members.Remove(FirstGrid.SelectedItem as Members);
                fit.SaveChanges();
                FirstGrid.ItemsSource = fit.Members.ToList();
            }
            catch
            {
                MessageBox.Show("анлак");
            }

        }

        private void ierach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FirstGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var selected = FirstGrid.SelectedItem as Members;
                FN.Text = selected.FirstName;
                LN.Text = selected.FirstName;
            }
            catch
            {
                MessageBox.Show("На пустое не тыкать");
            }

        }
    }
}
