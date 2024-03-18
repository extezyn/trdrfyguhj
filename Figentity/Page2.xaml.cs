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

namespace Figentity
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private FitnessClub1Entities trainers = new FitnessClub1Entities();

        public Page2()
        {
            InitializeComponent();
            SecondGrid.ItemsSource = trainers.Trainers.ToList();
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Members mem = new Members();
            mem.FirstName = FN.Text;
            mem.LastName = LN.Text;

            trainers.Members.Add(mem);

            trainers.SaveChanges();
            SecondGrid.ItemsSource = trainers.Trainers.ToList();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (SecondGrid.SelectedItem != null)
            {
                var selected = SecondGrid.SelectedItem as Members;

                selected.FirstName = FN.Text;
                selected.LastName = LN.Text;

            }

            trainers.SaveChanges();
            SecondGrid.ItemsSource = trainers.Trainers.ToList();






        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                trainers.Members.Remove(SecondGrid.SelectedItem as Members);
                trainers.SaveChanges();
                SecondGrid.ItemsSource = trainers.Trainers.ToList();
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
                var selected = SecondGrid.SelectedItem as Members;
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
