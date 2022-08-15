// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

void MyEventHandler(object sender, EventArgs e)
{
    Thread.Sleep(6000);
}

var eventHandler = new EventHandler(MyEventHandler);

var ac = new AsyncCallerEAP(eventHandler);

//Console.WriteLine(ac.Invoke(5000, null, EventArgs.Empty));


static async Task HandleAsync()
{
    await Task.Delay(6000);
}

var acTAP = new AsyncCallerTAP(HandleAsync());

Console.WriteLine(acTAP.InvokeAsync(5000).Result);




