using AuthenticationAndAutherization.Model;

namespace AuthenticationAndAutherization.Repositories
{
    public class CustomerRepository
    {
        private readonly Dictionary<Guid, Customer> _customer = new();

        public void Create (Customer customer)
        {
            if(customer == null)
            {
                return;
            }
        }
    }
}
