using System.Linq;
using Nishaan.Gym.Model;
using Nishaan.Gym.ViewModel;

namespace Nishaan.Gym.Interface
{
    public interface IPaymentDetails
    {
        IQueryable<PaymentDetailsViewModel> GetAll(QueryParameters queryParameters, int userId);
        int Count(int userId);
        bool RenewalPayment(RenewalViewModel renewalViewModel);
    }
}