using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Windows;

namespace OOP_Lab_2
{
    static class PlayWithLists
    {
        public static void CreateOrderList(EndWindow endWindow, List<OOP_Lab_1.MenuItem> orderList, List<string> imageList)
        {           

            for (Int32 i = 0; i < orderList.Count; i++)
            {
                AddObjectToList(endWindow, orderList[i], imageList[i], i + 1);
            }
        }

        public static void AddObjectToList(EndWindow window, OOP_Lab_1.MenuItem itm, string image, Int32 element)
        {
            StackPanel stackPanel = new StackPanel { Width = 700, Height = 99 };
            stackPanel.Orientation = Orientation.Horizontal;
            try
            {
                stackPanel.Children.Add(new Image
                {
                    Source = new BitmapImage(new Uri(image)),
                    Width = 120,
                    Stretch = System.Windows.Media.Stretch.Fill,
                    Height = 70
                }); ;
            }
            catch
            {
                MessageBox.Show("Loading image error");
            }

            Label label = new Label { Width = 700, Height = 99 };
            label.Content = element.ToString() + ". " + itm.WriteDescription();

            stackPanel.Children.Add(label);
            window.listBox.Items.Add(stackPanel);
        }
    }
}
