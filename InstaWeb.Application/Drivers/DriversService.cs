namespace InstaWeb.Application.Drivers
{
    public interface IDriversService
    {
        public Task CreateDriver(string name, string surname);
    }

    class DriversService : IDriversService
    {
        private readonly IDriversRepository driversRepository;

        public DriversService(IDriversRepository driversRepository)
        {
            this.driversRepository = driversRepository;
        }
        public async Task CreateDriver(string name, string surname)
        {
            var driver = new Driver
            {
                Name = name,
                Surname = surname
            };

            await driversRepository.Create(driver);

        }
    }
}
