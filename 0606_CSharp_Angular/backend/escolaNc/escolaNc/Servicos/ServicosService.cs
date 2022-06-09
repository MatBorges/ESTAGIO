using escolaNc.Data;
using escolaNc.Interfaces;
using escolaNc.Modelos;
using escolaNc.Excecoes;
using System.Collections.Generic;
using System.Linq;

namespace escolaNc.Servicos
{
    public class ServicosService : IServicosService
    {
        private EscolaContext _context;

        public ServicosService(EscolaContext context)
        {
            _context = context;
        }

        public List<Servico> RetornaServicos()
        {
            try
            {
                return _context.SERVICOS.ToList();
            }
            catch (System.Exception)
            {
                throw new Excecao("Não foi possível acessar a base de dados");
            }
        }

        public Servico InsereServico(Servico servico)
        {
            try
            {
                _context.SERVICOS.Add(servico);
                _context.SaveChanges();
                return servico;
            }
            catch 
            {
                throw new Excecao($"O serviço com o id {servico.id} já existe na base de dados");
            }
        }

        public Servico AtualizaServico(Servico servico)
        {
            if (!_context.SERVICOS.Any(u => u.id == servico.id))
                throw new Excecao("Serviço não encontrado no banco de dados");

            try
            {
                _context.SERVICOS.Update(servico);
                _context.SaveChanges();
                return servico;
            }
            catch (System.Exception)
            {
                throw new Excecao("Não foi possível atualizar o usuário na base de dados");
            }
        }

        public bool RemoveServico(int id)
        {
            if (!_context.SERVICOS.Any(u => u.id == id))
                throw new Excecao("Serviço não encontrado no banco de dados");

            try
            {
                var servico = _context.SERVICOS.Find(id);

                _context.SERVICOS.Remove(servico);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw new Excecao($"Não foi possível remover o servico de id {id} da base de dados");
            }
        }

    }
}