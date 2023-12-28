using System.ComponentModel.DataAnnotations;

namespace GEVS_Backend.Entities
{
	public class OfficerEntity
	{
        [Key]
        public long OfficerId { get; set; }  // election@shangrila.gov.sr
        public string? Password { get; set; } // shangrila2024$
    }
}

