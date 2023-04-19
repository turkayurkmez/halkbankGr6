using eshop.Entities;

namespace eshop.Application
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>()
        {
            new User{ Id=1, Name="türkay", UserName="turkay", Password="123", Role="Admin", Email="a@b.com"},
            new User{ Id=2, Name="Seda", UserName="seda", Password="123", Role="Editor", Email="a@b.com"},
            new User{ Id=3, Name="Murat", UserName="murat", Password="123", Role="Client", Email = "a@b.com"},

        };
        public User ValidateUser(string username, string password)
        {
            return _users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
