using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
	public class UwpErrorLogger
	{
		private List<string> _list = new List<string>();

		public void AddToList(string message)
		{
			_list.Add(message);
		}

		public void ReadList()
		{
			foreach (var item in _list)
			{
				Console.WriteLine(item);
			}
		}
	}
}
