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
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
                    
                }
                // Check if the file exists
                if (!System.IO.File.Exists(filePath))
                {
                    throw new System.IO.FileNotFoundException("The specified file does not exist.", filePath);
                }
                // Read the content of the file
                string content = System.IO.File.ReadAllText(filePath);
                return content;
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error message
                return $"Error accessing file: {ex.Message}";
            }
        }

    }
}
