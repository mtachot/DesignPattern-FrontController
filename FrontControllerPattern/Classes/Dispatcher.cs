using FrontControllerPattern.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontControllerPattern.Classes
{
    public class Dispatcher
    {
        private HomeView homeView;
        private StudentView studentView;
        
        public Dispatcher()
        {
            this.homeView = new HomeView();
            this.studentView = new StudentView();
        }

        public void dispatch(string request)
        {
            if (String.Compare(request.ToUpper(), "SUDENT") == 0)
                studentView.Show();
            else
                homeView.Show();
        }
    }
}
