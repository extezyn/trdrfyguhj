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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private FitnessClub1Entities trainers = new FitnessClub1Entities();

        public Page3()
        {
            InitializeComponent();
            ThirdGrid.ItemsSource = trainers.Members.ToList();
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Classes classes = new Classes();
            classes.ClassDate = Convert.ToDateTime(classDate);
            classes.MemberID = Convert.ToInt32(MemberId);
            classes.TrainerID = Convert.ToInt32(TrainerId);

            trainers.Classes.Add(trainers);

            trainers.SaveChanges();
            ThirdGrid.ItemsSource = trainers.Classes.ToList();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (ThirdGrid.SelectedItem != null)
            {
                var selected = ThirdGrid.SelectedItem as Members;
                selected.FirstName = MemberId.Text;
                selected.LastName = TrainerId.Text;

            }

            trainers.SaveChanges();
            ThirdGrid.ItemsSource = trainers.Classes.ToList();






        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                trainers.Members.Remove(ThirdGrid.SelectedItem as Members);
                trainers.SaveChanges();
                ThirdGrid.ItemsSource = trainers.Classes.ToList();
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
                var selected = ThirdGrid.SelectedItem as Members;
                selected.FirstName = MemberId.Text;
                selected.LastName = TrainerId.Text;
            }
            catch
            {
                MessageBox.Show("На пустое не тыкать");
            }

        }

    }
}
