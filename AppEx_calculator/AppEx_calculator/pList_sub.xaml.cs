using Plugin.Messaging;
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
	public partial class pList_sub : ContentPage
	{
        clsDoctors pDoctor;

        public pList_sub(clsDoctors doctor )
        {
            InitializeComponent();

            pDoctor = doctor;

            lblName.Text = pDoctor.Name;
            lblTitle.Text = pDoctor.Title ;
            lblPhoneNumber.Text = pDoctor.PhoneNumber ;
            lblAddress.Text = pDoctor.Address ;
            img1.Source = new Uri(pDoctor.Image);
        }

        public pList_sub ()
		{
			InitializeComponent ();
		}

        private void PhoneClicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+123");
        }

        private void MsgClicked(object sender, EventArgs e)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms("+123", "Well hello there from Xam.Messaging.Plugin");
        }
    }
}