# Demo: Microsoft Extensions.

I thought I would spend a bit of time understanding how to use the Microsoft Extensions in a .NET Platform 4.8 application.

Since .NET 4.8 is compliant with [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) this should mean any core components that are also .NET Standard 2.0 compliant can be used with relatively few dependencies.

## First Step Create a Console Application.

I created an empty console application first to hang these extensions off.
My concept is I will run through each of the qualifying extensions in turn and demonstrate what they do and how they can be extended as I go. This will be a series of related posts.

## Second Step add a JSON Configuration

The first extension I decided to add was a JSON configuration. This is mainly so I can configure later, more complicated, extensions.

Add the [Microsoft.Extensions.Configuration.Json](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Json/3.1.5/) NuGet dependency and a JSON configuration file. Then update the program to use this file rather than the command line.