using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeKeeper.Services
{
    public class PrerenderService
    {
        public PrerenderService(IJSRuntime jSRuntime) => JSRuntime = jSRuntime;

        private readonly IJSRuntime JSRuntime;
        private bool Prerendering = true;

        public bool IsPrerendering() => Prerendering;

        /// <summary>
        /// Called in OnAfterRenderAsync to determine if the site is prerendering
        /// </summary>
        public async Task UpdateIsPrerendering()
        {
            try
            {
                Prerendering = (await JSRuntime.InvokeAsync<string>("getUserAgent")) == "ReactSnap";
            }
            catch (JSException e)
            {
                Console.WriteLine($"An error occurred fetching the user agent: {e.Message}");
            }
        }
    }
}
