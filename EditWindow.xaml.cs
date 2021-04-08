using System;
using System.Collections.Generic;
using System.Windows;


namespace OOP_Lab_2
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private List<OOP_Lab_1.MenuItem> orderItem;
        private Int32 selectedIndex;
        private List<Factory> factoryList = new List<Factory>();
        private List<string> imageList = new List<string>();
        EndWindow window;

        public EditWindow(EndWindow window, List<Factory> factoryList, List<string> imageList, List<OOP_Lab_1.MenuItem> item, Int32 selectedIndex)
        {
            InitializeComponent();
            orderItem = item;
            this.selectedIndex = selectedIndex;
            this.factoryList = factoryList;
            this.imageList = imageList;
            this.window = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetAnswers();
            Close();
        }

        private void GetAnswers()
        {
            object[] answers = new object[3];
            answers[0] = AboutMenu1.SelectedIndex;
            answers[1] = Choose1.IsChecked;
            answers[2] = AboutMenu2.SelectedIndex == 0 ? true : false;

            foreach (Factory factory in factoryList)
            {
                if (factory.Name.IsEqual(orderItem[selectedIndex].Name))
                {
                    factory.answers = answers;
                    orderItem[selectedIndex] = factory.Create(answers);
                }
            }

            PlayWithLists.CreateOrderList(window, orderItem, imageList);
        }
    }
}
