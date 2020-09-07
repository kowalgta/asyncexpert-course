using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AwaitableExercises.Core
{
    public static class BoolExtensions
    {
        public static BoolAwaiter GetAwaiter(this bool b)
        {
            return new BoolAwaiter(b);
        }
    }

    public readonly struct BoolAwaiter : INotifyCompletion
    {
        private readonly bool _b;

        public BoolAwaiter(bool b)
        {
            _b = b;
        }
        
        public bool IsCompleted => true;

        public void OnCompleted(Action continuation)
        {
            continuation();
        }

        public bool GetResult()
        {
            return _b;
        }
    }
}
