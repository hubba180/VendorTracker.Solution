# _Pierre's Vendor Trackor_
#### _This application is a practice with C# using MVC architecture to build a project, 2020 ver 1.0.0_
#### By _Kyle Hubbard_
(https://github.com/hubba180/VendorTracker.Solution)
## Description
_The purpose of this application is to buld off of a previous project of mine called Pierre's Bakery. The premise is to build an application using MVC (Model View Controller) architecture to build out a site that tracks vendors ordering from Pierre's Bakery._
## Setup/Installation Requirements
* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program
__
## Specs
| Behavior    | Input | Output | Status |
| :---------- | ----- | ------ | -----: |
| Program initially lands on a home page offering links to vendor list |  |  | Green |
| User may view a list of vendors they've added | Tommy's Tacos | -Tommy's Tacos | Green |
| The user will see a message if no vendors are added to list |  | "There are no vendors associated with your store yet." | Green |
| User may add to a list of Vendors | Tommy's Tacos | Tommy's Tacos | Green |
| User may add a description to each vendor | "Great Food" | "Great Food" | Green |
| User may create an Order to be affiliated with a vendor | Tommy's Tacos - 12 bread | Tommy's Tacos - Order for 12 bread | Green |
| User may add more properties to an order | 12 bread, $25, 7/24/2020 | 6 bread, $20, 7/24/2020 | Green |


## Known Bugs
_No known bugs_
## Support and contact details
_Contact Kyle Hubbard <kyle.james.hubbard@gmail.com>_
## Technologies Used
_The Technologies used in the making of this software was Visual Studio editor, Mac, C#, .Net_
### License
Copyright (c) 2020 **_Kyle Hubbard_**