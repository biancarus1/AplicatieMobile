using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectAle.Data;
using System.IO;

namespace ProiectAle
{
    public partial class App : Application
    {

        static ProgramariDatabase database;
        public static ProgramariDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProgramariDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Programari.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
        }

    }

}
