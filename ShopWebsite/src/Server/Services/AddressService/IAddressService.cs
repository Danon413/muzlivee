namespace ShopWebsite.Server.Services.AddressService
{
    public interface IAddressService
    {
        Task<ServiceResponse<Address>> AddOrUpdateAddress(Address address);
        Task<ServiceResponse<Address>> GetAddress();
    }
}
