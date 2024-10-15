using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Client2.Repository
{
    public class DogGenericRepository<T> : IDogGenericRepository<T> where T : class
    {
        IDbConnection connection;
        private object p;
        private object _connection;
        readonly string connectionString = "SERVER=(LocalDb)\\MSSQLLocalDb; Database=master; Trusted_Connection=True; MultipleActiveResultSets=true ";
        public DogGenericRepository()
        {
            connection = new SqlConnection(connectionString);
        }

        public T GetbyId(int id)
        {
            return null;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }



        public bool Add(T Entity)
        {
            string tableName = GetTableName();
            string columns = GetColumnNames(true);
            string values = GetColumnValues(true);
            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values}) ";

            int affectedRow = 0;
            affectedRow = connection.Execute(query, Entity);

            return affectedRow == 1;

        }




        public bool Update(T Entity)
        {
            string tableName = GetTableName();
            string columns = GetColumnNames(true);
            string values = GetColumnValues(true);
            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values}) ";

            int affectedRow = 0;
            affectedRow = connection.Execute(query, Entity);

            return affectedRow == 1;
        }

        public bool Delete(T Entity)
        {
            string tableName = GetTableName();
            string columns = GetColumnNames(true);
            string values = GetColumnValues(true);
            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values}) ";

            int affectedRow = 0;
            affectedRow = connection.Execute(query, Entity);

            return affectedRow == 1;
        }

        public string GetTableName()
        {
            string tableName = "";
            var type = typeof(T);
            var tableAttr = type.GetCustomAttribute<TableAttribute>();
            if (tableAttr != null)
            {
                tableName = $"[{tableAttr.Name}]";
            }

            return tableName;
        }

        public string GetColumnNames(bool excludeKey = true)
        {
            string columnNames = "";
            var type = typeof(T);
            var columns = string.Join(",", type.GetProperties()
                .Where(p => !excludeKey || !p.IsDefined(typeof(KeyAttribute)))
                .Select(p =>
                {
                    var columnAttr = p.GetCustomAttribute<ColumnAttribute>();
                    return columnAttr != null ? columnAttr.Name : p.Name;
                }));
            return columns;
        }

        public string GetColumnValues(bool excludeKey = true)
        {
            var columnValues = typeof(T).GetProperties()
            .Where(p => !excludeKey || p.GetCustomAttribute<KeyAttribute>() == null);
            var values = string.Join(",", columnValues.Select(p =>
            {
                return $"@{p.Name}";
            }));

            return values;
        }
    }
}
    