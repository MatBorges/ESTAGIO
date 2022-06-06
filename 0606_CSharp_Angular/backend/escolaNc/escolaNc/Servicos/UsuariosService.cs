using escolaNc.Data;
using escolaNc.Excecoes;
using escolaNc.Interfaces;
using escolaNc.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escolaNc.Servicos
{
    public class UsuariosService : IUsuariosService
    {
        private EscolaContext _context;

        public UsuariosService(EscolaContext context){
            _context = context; 
        }
        public Usuario AtualizaUsuario(Usuario usuario){
            if (!_context.USUARIOS.Any(u => u.cpf == usuario.cpf)){
                throw new Excecao("Usuário não encontrado no banco de dados");
            }
            try{
                _context.USUARIOS.Update(usuario);
                _context.SaveChanges();
                return usuario;
            }
            catch (Exception)
            {
                throw new Excecao($"Não foi possivel encontrar o usuário com o CPF:{usuario.cpf} no banco de dados");
            }
        }

        public Usuario InsereUsuario(Usuario usuario){
            try
            {
                _context.USUARIOS.Add(usuario);
                _context.SaveChanges();
                return usuario;
            }
            catch (System.Exception)
            {

                throw new Excecao($"O usuário com o cpf {usuario.cpf} ja existe na base de dados");
            }
        }

        public bool RemoveUsuario(string cpf){
            if (!_context.USUARIOS.Any(u => u.cpf == cpf))
            {
                throw new Excecao("Usuário não encontrado no banco de dados");
            }

            try
            {
                var usuario = _context.USUARIOS.Find(cpf);

                _context.USUARIOS.Remove(usuario);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Usuario> RetornaUsuario(){
            try{
                return _context.USUARIOS.ToList();
            }
            catch (System.Exception){

                throw new Excecao("Não foi possivel acessar o banco de dados");
            }            
        }
    }
}
