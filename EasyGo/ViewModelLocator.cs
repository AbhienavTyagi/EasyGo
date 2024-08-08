using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGo
{
    public class ViewModelLocator
    {
        /* // Create an instance of the SignUpViewModel
         private static SignUpViewModel _signUpViewModel = new SignUpViewModel();

         // Expose the SignUpViewModel instance
         public SignUpViewModel SignUpViewModel => _signUpViewModel;

         //public MainViewModel MainViewModel => new MainViewModel();

         // Optional: Method to clean up resources if needed
         public static void Cleanup()
         {
             _signUpViewModel = null;
         }*/

        
        
            // Example property to get a ViewModel instance
            public SignUpViewModel SignUpViewModel
            {
                get
                {
                    return new SignUpViewModel(); // or use dependency injection
                }
            }
        
    }
}




