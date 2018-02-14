using System;
using System.IO;
using Xamarin.Forms;
using Todo.Droid;
using App11;


// this will register the class with xamarin dependency service thingee
// so shared, pcl projects can access this now.
// normally, the shared/pcl projects cannot access the device specific ios/android projects types
// but some things, like getting a file path on the devices storage are device specific (shared/pcls have no access to the devices storage)
// nuget packages like pclstorage though can provide this - but they do it basically like we are here i think

[assembly: Dependency(typeof(FileHelper))]
namespace Todo.Droid
{
    public class FileHelper : IFilePath
    {
        public string GetFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path =  Path.Combine(path, filename);
            return path;
        }
    }
}