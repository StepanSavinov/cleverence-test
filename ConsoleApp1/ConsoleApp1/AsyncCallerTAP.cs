namespace ConsoleApp1
{
    public class AsyncCallerTAP
    {
        private Task MyTask { get; set; }

        public AsyncCallerTAP(Task myTask)
        {
            MyTask = myTask;
        }

        public async Task<bool> InvokeAsync(int timeout)
        {
            return await Task.WhenAny(MyTask, Task.Delay(5000)) == MyTask;
        }
    }
}
