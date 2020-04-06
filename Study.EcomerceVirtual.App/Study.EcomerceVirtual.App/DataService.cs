using Newtonsoft.Json;
using Study.EcomerceVirtual.App.Models;
using Study.EcomerceVirtual.App.Repositories;
using System.Collections.Generic;
using System.IO;

namespace Study.EcomerceVirtual.App
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext _context;
        private readonly IProdutoRepository _produtoRepository;

        public DataService(ApplicationContext context, IProdutoRepository produtoRepository)
        {
            _context = context;
            _produtoRepository = produtoRepository;
        }

        public void InicializarDB()
        {
            var livros = GetLivros();

            _context.Database.EnsureCreated();
            _produtoRepository.Salvar(livros);
        }

        private List<Livro> GetLivros()
        {
            List<Livro> livros;
            using (var fs = File.OpenText("livros.json"))
            {
                var json = fs.ReadToEnd();
                livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            }

            return livros;
        }
    }
}
