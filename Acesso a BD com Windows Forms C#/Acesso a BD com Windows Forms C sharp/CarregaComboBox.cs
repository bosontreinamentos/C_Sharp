using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    class CarregaComboBox
    {
        public List<string> carregaComboBox(string SQL, string coluna)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            List<string> Item = new List<string>();
            try
            {
                conn.Open();
                SqlCommand consulta = new SqlCommand(SQL, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = consulta.ExecuteReader();
                if (drDados.HasRows) // Verificar se há linhas retornadas
                {
                    while (drDados.Read())
                    {
                        Item.Add(drDados[coluna].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Registros não encontrados");
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            return Item;
        }

        public List<string> carregaComboBoxAutores(string SQL, string coluna, string coluna2)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            List<string> Item = new List<string>();
            try
            {
                conn.Open();
                SqlCommand consulta = new SqlCommand(SQL, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = consulta.ExecuteReader();
                if (drDados.HasRows) // Verificar se há linhas retornadas
                {
                    while (drDados.Read())
                    {
                        Item.Add(drDados[coluna].ToString() + " " + drDados[coluna2].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Registros não encontrados");
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            return Item;
        }

        public List<string> carregaComboBoxEditoras(string SQL, string coluna)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            List<string> Item = new List<string>();
            try
            {
                conn.Open();
                // Criar comando de consulta:
                SqlCommand consulta = new SqlCommand(SQL, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = consulta.ExecuteReader();
                if (drDados.HasRows) // Verificar se há linhas retornadas
                {
                    while (drDados.Read())
                    {
                        Item.Add(drDados[coluna].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Registros não encontrados");
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            return Item;
        }
    }
}