namespace MeetingApp.Models
{
	public class Repository
	{
		private static List<UserInfo> _users = new List<UserInfo>();

		static Repository()
		{
			_users.Add(new UserInfo() { Id=1   ,Name= "Ali", Email="abc@abc.com",Phone="1234541236",WillAttend=true});
			_users.Add(new UserInfo() { Id=2   ,Name= "Veli", Email="asdf@abc.com",Phone="12345612412",WillAttend=true});
			_users.Add(new UserInfo() { Id=3   ,Name="Kerem", Email="aqw@abc.com",Phone="1234512363",WillAttend=false});
		}
		public static List<UserInfo> Users
		{
			get
			{
				return _users;
			}
		}

		public static void AddUser(UserInfo user)
		{
			user.Id = Users.Count + 1;
			_users.Add(user);
		}

		public static UserInfo? GetById(int id)
		{
			return _users.FirstOrDefault(user => user.Id == id);
		}
	}
}
