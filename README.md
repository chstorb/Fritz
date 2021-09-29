# #Fritz.NET

[![CI Actions Status](https://github.com/chstorb/Fritz/actions/workflows/main.yml/badge.svg)](https://github.com/chstorb/Fritz/blob/master/.github/workflows/main.yml)

This is the FRITZ!Box free and open-source TR064 implementation.

### Build Status

The current development branch ist `master`.

### Source code

* Clone the sources: `git clone https://github.com/chstorb/Fritz.git`


### Example

#### Write phonebook to csv file

1. Open Visual Studio
2. Create a new **Console App**
3. Add the [Fritz NuGet package](https://www.nuget.org/packages/Fritz) to your project. 
```PowerShell
       PM> Install-Package Fritz -Version 1.0.6
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

### License

**#Fritz.NET** is licensed under the [MIT license](https://github.com/chstorb/Fritz/blob/master/LICENSE.txt).


### External links
* [AVM Developer Support](https://avm.de/service/schnittstellen/) 
* [AVM TR-064 - First Steps](https://avm.de/fileadmin/user_upload/Global/Service/Schnittstellen/AVM_TR-064_first_steps.pdf)
  * [Service description request](http://fritz.box:49000/tr64desc.xml)
  * [x_contact SCPD (Service Control Protocol Description](http://fritz.box:49000/x_contactSCPD.xml)
* [broadband forum - Technical Reports](https://www.broadband-forum.org/standards-and-software/technical-specifications/technical-reports)
* [XML Schema Definition Tool (Xsd.exe)](https://docs.microsoft.com/en-US/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe)
