using System.Reflection;

namespace MeetingApp.Models
{
	public class MeetingInfo
	{
		public int Id { get; set; }
		public string? Konum { get; set; }
		public DateTime Tarih { get; set; }
		public int KatilimSayisi { get; set; }
	}
}
