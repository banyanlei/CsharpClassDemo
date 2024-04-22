using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Thread_Task_async_await
{
    public class AsyncLock : IDisposable
    {
        private static readonly ConcurrentDictionary<string, SemaphoreSlim> semaphoreSlimDict = new ConcurrentDictionary<string, SemaphoreSlim>();

        private bool disposedValue;

        private readonly SemaphoreSlim currentSemaphoreSlim;

        private AsyncLock(string name)
        {
            currentSemaphoreSlim = semaphoreSlimDict.GetOrAdd(name, (string x) => new SemaphoreSlim(1, 1));
        }

        public static AsyncLock Create(string name, int timeoutms)
        {
            AsyncLock asyncLock = new AsyncLock(name);
            if (!asyncLock.currentSemaphoreSlim.Wait(timeoutms))
            {
                throw new TimeoutException($"Timeout occurred after waiting {timeoutms} ms for async lock \"{name}\"");
            }

            return asyncLock;
        }

        public static async Task<AsyncLock> CreateAsync(string name, int timeoutms)
        {
            AsyncLock asyncLock = new AsyncLock(name);
            if (!(await asyncLock.currentSemaphoreSlim.WaitAsync(timeoutms)))
            {
                throw new TimeoutException($"Timeout occurred after waiting {timeoutms} ms for async lock \"{name}\"");
            }

            return asyncLock;
        }

        public static bool TryRemove(string name)
        {
            SemaphoreSlim value;
            return semaphoreSlimDict.TryRemove(name, out value);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    currentSemaphoreSlim.Release();
                }

                disposedValue = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
