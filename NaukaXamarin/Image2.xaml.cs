﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaukaXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Image2 : ContentPage
    {
        public Image2()
        {
            InitializeComponent();

            //image.Source = ImageSource.FromResource("img.png");
        }
    }
}