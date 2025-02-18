using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Connection
    {
        public static string ConString = new ConfigurationBuilder()
            .AddJsonFile("connection.json").
            Build().GetSection("connection").Value;
    }
}
