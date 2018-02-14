using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms;

namespace App11
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var databasePath = DependencyService.Get<IFilePath>().GetFilePath("mydb.db");

            try
            {
                using (var db = new myContext(databasePath))
                {
                    db.Database.Migrate();

                    var fido = new Dog
                    {
                        Age = 7,
                        Name = "Fido",
                      
                        NEWPROPERTYVIAMIGRATE = "worked?"
                    };

                    db.Dogs.Add(fido);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {

            }

            MainPage = new App11.MainPage();
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
