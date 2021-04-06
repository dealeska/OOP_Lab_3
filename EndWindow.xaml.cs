﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using OOP_Lab_1;


namespace OOP_Lab_2
{
    /// <summary>
    /// Логика взаимодействия для EndWindow.xamlм
    /// </summary>  
    public partial class EndWindow : Window
    {
        public List<OOP_Lab_1.MenuItem> orderList = new List<OOP_Lab_1.MenuItem>();
        private List<string> imageList = new List<string>();
        BinaryFormatter formatter = new BinaryFormatter();

        public EndWindow(List<OOP_Lab_1.MenuItem> item, List<string> image)
        {
            InitializeComponent();
            this.orderList = item;
            this.imageList = image;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            imageList.RemoveAt(listBox.SelectedIndex);
            orderList.RemoveAt(listBox.SelectedIndex);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            listBox.Items.Clear();
            PlayWithLists.CreateOrderList(this, orderList, imageList);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, orderList);
            }            
                       
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                List<OOP_Lab_1.MenuItem> newPerson = (List<OOP_Lab_1.MenuItem>)formatter.Deserialize(fs);
                listBox.Items.Clear();
                for (Int32 i = 0; i < newPerson.Count; i++)
                {
                    imageList.Add(newPerson[i].Image);
                    orderList.Add(newPerson[i]);
                }
                PlayWithLists.CreateOrderList(this, orderList, imageList);
            }

        }
    }
}
