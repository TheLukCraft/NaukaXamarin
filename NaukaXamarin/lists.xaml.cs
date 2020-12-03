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
    public partial class lists : ContentPage
    {
        public lists()
        {
            InitializeComponent();

            var names = new List<string>
            {
                "Lukasz",
                "Wiktoria",
                "Janusz"
            };

            listView.ItemsSource = names;
        }
    }
}