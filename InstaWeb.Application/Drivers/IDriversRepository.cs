namespace InstaWeb.Application.Drivers
{
    public interface IDriversRepository 
    {
        public Task Create(Driver driver);
    }
}
