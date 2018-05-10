using System;
using System.IO;

namespace mtisdec5
{
    class Program
    {
        static void Main(string[] args)
        {
			recfindfiles("/users/jacobgood/codeProjects/csharp");
        }

		static void recfindfiles(string path) 
		{
			DirectoryInfo d = new DirectoryInfo(path);
			if (!(d.GetDirectories().Length == 0)) {
				foreach (DirectoryInfo directory in d.GetDirectories()) {
                    // Requires full path name to understand it's location
					recfindfiles(directory.FullName);
				}
			}
			foreach (FileInfo file in d.GetFiles()) {
				Console.WriteLine(file.Name);
			}
		}
    }
}
