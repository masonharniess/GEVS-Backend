using System.ComponentModel.DataAnnotations;

namespace GEVS_Backend.Entities
{
	public class VoterEntity
	{
        [Key]
        public long VoterId { get; set; }  // email
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public long? UniqueVoterCode { get; set; }
    }
}

