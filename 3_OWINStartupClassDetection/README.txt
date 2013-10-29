This Project was build from the following tutorial

http://www.asp.net/aspnet/overview/owin-and-katana/owin-startup-class-detection

Using Owinhost.exe 
1.Replace the Web.config file with the following markup:
<?xml version="1.0" encoding="utf-8"?>
<configuration>
   <appSettings>
      <add key="owin:appStartup" value="StartupDemo.Startup" />
      <add key="owin:appStartup" value="StartupDemo.TestStartup" />
   </appSettings>
  <system.web>
    <compilation debug="true" targetFramework="4.5" />
    <httpRuntime targetFramework="4.5" />
  </system.web>
</configuration>
The last key wins, so in this case  TestStartup is specified. 
2.Install Owinhost from the PMC: 

Install-Package OwinHost


3.Navigate to the application folder (the folder containing the  Web.config file) and in a command prompt and type: 

..\packages\Owinhost<Version>\tools\Owinhost.exe

 The command window will show:

C:\StartupDemo\StartupDemo>..\packages\OwinHost.2.0.0\tools\Owin
 Host.exe
Starting with the default port: 5000 (http://localhost:5000/)
 Started successfully
Press Enter to exit

4.Launch a browser with the URL  http://localhost:5000/. zz



OwinHost honored the startup conventions listed above.
5.In the command window, press Enter to exit OwinHost.
6.In the ProductionStartup class,  add the following OwinStartup attribute which specifies a friendly name of  ProductionConfiguration.[assembly: OwinStartup("ProductionConfiguration", 
           typeof(StartupDemo.ProductionStartup))]

7. In the command prompt and type: 
 ..\packages\OwinHost.2.0.0\tools\OwinHost.exe ProductionConfiguration

The Production startup class is loaded.
 
 Our application has multiple startup classes, and in this example we have deferred which startup class to load until runtime.
8.Test the following runtime startup options:..\packages\OwinHost.2.0.0-rc1\tools\OwinHost.exe StartupDemo.TestStartup
..\packages\OwinHost.2.0.0-rc1\tools\OwinHost.exe "StartupDemo.TestStartup,StartupDemo"
..\packages\OwinHost.2.0.0-rc1\tools\OwinHost.exe StartupDemo.TestStartup.Configuration
..\packages\OwinHost.2.0.0-rc1\tools\OwinHost.exe "StartupDemo.TestStartup.Configuration,St

