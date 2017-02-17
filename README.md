# "Csharp based Address Book"
### By Melvin Gruschow
### Create February 10th, 2017
### Copy write February 10th, 2017

####Description:

An in browser address book utilizing C# object based programming, with added use of the Nancy Razor framework and view engine to create a user interface via HTML text fields.  

####Specs

User have a home page where they can choose to add a new contact by clicking a hyperlink
  - click
  - new page loads with form to create contact

User may enter information about their contact here, leaving as many fields blank as they wish, then hit the submit button and be taken to confirmation page
  - Melvin Gruschow
  - 555-555-5555
  - Home St, Seattle, Wa
  - Confirmation page appears with button to lead back to home screen

User may repeat said process or choose to delete all their contacts at once, and lead to confirmation page of deletion
  - click Delete all
  - Confirmation page of deleting all contacts, with button leading back to home


### Setup
- clone this repository
- use the dnu restore command in the root directory of the repository
- use the dnx kestrel command in the same location to start the server
- open a browser and go to localhost:5004
