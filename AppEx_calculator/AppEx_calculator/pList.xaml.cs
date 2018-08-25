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
	public partial class pList : ContentPage
	{
        List<clsDoctors> doctors;

		public pList ()
		{
			InitializeComponent ();

            doctors = new List<clsDoctors>()
            {
                new clsDoctors(){Name= "Nguyen Van A",Title= "bac si",Address= "228 bis", PhoneNumber= "0123", Image ="http://file.vforum.vn/hinh/2016/08/hinh-anh-binh-minh-dep-nhat-lang-man-2.jpg" },
                new clsDoctors(){Name= "Nguyen Van B",Title= "y si",Address= "230", PhoneNumber= "0125" , Image ="http://file.vforum.vn/hinh/2016/08/hinh-anh-binh-minh-dep-nhat-lang-man-2.jpg"}
            };

            lvDoctors.ItemsSource = doctors;
        }

        

        protected void OnAppearing()
        {
            base.OnAppearing();

            
        }

        private void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new pList_sub((clsDoctors)e.Item  ));
            Navigation.PushAsync(new pList_sub((clsDoctors)e.Item));
        }
    }
}