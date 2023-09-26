# ChangeExtension

A simple .NET 6.0 console application to rename file extensions from `.JPG` to `.jpg` in a specified directory.

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

## Usage

1. **Navigate to the Project Directory:**
   Open a command prompt or terminal and navigate to the directory containing the `ChangeExtension` project.

2. **Build the Project:**
   Run the following command to build the project:	
   dotnet run -- <directoryPath>
   
3. **Run the Application:**
Run the application with the following command, replacing `<directoryPath>` with the path to the directory containing the `.JPG` files:
 

This will rename all files with the `.JPG` extension in the specified directory to have a `.jpg` extension.

## Example
`dotnet run -- "C:\Users\Gates\Desktop\1"

To rename all files with the `.JPG` extension in the directory `C:\path\to\your\images`, use the following command:

This command will loop through all the files in the `C:\path\to\your\images` directory and change the extension of files with `.JPG` to `.jpg`.

## Note

Be sure to backup your files before running the application to prevent data loss in case of an error.




