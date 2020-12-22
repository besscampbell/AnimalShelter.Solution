# Animal Shelter Web Interface

#### Homework practice Assignment during Epicodus Coding School, ASP.NET Core MVC Web Interfaces, 12.22.2020

#### By Bess Campbell & Danielle Thompson

## Description

Make a program for an animal shelter to track the animals in their facility based on animal type (such as cat or dog). Build out features that let a shelter worker:

Add types of animals to the system. type should be a column on the animals table. A type could be a cat, dog, bunny or any other animal.
Add an animal to the system. An animal should have a name, gender, date of admittance, and breed. When it gets added to the system, it should be added as a particular type.
List animals by breed or type alphabetically.
List animals starting with the ones who have been in the shelter the longest.

## Technologies used

- C# v 7.3
- .NET Core v 2.2
- dotnet script, REPL
- ASP.NET MVC Core
- Razor
- Entity Framework Core
- RESTful Routing, HTTP
- Bootstrap Library
- CSHTML

## Installation Requirements

This project requires the technologies listed in the above 'Technologies Used' section. If you need to acquire any of the above technologies to access this project, please follow the instructions included below.

If you already have the necessary technologies on your local system, the commands necessary for running this console application and its tests will be found at the bottom of the instructions list. 

#### Installing Git
###### For Mac Users

- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users

- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site._
- Follow the instructions in the set up menu.

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/dani-t-codes/AnimalShelter.Solution], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/dani-t-codes/AnimalShelter.Solution.git`.


#### Installing C#, .NET, dotnet script, & MySQL

* Install C# and .Net according to your operating system below. 

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download either the the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* Navigate to the project folder on your Terminal or CMD.
* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 
* `dotnet restore` to install packages listed in project's boilerplate. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :----------------------------|
| **Takes user To Do List item & adds to a list**    | User enters: "Walk the dog" | Return:  |


### Tests

Describe: listIt()
Test: listIt(userInput).toEqual(userOutput)
Expect: listIt("Walk the dog").toEqual("To Do List: Walk the Dog")


## Known bugs

No known bugs as of now. 

### Legal, or License

_MIT_ Copyright (c) 2020 *_Bess Campbell & Danielle Thompson_**