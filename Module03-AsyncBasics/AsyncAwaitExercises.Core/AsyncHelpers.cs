using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExercises.Core
{
    public class AsyncHelpers
    {
        public static async Task<string> GetStringWithRetries(HttpClient client, string url, int maxTries = 3, CancellationToken token = default)
        {
            // Create a method that will try to get a response from a given `url`, retrying `maxTries` number of times.
            // It should wait one second before the second try, and double the wait time before every successive retry
            // (so pauses before retries will be 1, 2, 4, 8, ... seconds).
            // * `maxTries` must be at least 2
            // * we retry if:
            //    * we get non-successful status code (outside of 200-299 range), or
            //    * HTTP call thrown an exception (like network connectivity or DNS issue)
            // * token should be able to cancel both HTTP call and the retry delay
            // * if all retries fails, the method should throw the exception of the last try
            // HINTS:
            // * `HttpClient.GetAsync` does not accept cancellation token (use `GetAsync` instead)
            // * you may use `EnsureSuccessStatusCode()` method
            if (maxTries < 2) throw new ArgumentException(nameof(maxTries));

            int retryTimeout = 1;
            while(maxTries > 0)
            {
                try
                {
                    var result = await client.GetAsync(url, token);
                    result.EnsureSuccessStatusCode();
                    var content = await result.Content.ReadAsStringAsync();
                    return content;
                }
                catch
                {
                    await Task.Delay(retryTimeout * 1000, token);
                    retryTimeout *= 2;

                    if (maxTries == 1)
                        throw;

                    maxTries--;
                }
            }

            throw new Exception("Max tries");
        }
    }
}
