using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
	public class UserInfo
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Ad Soyad Zorunlu Alandır")]
		public string? Name { get; set; } //null
		[Required(ErrorMessage = "Email Adresi zorunlu alandır")]
		[EmailAddress(ErrorMessage ="Email Formatı yanlış")]
		public string? Email { get; set; }
		[Required(ErrorMessage = "Telefon zorunlu alandır")]
		public string? Phone { get; set; }
		[Required(ErrorMessage = "Katılım durumunu seçiniz")]
		public bool? KatilimDurumu { get; set; } // true, false ve null
	}
}
