using System;
using Nishaan.Gym.ViewModel;

namespace Nishaan.Gym.Interface
{
    public interface IRenewal
    {
        RenewalViewModel GetMemberNo(string memberNo, int userid);
        bool CheckRenewalPaymentExists(DateTime newdate, long memberId);
    }
}