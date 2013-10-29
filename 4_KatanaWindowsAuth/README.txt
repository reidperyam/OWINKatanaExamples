This Project was build from the following tutorial

http://www.asp.net/aspnet/overview/owin-and-katana/enabling-windows-authentication-in-katana

When you run the application from Visual Studio, IIS Express will require the user’s Windows credentials. You can see this by using Fiddler or another HTTP debugging tool. Here is an example HTTP response:

 HTTP/1.1 401 Unauthorized
 Cache-Control: private
 Content-Type: text/html; charset=utf-8
 Server: Microsoft-IIS/8.0
WWW-Authenticate: Negotiate
WWW-Authenticate: NTLM
 X-Powered-By: ASP.NET
 Date: Sun, 28 Jul 2013 07:28:51 GMT
 Content-Length: 6062
 Proxy-Support: Session-Based-Authentication


The WWW-Authenticate headers in this response indicate that the server supports the Negotiate protocol, which uses either Kerberos or NTLM.

Later, when you deploy the application to a server, follow these steps to enable Windows Authentication in IIS on that server.
