using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using InclassOne.Droid;
using Xamarin.Forms;
using System.IO;
using SQLite;


[assembly: Dependency(typeof(LocalFileHelper))]
namespace InclassOne.Droid
{
    public class LocalFileHelper : ISQLite
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "Contacts");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, fileName);
        }
    }
}