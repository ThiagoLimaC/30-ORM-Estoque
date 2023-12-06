using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace Database
{
    public class Base : IBase
    {
        private string ConnectionString = ConfigurationManager.AppSettings["SqlConnection"];

        /// <summary>
        /// Faz uma espécie de conversão de string pegando os tipos do C# e transformando e tipos SQL
        /// </summary>
        public string TipoPropriedade(PropertyInfo pi)
        {
            switch (pi.PropertyType.Name)
            {
                case "Int32":
                    return "INT";
                case "Int64":
                    return "BIGINT";
                case "Double":
                    return "DECIMAL(9,2)";
                case "Single":
                    return "FLOAT";
                case "DateTime":
                    return "DATETIME";
                case "Boolean":
                    return "TINYINT";
                default:
                    return "VARCHAR(255)";
            }
        }
    }
}
