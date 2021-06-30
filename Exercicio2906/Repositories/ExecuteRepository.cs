using Exercicio2906.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2906.Repositories
{
    public abstract class ExecuteRepository<T>
    {
        public abstract void Inserir(T obj);
        public abstract void Excluir(T obj);
        public abstract void Atualizar(T obj);
        public abstract List<T> Consultar();
    }
}
