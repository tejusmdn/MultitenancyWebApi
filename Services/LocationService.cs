namespace MultitenancyWebApi.Services
{
    public class LocationService 
    {
        private readonly IConfiguration _configuration;

        public LocationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetServiceRegion()
        {
            return this._configuration.GetValue<string>("ServiceRegion");
        }
    }
}
