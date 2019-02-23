using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompletionApi.AutoCompletion.Service.Interfaces
{
    public interface IAutoCompletionService
    {
        /// <summary>
        /// Fetrches API results for the provided hint
        /// </summary>
        /// <param name="hint">query hint</param>
        /// <returns>the stringlyfied GeoJSON</returns>
        Task<string> FetchSuggestions(string hint);
    }
}
