# #Fritz.NET

## Description

This is the FRITZ!Box free and open-source TR064 implementation.

## Example

### Write phonebook to csv file

1. Open Visual Studio
2. Create a new **Console App**
3. Add the [Fritz NuGet package](https://www.nuget.org/packages/Fritz) to your project. 
```PowerShell
       PM> Install-Package Fritz -Version 1.0.1
```
4. Add the following code to the main method:
```Csharp
        namespace ConsoleApp
        {
            class Program
            {
                static void Main(string[] args)
                {
                    var fritzBox = new FritzClient()
                    {
                        UserName = "{YOUR_USERNAME}",
                        Password = "{YOUR_PASSWORD}"
                    };
                    
                    // Write csv file to the application folder
                    fritzBox.WritePhonebookCsv();
                }
            }
        }
```

5. Run the program

## License

Licensed under the [MIT](https://github.com/chstorb/Fritz/blob/master/LICENSE.txt) License.

## External links
* [AVM Developer Support](https://avm.de/service/schnittstellen/) 
* [broadband forum - Technical Reports](https://www.broadband-forum.org/standards-and-software/technical-specifications/technical-reports)
* [XML Schema Definition Tool (Xsd.exe)](https://docs.microsoft.com/en-US/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe)