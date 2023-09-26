using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

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
            string[] files = Directory.GetFiles(directoryPath);
            int counter = 1; // Start the counter at 1.
            foreach (string filePath in files)
            {
                // Check if the file extension is .jpg.
                if (Path.GetExtension(filePath).Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                {
                    // Create the new file name with the counter and .jpg extension.
                    string newFileName = $"{counter}.jpg";
                    string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName);

                    // Resize the image to 30% of its original size.
                    using (Image image = Image.Load(filePath))
                    {
                        image.Mutate(x => x.Resize(new ResizeOptions
                        {
                            Size = new Size((int)(image.Width * 0.3), (int)(image.Height * 0.3)),
                            Mode = ResizeMode.Max
                        }));
                        image.Save(newFilePath); // Save the resized image to the new file path.
                    }

                    // Rename the file.
                    if (filePath != newFilePath)
                    {
                        File.Delete(filePath); // Delete the original file.
                    }

                    Console.WriteLine($"Resized and renamed '{filePath}' to '{newFilePath}'");

                    counter++; // Increment the counter.
                }
            }

            Console.WriteLine("Finished resizing and renaming files.");
        }
    }
}
