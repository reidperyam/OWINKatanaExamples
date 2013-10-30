This Project was build from the following tutorial

NOTE: this implementation varies from the tutorial implementation:
- it is self-hosted using OwinHost.exe (instead of IIS)
- it doesn't implement the Nancy bootstrapper for StructureMap (via nuget package) because it throws an exception on execution
- implements Nancy's built-in ioc container
- alters the tutorial's response handling to output json
- the tutorial doesn't implement OWIN or katana packages to integrate Nancy to the OWIN pipeline

http://www.d80.co.uk/post/2013/01/04/NancyFx-Tutorial.aspx

(for testing)
http://www.d80.co.uk/post/2013/01/11/Testing-NancyFx.aspx
