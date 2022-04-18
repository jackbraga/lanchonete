using System.Data;
using System.Data.SqlClient;

namespace LanchoneteUDV.Infra.Data
{
    public class DefaultSqlConnectionFactory : IConnectionFactory
    {
        public IDbConnection Connection()
        {
            return new SqlConnection("Data Source=.\\Sqlexpress;Initial Catalog=LANCHONETE;Integrated Security=True");
        }
    }
}
