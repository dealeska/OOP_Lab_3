using System;
using System.Collections.Generic;
using System.Windows;


namespace OOP_Lab_2
{
    /// <summary>
    /// Логика взаимодействия для EndWindow.xamlм
    /// </summary>  
    public partial class EndWindow : Window
    {
        private List<OOP_Lab_1.MenuItem> orderList = new List<OOP_Lab_1.MenuItem>();
        private List<string> imageList = new List<string>();
        private List<Factory> factoryList = new List<Factory>();

        public EndWindow(List<OOP_Lab_1.MenuItem> item, List<string> image, List<Factory> factoryList)
        {
            InitializeComponent();
            this.orderList = item;
            this.imageList = image;
            this.factoryList = factoryList;
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            imageList.RemoveAt(listBox.SelectedIndex);
            orderList.RemoveAt(listBox.SelectedIndex);
            PlayWithLists.CreateOrderList(this, orderList, imageList);
        }        

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow(factoryList, orderList, imageList);
            window.Show();
            Close();
        }       

        private void btChange_Click(object sender, RoutedEventArgs e)
        {
            for (Int32 i = 0; i < factoryList.Count; i++)
            {
                if (factoryList[i].Name.IsEqual(orderList[listBox.SelectedIndex].Name))
                {
                    EditWindow window = new EditWindow(this, factoryList, imageList, orderList, listBox.SelectedIndex);
                    FillEditWindow(window, i);
                }
            }
        }

        private void btXmlDeserialization_Click(object sender, RoutedEventArgs e)
        {
            ChangeOrderList(Deserialization.XmlDeserialize("order.xml"));
        }

        private void btBinDeserialization_Click(object sender, RoutedEventArgs e)
        {
            ChangeOrderList(Deserialization.BinDeserialize("order.dat"));
        }

        private void btSerialization_Click(object sender, RoutedEventArgs e)
        {
            Serialization.BinSerialize("order.dat", orderList);
            Serialization.XMLSerialize("order.xml", orderList);            
        }

        private void btPay_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void ChangeOrderList(List<OOP_Lab_1.MenuItem> order)
        {
            imageList.Clear();
            orderList.Clear();
            for (Int32 i = 0; i < order.Count; i++)
            {
                imageList.Add(order[i].Image);
                orderList.Add(order[i]);
            }
            PlayWithLists.CreateOrderList(this, orderList, imageList);
        }

        private void FillEditWindow(EditWindow wnd, Int32 index)
        {
            string[] questions = factoryList[index].AskClient();
            string[] answers1 = factoryList[index].Answer1();

            wnd.lEditParams1.Content = questions[0];
            for (Int32 j = 0; j < answers1.Length; j++)
                wnd.AboutMenu1.Items.Add(answers1[j]);

            wnd.lEditParams2.Content = questions[1];
            string[] answers2 = factoryList[index].Answer2();

            for (Int32 j = 0; j < answers2.Length; j++)
                wnd.AboutMenu2.Items.Add(answers2[j]);

            wnd.AboutMenu1.Text = wnd.AboutMenu1.Items[(Int32)factoryList[index].answers[0]].ToString();
            wnd.AboutMenu2.Text = (string)wnd.AboutMenu2.Items[(bool)factoryList[index].answers[2] ? 0 : 1];

            if ((bool)factoryList[index].answers[1])
                wnd.Choose1.IsChecked = true;
            else wnd.Choose2.IsChecked = true;

            wnd.lName.Content += factoryList[index].Name;

            wnd.Show();
        }
    }
}
