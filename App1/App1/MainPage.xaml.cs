using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Margin = 40
            };

            Label label = new Label
            {
                Text = "Hola, presione el Botón",
                FontSize = 20
            };

            Button button = new Button
            {
                Text = "El Botón"
            };

            stackLayout.Children.Add(label);
            stackLayout.Children.Add(button);

            this.Content = stackLayout;

            button.Clicked += OnButtonClick;

        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            DisplayAlert("Hola", "Ha presionado el botón", "Ok");
        }
    }
}
