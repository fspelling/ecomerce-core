using Study.EcomerceVirtual.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.EcomerceVirtual.App.Repositories
{
    public interface IProdutoRepository
    {
        void Salvar(List<Livro> produto);
        List<Produto> Listar();
    }
}
