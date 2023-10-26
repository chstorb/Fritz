<# 
	.SYNOPSIS 
	Creates a Fritz NuGet package.

	.DESCRIPTION
	When using a Visual Studio project, run nuget pack with your project file, which automatically loads 
	the project's .nuspec file and replaces any tokens within it using values in the project file.

	.LINK 
	https://docs.microsoft.com/en-us/nuget/reference/cli-reference/cli-ref-pack
#>

Set-Location -Path ".\Fritz"
nuget pack Fritz.csproj -Build -Symbols -Properties Configuration=Release