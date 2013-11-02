This Project was build from the following tutorial

http://www.c-sharpcorner.com/UploadFile/4b0136/web-api-hosting-from-owin-with-windows-azure/

TO RUN THIS APPLICATION
- use the Azure emulator - set this project as the default start up project in visual studio (right-click and select from the context menu)
- you will have to be running visual studio in administrator mode (which might necessitate a restart of VS) in order to run the 
  Azure emulator

TO DEPLOY THIS APPLICATION DIRECTLY ONTO AZURE DIRECTLY FROM VISUAL STUDIO (you can remove it with a touch of a button don't worry)
- Create an Azure account if you don't already have one
- RIGHT-CLICK AzureWorkerRoleOWINHost.csproj and select "Publish" - follow instructions to integrate with you Azure account
- This will create a *.azurePubxml file ; I deleted mine since I don't want you to use it :*

