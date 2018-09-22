EShopPrototypeWinConsole
=======
This is a base template for basic C# e-commerce projects.


Why Console app?
--------
- It is basic
- Easy to re-implement in other types of projects
- Small since it does not have many compoenents 
- The structure is easy to navigate/


Structure
-------
- Domain: Contains all the business models(classes) for the app to work with and repository interfaces
- Data: Contains repositories for the domain models
- Common: Contains all the basic libraries such as logging
- UI: Contains user-interface AKA console which will serve as a simple representation example
- Tests: Contains additional projects for each class independantly
