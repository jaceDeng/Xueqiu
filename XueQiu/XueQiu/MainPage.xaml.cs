using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XueQiu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            mainContent.ItemsSource = new ContentView[] { new View1(), new View2(), new View3() };
            mainContent.ItemTemplate = new DataTemplate(() =>
            { 
                return mainContent.CurrentItem;
            });
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}
