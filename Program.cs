using System;
using System.IO;

namespace ChangeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for the correct number of arguments.
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: ChangeExtension <directoryPath>");
                return;
            }

            // Get the directory path from the command-line arguments.
            string directoryPath = args[0];

            // Verify the directory exists.
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine($"Error: The directory '{directoryPath}' does not exist.");
                return;
            }

            // Loop through each file in the directory.
            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                // Check if the file extension is .JPG.
                if (Path.GetExtension(filePath).Equals(".JPG", StringComparison.OrdinalIgnoreCase))
                {
                    // Create the new file name with the .jpg extension.
                    string newFilePath = Path.ChangeExtension(filePath, ".jpg");

                    // Rename the file.
                    File.Move(filePath, newFilePath);
                    Console.WriteLine($"Renamed '{filePath}' to '{newFilePath}'");
                }
            }

            Console.WriteLine("Finished renaming files.");
        }
    }
}
