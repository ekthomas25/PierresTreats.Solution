# Application Name

#### By Liz Thomas

#### _Short Description_

## Technologies Used

* _HTML_
* _CSS_
* _Bootstrap_
* _C#_
* _.NET_
* _ASP.NET_
* _Entity_
* _Razor_
* _Node_
* _SQL_
* _MySQL Workbench_

## Description

_This web application was created for..._

## Setup/Installation Requirements

### Your computer will need to have the following installed and set up:
* _[GIT](https://docs.github.com/en/get-started/quickstart/set-up-git)_
* _[Visual Studio Code](https://code.visualstudio.com/download)_
* _[Node](https://nodejs.dev/learn/how-to-install-nodejs)_
* _.NET - [Mac](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer) or [Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer)_
* _[MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)_

### File Setup

* _Once you have VSCode, Node, and GIT set up, you will need to open up your terminal, navigate to your Desktop and type the command:_
`git clone https://github.com/ekthomas25/TEMPLATE.Solution.git`

* _This will clone the repository to your desktop and you will be able to then open the folder in VSCode._
* _Open the terminal in VSCode and navigate to_ `TEMPLATE.Solution > PROJECTFILE` _and type the following command:_ `touch appsettings.json`
* _Copy and paste the following code into the new file:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=TEMPLATE_DATABASE;uid=root;pwd=[YOUR PASSWORD HERE];"
  }
}
* _You will need to input your own password where it says_ [YOUR PASSWORD HERE]
```
* Make sure you are in the project directory folder, run the command `dotnet ef database update`
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to run the project in the browser
* Navigate to http://localhost:5000/ in your browser.

## Known Bugs

* _No known issues_

## License
_[MIT License](https://opensource.org/licenses/MIT)_

_If you have any questions or would like to reach out for any reason, please don't hesitate to send an email to [thomas.elizabeth.k@gmail.com](mailto:thomas.elizabeth.k@gmail.com)._

Copyright (c) 2022 Elizabeth Thomas