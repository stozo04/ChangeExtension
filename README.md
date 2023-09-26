# ChangeExtension and Resize

A .NET 6.0 console application to rename file extensions from `.JPG` to `.jpg`, rename the files with a sequential number, and resize the images to 30% of their original size in a specified directory.

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- ImageSharp Library (installed with `dotnet add package SixLabors.ImageSharp`)

## Usage

1. **Navigate to the Project Directory:**
   Open a command prompt or terminal and navigate to the directory containing the `ChangeExtension` project.

2. **Install the ImageSharp Library:**
   Run the following command to add the ImageSharp library to your project:
   ```dotnet add package SixLabors.ImageSharp```
   
3. **Build the Project:**	
   Run the following command to build the project:
   ```dotnet build```

4. **Run the Application:**
   Run the application with the following command, replacing `<directoryPath>` with the path to the directory containing the `.JPG` files:
   ```dotnet run -- <directoryPath>```

For example: ```dotnet run -- "C:\Users\Gates\Desktop\1"```


This will:
- Rename all files with the `.JPG` extension in the specified directory to have a `.jpg` extension.
- Rename each file to a sequential number starting from 1.
- Resize each image to 30% of its original size.

## Example

To rename and resize all files with the `.JPG` extension in the directory `C:\Users\Gates\Desktop\1`, use the following command:
```dotnet run -- "C:\Users\Gates\Desktop\1"```


This command will loop through all the files in the `C:\Users\Gates\Desktop\1` directory, change the extension of files with `.JPG` to `.jpg`, rename each file to a sequential number, and resize each image to 30% of its original size.

## Note

Be sure to backup your files before running the application to prevent data loss in case of an error.



 
