using System;
using System.Collections.Generic;
using System.ComponentModel;
using DudleyApp.Models;
using DudleyApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DudleyApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}