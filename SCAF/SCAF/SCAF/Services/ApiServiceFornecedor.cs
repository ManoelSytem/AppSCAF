using Newtonsoft.Json;
using SCAF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Services
{
    public class ApiServiceFornecedor
    {
        HttpClient client = new HttpClient();
        public async Task<List<Fornecedor>> GetFornecedorsAsync()
        {
            try
            {
                string url = "http://localhost:52432/api/Fornecedor";
                var response = await client.GetStringAsync(url);
                var Fornecedors = JsonConvert.DeserializeObject<List<Fornecedor>>(response);
                return Fornecedors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task AddFornecedorAsync(Fornecedor Fornecedor)
        {
            try
            {
                string url = "http://www.macwebapi.somee.com/api/Fornecedors/{0}";
                var uri = new Uri(string.Format(url, Fornecedor.Cnpj));
                var data = JsonConvert.SerializeObject(Fornecedor);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao incluir Fornecedor");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task UpdateFornecedorAsync(Fornecedor Fornecedor)
        {
            string url = "http://www.macwebapi.somee.com/api/Fornecedors/{0}";
            var uri = new Uri(string.Format(url, Fornecedor.Cnpj));
            var data = JsonConvert.SerializeObject(Fornecedor);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await client.PutAsync(uri, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao atualizar Fornecedor");
            }
        }
        public async Task DeletaFornecedorAsync(Fornecedor Fornecedor)
        {
            string url = "http://www.macwebapi.somee.com/api/Fornecedors/{0}";
            var uri = new Uri(string.Format(url, Fornecedor.Cnpj));
            await client.DeleteAsync(uri);
        }
    }

}
