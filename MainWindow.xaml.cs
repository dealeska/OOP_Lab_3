using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Reflection;


namespace OOP_Lab_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Factory> factoryList = new List<Factory>();
        public List<OOP_Lab_1.MenuItem> orderList = new List<OOP_Lab_1.MenuItem>();
        private List<string> imageList = new List<string>();
        

        public MainWindow(List<Factory> factoryList, List<OOP_Lab_1.MenuItem> orderList, List<string> imageList)
        {
            this.orderList = orderList;
            this.imageList = imageList;
            this.factoryList = factoryList;
            InitializeComponent();
            SetVisability(Visibility.Hidden);           

            for (Int32 i = 0; i < factoryList.Count; i++)
            {
                MenuItem.Items.Add(factoryList[i].Name);
            }
        }        

        public MainWindow()
        {
            InitializeComponent();
            SetVisability(Visibility.Hidden);

            Assembly asm = Assembly.Load("OOP_Lab_2");

            Type[] types = asm.GetTypes();
            Int32 i = 0;

            foreach (Type t in types)
            {
                if (t.IsSubclassOf(typeof(Factory)))
                {
                    factoryList.Add((Factory)Activator.CreateInstance(t));
                    MenuItem.Items.Add(factoryList[i++].Name);                    
                }
            }
        }

        private void btSelect_Click(object sender, RoutedEventArgs e)
        {
            FillWindow();                                    
        }        

        private void btOrder_Click(object sender, RoutedEventArgs e)
        {
            EndWindow endWindow = new EndWindow(orderList, imageList, factoryList);
            PlayWithLists.CreateOrderList(endWindow, orderList, imageList);
            Close();
            endWindow.Show();            
        }       

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            GetAnswers();                      
        }

        private void GetAnswers()
        {
            object[] answers = new object[3];
            lisAdd.Visibility = Visibility.Visible;
            answers[0] = AboutMenu1.SelectedIndex;
            answers[1] = Choose1.IsChecked;
            answers[2] = AboutMenu2.SelectedIndex == 0 ? true : false;

            foreach (Factory factory in factoryList)
            {
                if (factory.Name.IsEqual(MenuItem.Text))
                {
                    orderList.Add(factory.Create(answers));
                    imageList.Add(factory.Image);
                }
            }
        }

        private void FillWindow()
        {
            SetVisability(Visibility.Hidden);
            lEditParams1.Content = "";
            lEditParams2.Content = "";
            AboutMenu1.Items.Clear();
            AboutMenu2.Items.Clear();
            Choose1.IsChecked = false;
            Choose2.IsChecked = false;

            foreach (Factory factory in factoryList)
            {
                if (factory.Name.IsEqual(MenuItem.Text))
                {
                    MyImage.Source = new BitmapImage(new Uri(factory.Image));
                    string[] questions = factory.AskClient();
                    string[] answers1 = factory.Answer1();

                    lEditParams1.Content = questions[0];
                    for (Int32 i = 0; i < answers1.Length; i++)
                        AboutMenu1.Items.Add(answers1[i]);

                    lEditParams2.Content = questions[1];
                    string[] answers2 = factory.Answer2();
                    for (Int32 i = 0; i < answers2.Length; i++)
                        AboutMenu2.Items.Add(answers2[i]);
                    SetVisability(Visibility.Visible);
                }
            }
        }

        private void SetVisability(Visibility state)
        {
            lEditMenu.Visibility = state;
            lEditParams1.Visibility = state;
            lEditParams2.Visibility = state;
            bAdd.Visibility = state;
            AboutMenu1.Visibility = state;
            AboutMenu2.Visibility = state;
            pRadioButton.Visibility = state;
            MyImage.Visibility = state;
            btOrder.Visibility = state;
            lisAdd.Visibility = Visibility.Hidden;
        }
    }
}
