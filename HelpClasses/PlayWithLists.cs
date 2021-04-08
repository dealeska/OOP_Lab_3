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
            endWindow.listBox.Items.Clear();
            for (Int32 i = 0; i < orderList.Count; i++)
            {
                AddObjectToList(endWindow, orderList[i], imageList[i], i + 1);
            }
            endWindow.lCost1.Content = (CountCost(orderList)).ToString();
        }

        public static void AddObjectToList(EndWindow window, OOP_Lab_1.MenuItem itm, string image, Int32 element)
        {
            StackPanel stackPanel = new StackPanel { Width = 600, Height = 99 };
            stackPanel.Orientation = Orientation.Horizontal;
            try
            {
                stackPanel.Children.Add(new Image
                {
                    Source = new BitmapImage(new Uri(image)),
                    Width = 130,
                    Stretch = System.Windows.Media.Stretch.Fill,
                    Height = 90
                }); 
            }
            catch
            {
                MessageBox.Show("Loading image error");
            }

            Label label = new Label { Width = 600, Height = 99 };
            label.Content = element.ToString() + ". " + itm.WriteDescription();

            stackPanel.Children.Add(label);
            window.listBox.Items.Add(stackPanel);
        }

        private static float CountCost(List<OOP_Lab_1.MenuItem> order)
        {
            float sum = 0;
            for (Int32 i = 0; i < order.Count; i++)
                sum += order[i].Cost;

            return sum;
        }
    }
}
