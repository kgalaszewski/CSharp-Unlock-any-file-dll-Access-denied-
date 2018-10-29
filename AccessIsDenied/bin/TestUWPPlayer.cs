using Serilog;
using Serilog.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace App2
{
	class TestUWPPlayer
	{
		public void InitializeLogger()
		{
			UwpErrorLogger uwpErrorLogger = new UwpErrorLogger();
			var log = new LoggerConfiguration().WriteTo.Console().WriteTo.Logger(x => uwpErrorLogger.AddToList(x.ToString())).CreateLogger();
			log.Fatal("fatal");
			log.Error("error");
			log.Fatal("fatal2");
			uwpErrorLogger.ReadList();
		}
	}
}
