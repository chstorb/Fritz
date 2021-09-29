<# 
	.SYNOPSIS 
	Generates a .nuspec file for the Fritz package.

	.DESCRIPTION
	Use in a folder containing a project file <project-name>.csproj or <project-name>.vbproj

	.LINK 
	https://docs.microsoft.com/en-us/nuget/reference/cli-reference/cli-ref-spec
#>

Set-Location -Path ".\Fritz"
nuget spec 