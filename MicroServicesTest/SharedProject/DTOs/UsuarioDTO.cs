using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string NombresApellidos { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public int? KeyCardUsuarioId { get; set; }
        public string KeyCardUsuario { get; set; }
    }
}
