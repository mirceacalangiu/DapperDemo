using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace DapperDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string SqlString = "SELECT TOP 1000[ID],[Name],[OwnerID]FROM[SlackDB].[dbo].[companies]";
            var companies = (List<Companies>)db.Query<Companies>(SqlString);

            foreach (var company in companies)
            {
                Console.WriteLine(company.Name);
                Console.WriteLine(company.ID);
                        
            }

            Console.ReadLine();

        }
}
}