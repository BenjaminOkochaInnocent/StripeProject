using Stripeproject.Resources;

namespace Stripeproject.Services
{
    public interface IStripeService
    {
        Task<CustomerResource> CreateCustomer(CreateCustomerResource resource, CancellationToken cancellationToken);
        Task<ChargeResource> CreateCharge(CreateChargeResource resource, CancellationToken cancellationToken);
    }
}
