using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance
{
    internal class LoadFile
    {
        public static string loadFile(string filePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filePath))
                    throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
                if(!File.Exists(filePath))
                    throw new FileNotFoundException("File was not found.", filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
                
            }
            return File.ReadAllText(filePath);
        }

    }
}
