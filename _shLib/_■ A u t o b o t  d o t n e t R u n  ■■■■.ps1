#Install Node & NPM For this to work...   https://nodejs.org/en/download/


  Start-Process "chrome.exe" "	https://localhost:1999	"


  #AWS server access in a tab...
		#start-process "chrome.exe" "https://us-east-2.console.aws.amazon.com/ec2/v2/home?region=us-east-2#",'--profile-directory="Default"'

  #Open SSMS   SQL Serrver Manager
		#start "C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Ssms.exe"
		#		 $serverName -E          possible flag for opening and feeding config....

  dotnet watch run


####        #Set Powershell to .......
#set-ExecutionPolicy unrestricted
#https://docs.west-wind.com/westwind.utilities/index.htm

#https://weblog.west-wind.com/posts/2019/May/18/Live-Reloading-Server-Side-ASPNET-Core-Apps#proxying-aspnet-core-for-code-injection


##		These are a settings added into     apsettings.json.....    
#		click drop down arrow,..   appsettings.Development.json
#			Which file types to triggerr reloads,...  
##

#browser-sync start `
 #   --proxy http://localhost:5001/ `
  #  --files '**/*.cshtml, **/*.css, **/*.js, **/*.cs'  

