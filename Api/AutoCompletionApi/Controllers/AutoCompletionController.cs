using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoCompletionApi.AutoCompletion.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.Annotations;

namespace AutoCompletionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoCompletionController : ControllerBase
    {
        private readonly IAutoCompletionService _autoCompletionService;

        public AutoCompletionController(IAutoCompletionService autoCompletionService)
        {
            _autoCompletionService = autoCompletionService;
        }

        /// <summary>
        /// Fetches the result from the governmental API to provide auto-completion suggestions
        /// </summary>
        /// <remarks><see href="https://adresse.data.gouv.fr/api"/></remarks>
        /// <param name="hint">query hint to pass to the API</param>
        /// <returns>The fetched results of the governmental API</returns>
        [HttpGet("{hint}")]
        [SwaggerResponse(200, "Suggestions successfully fetched and sent")]
        [SwaggerOperation(
            Summary = "Fetches the result from the governmental API to provide auto-completion suggestions",
            Description = "Queries https://api-adresse.data.gouv.fr/ to fetch auto-completion suggestions",
            OperationId = "GetAutoCompletionSuggestions",
            Tags = new[]
            {
                "AutoComplete",
            }
        )]
        [Produces("application/json")]
        public async Task<ActionResult<string>> GetAutoCompletionSuggestions(string hint)
        {
            var results = _autoCompletionService.FetchSuggestions(hint).Result;
            return Ok(JObject.Parse(results));
        }
    }
}