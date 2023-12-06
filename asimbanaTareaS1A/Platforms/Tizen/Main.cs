using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace asimbanaTareaS1A;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
