using DataProvider;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var view = new View();
            var model = new Model();
            Controller control = new Controller(view, model);
            control.ShowView();
        }
    }
}
