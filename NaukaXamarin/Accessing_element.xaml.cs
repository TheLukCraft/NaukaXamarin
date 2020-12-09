using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaukaXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accessing_element : ContentPage
    {
        public Accessing_element()
        {
            InitializeComponent();
            slider.Value = 0;
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = string.Format("wartość się zmienia {0:F2}", e.NewValue);
        }
    }
}