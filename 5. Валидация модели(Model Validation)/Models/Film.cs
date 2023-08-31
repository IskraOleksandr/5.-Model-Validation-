using System.ComponentModel.DataAnnotations;

namespace _5._Валидация_модели_Model_Validation_.Models
{
	public class Film
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Поле должно быть установлено.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
		[Display(Name = "Название")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Поле должно быть установлено.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
		[Display(Name = "Режиссер")]
		public string Director { get; set; }

		[Required(ErrorMessage = "Поле должно быть установлено.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 3 до 70 символов")]
		[Display(Name = "Жанр")]
		public string Genre { get; set; }

		[Required(ErrorMessage = "Поле должно быть установлено.")]
		[Range(1900, 2023)]
		[Display(Name = "Год выпуска")]
		public int Year { get; set; }


		public string? PosterPath { get; set; }

		[Required(ErrorMessage = "Поле должно быть установлено.")]
		[StringLength(400, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 400 символов")]
		[Display(Name = "Описа")]
		public string Description { get; set; }
	}
}