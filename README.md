
[![Nuget version](https://img.shields.io/nuget/v/Fritz)](https://www.nuget.org/packages/Fritz/)
[![Nuget downloads](https://img.shields.io/nuget/dt/Fritz)](https://www.nuget.org/packages/Fritz/)
[![CI Actions Status](https://github.com/chstorb/Fritz/actions/workflows/main.yml/badge.svg)](https://github.com/chstorb/Fritz/blob/master/.github/workflows/main.yml)

# Fritz#
The [FRITZ!Box](https://avm.de/produkte/fritzbox/) is a popular device that provides internet access, telephony, and home 
networking services. It supports a protocol called [TR064](https://avm.de/service/schnittstellen/), which allows remote 
management and configuration of the device. However, the official TR064 implementation is proprietary and closed-source, 
which limits the users' freedom and control over their own devices. That's why we have developed a free and open-source 
TR064 implementation for the FRITZ!Box, which aims to provide a more transparent, secure, and customizable alternative. 
Our implementation is based on the TR064 specification and compatible with the existing FRITZ!Box features. 
With our free and open-source TR064 implementation, you can take full advantage of your FRITZ!Box and enjoy a better internet experience.

## Installing

To use the package in your project, you need to edit your csproj file and insert the following line, where x.x.x is the latest version number (you can check it at the beginning of this file):
```xml
<PackageReference Include="Fritz" Version="x.x.x" />
```

You can also install via the Package Manager Console in Visual Studio with the following command:
```PowerShell
PM> Install-Package Fritz -Version 1.1.0
```

If you're using Visual Studio you can also install via the built in NuGet package manager.

Another option to install is using the .NET CLI tool. Just run this command in your terminal:
```bash
dotnet add package Fritz
```

## Example

### Write phonebook to csv file

To write a phonebook to a csv file, you need to follow these steps:

1. Open [Visual Studio](https://visualstudio.microsoft.com/)
2. Create a new [Console App](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022)
3. Add the [Fritz NuGet package](https://www.nuget.org/packages/Fritz) to your project. 
```PowerShell
PM> Install-Package Fritz -Version 1.1.0
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
            fritzBox.WritePhonebookCsv(name: "Test Phonebook", folder: AppDomain.CurrentDomain.BaseDirectory, separator: ";");
        }
    }
}
```

5. Run the program

## Testing

You can find the project Fritz.Test with many unit tests in this repository. These tests are useful for learning how to write your own code using Fritz#. 
You can see how they are structured, what they test, and how they report the results. 

```csharp
[TestMethod]
public void TestTamGetInfo()
{
    Tam service = new Tam(_fb.Url);
    service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);

    ushort index = 0;
    bool enable;
    string name;
    bool tamRunning;
    ushort stick;
    ushort status;

    service.GetInfo(index, out enable, out name, out tamRunning, out stick, out status);
}
```

## License

**Fritz#** is licensed under the [MIT license](https://github.com/chstorb/Fritz/blob/master/LICENSE.txt).


## External links
* [AVM Developer Support](https://avm.de/service/schnittstellen/) 
* [TR-064 Support - X_AVM-DE-OnTel](https://avm.de/fileadmin/user_upload/Global/Service/Schnittstellen/x_contactSCPD.pdf)
* [AVM TR-064 - First Steps](https://avm.de/fileadmin/user_upload/Global/Service/Schnittstellen/AVM_TR-064_first_steps.pdf)
  * [Service description request](http://fritz.box:49000/tr64desc.xml)
  * [x_contact SCPD (Service Control Protocol Description)](http://fritz.box:49000/x_contactSCPD.xml)
* [broadband forum - Technical Reports](https://www.broadband-forum.org/standards-and-software/technical-specifications/technical-reports)
* [Fritz# on nuget.org](https://www.nuget.org/packages/Fritz)
* [XML Schema Definition Tool (Xsd.exe)](https://docs.microsoft.com/en-US/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe)
