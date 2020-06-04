using System;
using ProcessamentoAutomatizado.Entities;
namespace ProcessamentoAutomatizado.Services
{
    public interface IOnlinePaymentService 

    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
