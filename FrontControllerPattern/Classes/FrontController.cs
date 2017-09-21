using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontControllerPattern.Classes
{
    public class FrontController
    {
        private Dispatcher dispatcher;

        public FrontController()
        {
            this.dispatcher = new Dispatcher();
        }

        private bool IsAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully");
            return true;
        }

        private void TrackRequest(string request)
        {
            Console.WriteLine(String.Format("Page requested : {0}", request.ToUpper()));
        }

        public void DispatchRequest(string request)
        {
            // Log each request
            TrackRequest(request);

            // Authenticate the user
            if (IsAuthenticUser())
                this.dispatcher.dispatch(request);
        }
    }
}
