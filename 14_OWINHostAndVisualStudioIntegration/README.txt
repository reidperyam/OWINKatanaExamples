This example demonstrates how to integrate OwinHost.exe to host an OWIN app and how this is integrated into visual Studio

The nuget packages needed:

Microsoft.Owin
Owin
OwinHost

Please note the project property (click the .csproj in Solution Explorer and navigate to the Properties Window in the main IDE): "Always Start When Debugging"
This should be set to false

Additionally right click the .csproj and select "Properties"
Navigate to the "Web" tab -- this is where you configure the application to leverage the OwinHost.exe