using System;
using System.IO;

namespace AccessIsDenied
{
	public class FileUtils
	{
		private readonly string filePath = Directory.GetCurrentDirectory();

		public bool IsAccessToAnyFileDenied()
		{
			bool IsAccessDenied = true;
			DirectoryInfo modernVideoRecorderDir = new DirectoryInfo(filePath);

			foreach (FileInfo file in modernVideoRecorderDir.GetFiles())
			{
				FileStream stream = null;

				try
				{
					if(!file.FullName.Contains("CheckDirAccess"))
					stream = file.Open(FileMode.Open);					
				}
				catch (Exception)
				{
					IsAccessDenied = false;
					Console.WriteLine($"Access denied to file : {file.FullName}");
				}
				if (stream != null) stream.Close();
			}
			return IsAccessDenied;
		}
	}
}
