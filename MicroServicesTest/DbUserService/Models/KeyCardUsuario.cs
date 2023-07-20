using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbUserService.Models
{
    [Table("KeyCardUsuario")]
    public class KeyCardUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR(100)")]
        public string Serial { get; set; }

        [Column(Order = 3, TypeName = "MONEY")]
        public decimal Balance { get; set; }

        [Column(Order = 4, TypeName = "INT")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
