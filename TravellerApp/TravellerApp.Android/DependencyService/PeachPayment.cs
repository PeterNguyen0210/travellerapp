using System;
using System.Threading.Tasks;
using TravellerApp.Droid.DependencyService;
using TravellerApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(PeachPayment))]

namespace TravellerApp.Droid.DependencyService
{
    public class PeachPayment : IPeachPayment
    {
        public void OpenPaymentUi(string CheckoutId)
        {
        }

        Task<bool> IPeachPayment.OpenPaymentUi(string CheckoutId)
        {
            throw new NotImplementedException();
        }
    }
}