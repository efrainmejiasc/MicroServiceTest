using DbUserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUserService.IRepositories
{
    public interface IUsuarioRepository
    {
        Usuario GetUsuario(string key);
        Task<Usuario> AddUsuarioAsync(Usuario x);
        Task<bool> DeleteUsuarioAsync(int userId);
        Task<Usuario> UpdateUsuarioAsync(Usuario x);
    }
}
