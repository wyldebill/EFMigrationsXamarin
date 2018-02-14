using System;
using System.Collections.Generic;
using System.Text;

namespace App11
{

    // you define the interface in the shared/pcl project, but you implement it in the 
    // droid/ios project WITH THE DEPENDENCY ATTRIBUTE!
    public interface IFilePath
    {
        string GetFilePath(string filename);
    }
}
