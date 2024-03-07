using InstaWeb.Application.Drivers;
using InstaWeb.Infrastructure.DAL.Entities;

namespace InstaWeb.Infrastructure.DAL.Repositories
{
    internal class DriversRepository : IDriversRepository
    {
        private readonly InstaWebDbContext instaWebDbContext;

        public DriversRepository(InstaWebDbContext instaWebDbContext)
        {
            this.instaWebDbContext = instaWebDbContext;
        }
        public async Task Create(Driver driver)
        {
            var entity = new DriverEntity
            {
                Name = driver.Name,
                Surname = driver.Surname
            };
            await instaWebDbContext.Drivers.AddAsync(entity);
        }
    }
}
