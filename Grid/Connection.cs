﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    class Connection
    {
        string connection;
        string server = @"VPR0671070W10-1\SQLEXPRESS";
        string db = "Grid";
        string user = "sa";
        string pass = "123456";
        public SqlConnection conn;

        public Connection()
        {
            try 
            {
                connection = $"Data Source={server}; Initial Catalog={db}; User id={user};Password={pass}; TrustServerCertificate=True";

                conn = new SqlConnection(connection);
                //conn.Open();
                //MessageBox.Show("Conexão OK");
                //conn.Close();
            }catch (Exception ex) 
            { 
                //MessageBox.Show("Erro de conexão");
            
            }

        }
    }
}
