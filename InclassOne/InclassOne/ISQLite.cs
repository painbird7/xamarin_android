using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace InclassOne
{
    public interface ISQLite
    {
        string GetLocalFilePath(string fileName);
    }
}