<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Threading.Tasks.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Async2();
	Console.WriteLine("aaa");
}

async void Async2()
{

  Task.Run( () => {
  		Thread.Sleep(500); Console.WriteLine("bbb");
  	}
  );
  Console.WriteLine("ccc");
}