namespace ConsoleApp1
{
    public class AsyncCallerEAP
    {
        public EventHandler Handler { get; }

        public AsyncCallerEAP(EventHandler handler)
        {
            Handler = handler;
        }

        public bool Invoke(int timeout, object sender, EventArgs e)
        {
            var task = Task.Factory.StartNew(() => Handler.Invoke(sender, e));

            return task.Wait(timeout);
        }
    }
}
