using System;
using escolaNc.Data;
using escolaNc.Interfaces;
using escolaNc.Modelos;
using escolaNc.Excecoes;
using System.Collections.Generic;
using System.Linq;


namespace escolaNc.Servicos {
    public class ContratacaoService : IContratacaoService {
        private EscolaContext _context;

        public ContratacaoService(EscolaContext context) {
            _context = context;
        }


        public List<Detalhes> ContratadosCpf(string cpf) {
            if (!_context.USUARIOS.Any(u => u.cpf == cpf))
                throw new Excecao($"CPF {cpf} não encontrado");

            List<Detalhes> detalhes = new List<Detalhes>();

            var consulta = from c in _context.SERVICOS_CONTRATADOS
                           join u in _context.USUARIOS
                           on c.cpf_usuario equals u.cpf
                           join s in _context.SERVICOS
                           on c.id_servico equals s.id
                           where c.cpf_usuario == cpf
                           select new {
                               u.nome,
                               u.cpf,
                               s.descricao,
                               s.preco,
                               c.dt_contratacao
                           };

            foreach (var c in consulta) {
                detalhes.Add(new Detalhes {
                    nome = c.nome,
                    cpf_usuario = c.cpf,
                    descricao = c.descricao,
                    preco = c.preco,
                    dt_contratacao = c.dt_contratacao
                });
            }

            if (detalhes.Count == 0) {
                var cliente = _context.USUARIOS.FirstOrDefault(u => u.cpf == cpf);
                detalhes.Add(new Detalhes { nome = cliente.nome, cpf_usuario = cliente.cpf });
            }

            return detalhes;
        }

        public bool ContrataServicos(List<Contratados> lista) {
            throw new NotImplementedException();
        }

        public List<Detalhes> RetornaContratados() {
            List<Detalhes> detalhes = new List<Detalhes>();

            var consulta = from c in _context.SERVICOS_CONTRATADOS
                           join u in _context.USUARIOS
                           on c.cpf_usuario equals u.cpf
                           join s in _context.SERVICOS
                           on c.id_servico equals s.id
                           select new {
                               u.nome,
                               u.cpf,
                               s.descricao,
                               s.preco,
                               c.dt_contratacao
                           };

            foreach (var c in consulta) {
                detalhes.Add(new Detalhes {
                    nome = c.nome,
                    cpf_usuario = c.cpf,
                    descricao = c.descricao,
                    preco = c.preco,
                    dt_contratacao = c.dt_contratacao
                });
            }
            return detalhes;
        }

        public List<Servico> RetornaServicos() {
            return _context.SERVICOS.ToList();
        }
    }
}