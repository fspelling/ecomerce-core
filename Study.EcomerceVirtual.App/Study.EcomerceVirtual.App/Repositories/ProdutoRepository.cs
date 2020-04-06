﻿using Study.EcomerceVirtual.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.EcomerceVirtual.App.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext _context;

        public ProdutoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Produto> Listar() => _context.Set<Produto>().ToList();

        public void Salvar(List<Livro> livros)
        {
            foreach (var livro in livros)
                _context.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));

            _context.SaveChanges();
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
