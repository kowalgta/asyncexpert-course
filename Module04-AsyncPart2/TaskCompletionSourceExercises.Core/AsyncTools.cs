using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskCompletionSourceExercises.Core
{
    public class AsyncTools
    {
        public static Task<string> RunProgramAsync(string path, string args = "")
        {
            var process = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = new ProcessStartInfo(path)
                {
                    RedirectStandardOutput = true, RedirectStandardError = true, Arguments = args
                }
            };

            var tcs = new TaskCompletionSource<string>();

            process.Exited += (sender, eventArgs) =>
            {
                var senderProcess = sender as Process;
                if (senderProcess?.ExitCode != 0)
                {
                    var errorMessage = senderProcess?.StandardError.ReadToEnd();
                    tcs.TrySetException(new Exception(errorMessage));
                }
                else
                {
                    tcs.TrySetResult(senderProcess?.StandardOutput.ReadToEnd());
                }
                senderProcess?.Dispose();
            };

            process.Start();

            return tcs.Task;
        }
    }
}
