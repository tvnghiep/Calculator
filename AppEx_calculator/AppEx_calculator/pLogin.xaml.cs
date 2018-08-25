using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEx_calculator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pLogin : ContentPage
	{
		public pLogin ()
		{
			InitializeComponent ();
		}

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (txtUserName.Text == "sa")
            {
                App.Current.MainPage = new NavigationPage( new pList());
            }
            else
            {
                DisplayAlert("Lỗi", "Không tìm thấy user: " + txtUserName.Text, "OK");
            }
        }
    }
}