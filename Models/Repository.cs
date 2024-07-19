namespace MeetingApp.Models
{
	public class Repository
	{
		private static List<UserInfo> _users = new List<UserInfo>();

		static Repository()
		{
			_users.Add(new UserInfo() { Name= "Ali", Email="abc@abc.com",Phone="1234541236",WillAttend=true});
			_users.Add(new UserInfo() { Name= "Veli", Email="asdf@abc.com",Phone="12345612412",WillAttend=true});
			_users.Add(new UserInfo() { Name="Kerem", Email="aqw@abc.com",Phone="1234512363",WillAttend=false});
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
			_users.Add(user);
		}
	}
}
