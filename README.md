# 2LCS - Lifecycle Services companion app

This small utility can help you manage D365FO instances deployed in your LCS project. Both cloud-hosted - in your Azure subscription and Microsoft-hosted sandboxes. It offers only a subset of functionalities that LCS offers, but you can execute them a bit faster.
To download latest version go to [Releases section](https://github.com/Microsoft/2LCS/releases) and download zip archive (2LCS-X.X.X.X.zip) with compiled app. 
# Quick tips

* After you run it for the first time you need to login to LCS in the app. It will log you in automatically if you are already logged in active Internet Explorer or Edge session.
* Second step is to refresh list of projects you can access in LCS.
* Third one is to refresh the list of D365 instances for chosen project.

You can access most of the functionality by right-clicking instance row on the grid. It is possible to execute most of the commands on multiple instances at once. To do that you need to select them first using row header on the left side of the grid. Similar to Excel.

During logon 2LCS intercepts and saves the cookie to use it for later authentication. This cookie will expire after some time. You will be notified in the app. Then you need to repeat initial steps again.

# No support

**Please note that this is only a sample code that is not supported by Microsoft in anyway.** It is provided AS IS and it can break anytime because of changes introduced in LCS. 

# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
