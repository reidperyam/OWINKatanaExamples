OWIN Katana Examples
==================

Current count of example .csprojs: 19

Visual Studio 2013 .sln showcasing OWIN/katana integration of NancyFx, SignalR, ASP.NET Web API Nancy's Ninject boostrapping, NancyFx testing
some others too...

My Implementations of OWIN/Katana/Nancy/Ninject/SignalR/ASP.NET Web API Integration Tutorials made public to aid others in learning OWIN and Katana
If you would like to supplement these please let me know! 

Requires Visual Studio 2013

1_IISOWINHost

	http://www.asp.net/aspnet/overview/owin-and-katana/getting-started-with-owin-and-katana
	
2_SelfOWINHost

	http://www.asp.net/aspnet/overview/owin-and-katana/getting-started-with-owin-and-katana

3_OWINStartupClassDetection

	(this outlines a manual invocation of OwinHost.exe made obsolete in Visual Studio 2013 -- as shown in further example .csprojs -eg #14)
	http://www.asp.net/aspnet/overview/owin-and-katana/owin-startup-class-detection

4_KatanaWindowsAuth

	http://www.asp.net/aspnet/overview/owin-and-katana/enabling-windows-authentication-in-katana

5_KatanaASPNETWebAPI

	http://weblogs.asp.net/fredriknormen/archive/2013/07/29/get-started-by-using-asp-net-web-api-and-nancyfx-with-owin-katana.aspx

6_KatanaConsoleHost

	http://weblogs.asp.net/fredriknormen/archive/2013/07/29/get-started-by-using-asp-net-web-api-and-nancyfx-with-owin-katana.aspx

7_KatanaNancyFX

	http://weblogs.asp.net/fredriknormen/archive/2013/07/29/get-started-by-using-asp-net-web-api-and-nancyfx-with-owin-katana.aspx

8_BigKatana

	ASP.NET Web API, SignalR, NancyFx, Katana/OWIN
	http://msdn.microsoft.com/en-us/magazine/dn451439.aspx

9_ASPNETWebAPIOWINSelfHost

	http://www.asp.net/web-api/overview/hosting-aspnet-web-api/use-owin-to-self-host-web-api

10_OWINMiddlewareInIISPipeline

	http://www.asp.net/aspnet/overview/owin-and-katana/owin-middleware-in-the-iis-integrated-pipeline

11_OWINStartupClassDetection

	http://www.asp.net/aspnet/overview/owin-and-katana/owin-startup-class-detection
	
12_KatanaSignalRSelfHosted

	http://www.dotnetcurry.com/ShowArticle.aspx?ID=915

13_KatanaLogging

	http://www.tugberkugurlu.com/archive/logging-in-the-owin-world-with-microsoft-owin--introduction

14_OWINHostAndVisualStudioIntegration

	This example demonstrates how to integrate OwinHost.exe to host an OWIN app and how this is integrated into visual Studio

15_NancyOwinTutorial

	NOTE: this implementation varies from the tutorial implementation:
	- it is self-hosted using OwinHost.exe (instead of IIS)
	- it doesn't implement the Nancy bootstrapper for StructureMap (via nuget package) because it throws an exception on execution
	- implements Nancy's built-in ioc container
	- alters the tutorial's response handling to output json
	- the tutorial doesn't implement OWIN or katana packages to integrate Nancy to the OWIN pipeline

	http://www.d80.co.uk/post/2013/01/04/NancyFx-Tutorial.aspx

16_NancyOwinTutorialTesting

	(for testing #15)
	http://www.d80.co.uk/post/2013/01/11/Testing-NancyFx.aspx

17_NancyOwinIOCNinject

	This Project was not built from a tutorial but stumbled through by Reid

18_OWINUseErrorPage

	http://miso-soup3.hateblo.jp/entry/2013/10/30/205653
	
19_OWINNancyPassthrough

	https://github.com/NancyFx/Nancy/wiki/Hosting-nancy-with-owin#conditional-pass-through


