using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace application_performance_optimization.Entities
{
    [Table("tb_user")]
    public class UserEntity
    {
        [Key]
        [Column("pk_id")]
        public int Id { get; set; }

        [Required]
        [Column("ds_name")]
        public string Name { get; set; }

        [Column("nr_age")]
        public int Age { get; set; }
    }
}
