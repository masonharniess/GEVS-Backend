namespace GEVS_Backend.Models
{
	public class VoterModel
	{
		public required String VoterId { get; set; }  // email
		public string? Password { get; set; }
		public string? FullName { get; set; }
		public DateOnly? DateOfBirth { get; set; }
		public long? UniqueVoterCode { get; set; }
	}
}

