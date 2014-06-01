# Simple HTTP Request with ASP.NET and C#

This repo includes two files that show how an .aspx file and its corresponding .cs file interact.
Together they send an HTTP request with content a user entered into a form.

## Running project

 * Create a new project in Visual Studio using the ASP.NET Web Application 
 template under Visual C#.
 * Install packages:
 * In the Solution Explorer, right click the solution and go to "Manage NuGet Packages". 
 * Search for "Bootstrap" and "Microsoft ASP.NET Web API 2.1" and install both packages.
The ASP.NET Web API is necessary for sending HTTP requests with C# while Bootstrap is just for frontend so its optional.
 * Replace the Default.aspx and Default.aspx.cs files with the ones in this repo.
 * Update lines 18 and 19 of the .cs file: Create a new PasteBin at http://pasteb.in and update line 18 and change line 19 to reflect a location on your local machine.