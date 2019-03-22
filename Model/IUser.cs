namespace SchedulerX.Model
{
    public interface IUser
    {
        int ID { get; set; }
        string Login { get; set; }
        string Password { get; set; }
    }
}