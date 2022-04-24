using LanchoneteUDV.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Services.Service
{
    public class GranatumService
    {
        HttpClient client = new HttpClient();
        string _token = "3d1d6d138f602a65cd50838e1d7a5a7ceade83d73acc83372980b8a84ddeb4c9";


        public async Task<List<LancamentoGranatum>> GetLancamentosAsync()
        {
            try
            {
                //string conta = "93175";
                string pessoaq = "1996633";
                string data_inicio = "2021-05-01";
                string data_fim = "2021-05-31";


                //var content = new StringContent("",Encoding.UTF8,"application/json");
                //content.Headers.Clear();
                //content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                //HttpResponseMessage response = client.GetAsync(url).Result;







                string url = $"https://api.granatum.com.br/v1/lancamentos?access_token={_token}&" +
                    //$"conta_id={conta}&" +
                    $"pessoa_id={pessoaq}&" +
                    $"data_inicio={data_inicio}&" +
                    $"data_fim={data_fim}&";

                var response = await client.GetStringAsync(url);
                var lancamentos = JsonConvert.DeserializeObject<List<LancamentoGranatum>>(response);
                return lancamentos;
                // HttpResponseMessage resposta 


                ////var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                //content.Headers.Clear();
                //content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                //HttpResponseMessage response = httpClient.PostAsync(url, content).Result;



            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
