using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InclassOne
{
	public partial class App : Application
	{
        static ContactDatabase database;

		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new FormsMenuPage());
		}

        public static ContactDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new ContactDatabase(DependencyService.Get<ISQLite>().GetLocalFilePath("ContactDB.db3"));
                }
                return database;
            }
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
