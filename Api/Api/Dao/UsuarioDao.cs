using Api.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace Api.Dao
{
    public class UsuarioDao
    {
        public async Task<UsuarioResult> GetUsuarioDao(string Usuario)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/*+xml;version=5.1");
                client.DefaultRequestHeaders.Add("user-agent", "Authorization");
                using (HttpResponseMessage response = await client.GetAsync(WebConfigurationManager.AppSettings["GitApi"] + Usuario))
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = await content.ReadAsStringAsync();

                        var usuario = JsonConvert.DeserializeObject<UsuarioResult>(result);

                        return usuario;
                    }
                }
            }
        }
    }
}