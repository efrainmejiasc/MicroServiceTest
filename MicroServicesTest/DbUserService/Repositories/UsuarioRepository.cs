using DbUserService.IRepositories;
using DbUserService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUserService.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DbUserContext _dbUserContext;
        public UsuarioRepository(DbUserContext dbUserContext)
        {
            this._dbUserContext = dbUserContext;
        }

        public async Task<Usuario> AddUsuarioAsync(Usuario x)
        {
            await this._dbUserContext.Usuario.AddAsync(x);
            await this._dbUserContext.SaveChangesAsync();

            return x;
        }

        public Usuario GetUsuario(string key)
        {
            return this._dbUserContext.Usuario.Where(x => x.KeyUsuario == key).FirstOrDefault();
        }

        public async Task<Usuario> UpdateUsuarioAsync(Usuario x)
        {
            var usuario = await this._dbUserContext.Usuario.FindAsync(x.Id);

            if (usuario != null)
            {
                usuario.Nombre = x.Nombre;
                usuario.Apellido = x.Apellido;
                usuario.TipoDocumento = x.TipoDocumento;
                usuario.Documento = x.Documento;
                usuario.KeyUsuario = x.KeyUsuario;

                await this._dbUserContext.SaveChangesAsync();
            }

            return usuario;
        }

        public async Task<bool> DeleteUsuarioAsync(int userId)
        {
            var result = false;
            var usuario = await this._dbUserContext.Usuario.FindAsync(userId);

            if (usuario != null)
            {
                this._dbUserContext.Usuario.Remove(usuario);
                await this._dbUserContext.SaveChangesAsync();
                result = true; 
            }

            return result;
        }
    }
}
