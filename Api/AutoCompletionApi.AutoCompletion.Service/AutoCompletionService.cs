using AutoCompletionApi.AutoCompletion.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompletionApi.AutoCompletion.Service
{
    /// <summary>
    /// Implementation of the auto-completion service
    /// </summary>
    /// <see cref="Interfaces.IAutoCompletionService"/>
    public class AutoCompletionService : IAutoCompletionService
    {
        /// <summary>
        /// Governmental API for addresses
        /// </summary>
        /// <see href="https://adresse.data.gouv.fr/"/>
        private readonly string GouvernmentalApi = "https://api-adresse.data.gouv.fr/search/";

        /// <summary>
        /// Service to fetch governmental Api result
        /// </summary>
        public AutoCompletionService() { }

        /// <summary>
        /// Fetrches API results for the provided hint
        /// </summary>
        /// <param name="hint">query hint</param>
        /// <returns>the stringlyfied GeoJSON</returns>
        /// <see href="https://tools.ietf.org/html/rfc7946"/>
        public async Task<string> FetchSuggestions(string hint)
        {
            string geoJsonData;

            // building query
            var request = (HttpWebRequest)WebRequest.Create($"{GouvernmentalApi}?q={hint}");

            // fetching results
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        geoJsonData = await reader.ReadToEndAsync();
                    }
                }
            }
            
            return geoJsonData;
        }
    }
}
