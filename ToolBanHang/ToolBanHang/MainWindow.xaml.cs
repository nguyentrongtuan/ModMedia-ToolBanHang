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

namespace ToolBanHang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<int> List_ListView = new List<int>();
        public class MyItem
        {
            public int Id { get; set; }

            public string Col2 { get; set; }
            public string Col3 { get; set; }
            public string Col4 { get; set; }
            public string Col5 { get; set; }
            public string Col6 { get; set; }
        }

        public class ItemDemo
        {
            public string Col1 { get; set; }
            public string Col2 { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();

            
        }



        

        private void Button_Create_ListView_Click(object sender, RoutedEventArgs e)
        {
            int listview_id = List_ListView.Count + 1;

            Button MyControl1 = new Button();
            MyControl1.Content = "Xoa " + listview_id.ToString();
            MyControl1.Name = "Button_" + listview_id.ToString();
            MyControl1.Height = 30;
            MyControl1.HorizontalAlignment = HorizontalAlignment.Right;
            MyControl1.VerticalAlignment = VerticalAlignment.Top;
            MyControl1.Click += new RoutedEventHandler(Click_delete_ListView);


            ListView listView = new ListView();
            listView.Name = "ListView_"+ listview_id.ToString();


            List_ListView.Add(1);

            var gridView = new GridView();
            listView.View = gridView;
            
            listView.Name = "ListView_" + listview_id.ToString();
            listView.Margin = new System.Windows.Thickness { Top = MyControl1.Height, Left = 0, Right = 0, Bottom = 0 };

            


            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Col1",
                Width = 120,
                DisplayMemberBinding = new Binding("Col1")
            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Col2",
                Width = 120,
                DisplayMemberBinding = new Binding("Col2")
            });

            List<ItemDemo> items = new List<ItemDemo>();
            items.Add(new ItemDemo() { Col1 = "John Doe Col1 " + listview_id.ToString(), Col2 = "john@doe-family1.com" });
            items.Add(new ItemDemo() { Col1 = "Jane Doe Col2 " + listview_id.ToString(), Col2 = "jane@doe-family2.com" });
            listView.ItemsSource = items;

            Grid grid = new Grid();
            grid.Margin = new System.Windows.Thickness { Top = 35, Left = 0, Right = 0, Bottom = 0 };
            grid.Children.Add(listView);
            grid.Children.Add(MyControl1);
            grid.Name = "grid_listview_" + listview_id.ToString();

            StackPanel_1.Children.Add(grid);

        }

        private void Click_delete_ListView(object sender, EventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((Button)sender).Parent;
            StackPanel_1.Children.RemoveAt(StackPanel_1.Children.IndexOf(parent));
        }

    }
}
