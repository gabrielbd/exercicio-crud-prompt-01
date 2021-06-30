using Exercicio2906.Entities;
using System;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2906.Repositories
{
    public class FuncionarioRepository : ExecuteRepository<Funcionario>
    {
        private string _connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Exercicio2906;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public override void Inserir(Funcionario obj)
        {
            var insert = @"
                            INSERT INTO FUNCIONARIO(
                            IDFUNCIONARIO,
                            NOME,
                            CPF,
                            MATRICULA,
                            DATAADMISSAO)
                            VALUES(
                            NEWID(),
                            @Nome,
                            @Cpf,
                            @Matricula,
                            @DataAdmissao)";
            using (var connection = new SqlConnection(_connection))
            {
                connection.Execute(insert, obj);
            }
        }

        public override void Atualizar(Funcionario obj)
        {
            var query = @"
                         UPDATE FUNCIONARIO
                         SET 
                             NOME = @Nome,
                             CPF  = @Cpf,
                        MATRICULA = @Matricula,
                     DATAADMISSAO = @DataAdmissao
                        WHERE 
                    IDFUNCIONARIO = @IdFuncionario";
            using (var connection = new SqlConnection(_connection))
            {
                connection.Execute(query, obj);
            }
        }

        public override List<Funcionario> Consultar()
        {
            var query = @"SELECT * FROM FUNCIONARIO
                           ORDER BY NOME";
            using (var connection = new SqlConnection(_connection))
            {
                return connection.Query<Funcionario>(query).ToList();
            }
        }

        public override void Excluir(Funcionario obj)
        {
            var query = @"DELETE FROM FUNCIONARIO
                         WHERE CPF = @Cpf";

            using (var connection = new SqlConnection(_connection))
            {
                connection.Execute(query, obj);
            }
        }


    }
}
