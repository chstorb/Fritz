@if "%WindowsSDK_ExecutablePath_x64%"=="" goto error_no_WindowsSDK_ExecutablePath_x64

"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.generatexmlschema.xml

@goto end

:error_no_WindowsSDK_ExecutablePath_x64
@echo ERROR: You must run this command in a Developer Command Prompt for Visual Studio

:end