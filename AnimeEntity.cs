using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JikanApiExample.Data
{
    public class AnimeEntity
    {
        [Key]
        public int Id { get; set; }

        [Column("MalId")]
        public int MalId { get; set; }

        [Column("Rank")]
        public int? Rank { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Score")]
        public double Score { get; set; }
    }
}