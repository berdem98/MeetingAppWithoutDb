namespace MeetingApp.Models
{
	public static class Repository
	{
		private static List<UserInfo> _users = new();


		static Repository()
		{
			_users.Add(new UserInfo() { Id = 0, Name = " ", Email = " ", Phone = " ", KatilimDurumu = false });
			_users.Add(new UserInfo() {Id=1, Name="Beyza Bora",Email="beyza@gmail.com",Phone="555555",KatilimDurumu=true });
			_users.Add(new UserInfo() {Id=2, Name="Çoşkun Temenni",Email="coskun@gmail.com",Phone="535555",KatilimDurumu=false });
			_users.Add(new UserInfo() { Id=3, Name="İbrahim Aydın",Email="ibrahim@gmail.com",Phone="535545",KatilimDurumu=false });
			_users.Add(new UserInfo() { Id=4, Name="Oğuz Önal",Email="oguz@gmail.com",Phone="535553",KatilimDurumu=true });
			_users.Add(new UserInfo() { Id=5, Name="Deniz Kuğu",Email="deniz@gmail.com",Phone="455555",KatilimDurumu=true });
		}
		public static List<UserInfo> Users { 
			get 
			{ 
				return _users; 
			} 
		}

		public static void CreateUser(UserInfo user)
		{
			user.Id=Users.Count+1;
			_users.Add(user);
		}

		public static UserInfo? GetById(int id)
		{
		return _users.FirstOrDefault(e=>e.Id==id) ?? _users.FirstOrDefault(e => e.Id == 0) ;
		}
	}
}
