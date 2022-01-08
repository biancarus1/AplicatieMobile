using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectAle.Models;

namespace ProiectAle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var rlist = (Programari)BindingContext;
            rlist.Date = DateTime.UtcNow;
            await App.Database.SaveProgramariAsync(rlist);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var rlist = (Programari)BindingContext;
            await App.Database.DeleteProgramariAsync(rlist);
            await Navigation.PopAsync();
        }
    }
}