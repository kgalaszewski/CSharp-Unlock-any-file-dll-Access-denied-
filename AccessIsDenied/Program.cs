using System;

namespace AccessIsDenied
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = System.IO.Directory.GetCurrentDirectory();
			Console.WriteLine($"Current dir : {filePath}");
			FileUtils fileUtils = new FileUtils();
			Console.WriteLine($"You have access to all files : {fileUtils.IsAccessToAnyFileDenied()}");
			Console.ReadKey();
		}
	}
}
