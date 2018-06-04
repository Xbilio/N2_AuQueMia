using BibliotecaN2.DAO;
using BibliotecaN2.Enum;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaN2
{
    public static class Metodos
    {       
        public static DataTable ExecutaProcResultSet(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlCommand cmd = new SqlCommand(procedure, cx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        try
                        {
                            adapter.Fill(tabela);
                        }
                        catch(Exception erro)
                        {
                            throw new Exception("Não foi possível encontrar dados. " + erro.Message);
                        }
                        
                        return tabela;
                    }
                }
            }
        }
    
        public static void ExecutaProcedure(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(procedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static string ExecutaProcedureComRetorno(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(procedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);

                    comando.Parameters.Add("retorno", SqlDbType.VarChar);
                    comando.Parameters["retorno"].Direction = ParameterDirection.ReturnValue;
                    comando.ExecuteNonQuery();
                    return comando.Parameters["retorno"].Value.ToString();
                }
            }
        }
        #region validações
        /// <summary>
        /// método que testa se um determinado valor string contém um inteiro válido
        /// </summary>
        /// <param name="valor">valor string a ser testado</param>
        /// <returns>true se for inteiro ou false caso contrário </returns>
        public static bool ValidaInt(string valor)
        {
            try
            {
                Convert.ToInt32(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// método que testa se um determinado valor string contém um double válido
        /// </summary>
        /// <param name="valor">valor string a ser testado</param>
        /// <returns>true se for double ou false caso contrário </returns>
        public static bool ValidaDouble(string valor)
        {
            try
            {
                Convert.ToDouble(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// método que testa se um determinado valor string contém uma data válida
        /// </summary>
        /// <param name="valor">valor string a ser testado</param>
        /// <returns>true se for data ou false caso contrário </returns>
        public static bool ValidaData(string valor)
        {
            try
            {
                Convert.ToDateTime(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Exibe uma mensagem
        /// </summary>
        /// <param name="mensagem">Texto da mensagem</param>
        /// <param name="tipoDaMensagem">tipo da mensagem</param>
        /// <returns>Quando for mensagem de confirmação, returna true se o
        /// usuário clicar em sim e retorna False caso clique em não</returns>
        public static bool Mensagem(string mensagem, TipoMensagemEnum tipoDaMensagem)
        {
            if (tipoDaMensagem == TipoMensagemEnum.alerta)
            {
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return true;
            }
            else if (tipoDaMensagem == TipoMensagemEnum.erro)
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return true;
            }
            else if (tipoDaMensagem == TipoMensagemEnum.informacao)
            {
                MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
        }
        #endregion
    }
}
