namespace _5._Валидация_модели_Model_Validation_.Models
{
	public class Film
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Director { get; set; }
		public string Genre { get; set; }
		public int Year { get; set; }
		public string? PosterPath { get; set; }
		public string Description { get; set; }
	}
}