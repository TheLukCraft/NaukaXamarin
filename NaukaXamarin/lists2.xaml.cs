using NaukaXamarin.Models;
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
    public partial class lists2 : ContentPage
    {
        public lists2()
        {
            InitializeComponent();

            listView2.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Mosh", ImageUrl= "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "Mosh", ImageUrl= "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk"},
            };
        }


    }
}