using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Steam
{
    internal class User
    {
        string name;
        double accountBalance;
        int age;
        List<App> appList;
    }
}
