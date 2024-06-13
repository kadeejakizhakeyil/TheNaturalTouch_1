2024-06-06
Web app created w/ VS2022 .NET 7
This is a collaborative project to develope a web application
Team Name:Beta
Team Members:Kadeeja Kizhakeyil(Dev), Olushola Whenu (Test), Naik Vrajkumar Mehulbhai(prod)
Product Name:Towel
Hypothetic Brand Name: The Natural Touch
Created Structure for the product table
confirmed with the attributes

2024-06-10
0010
Ran the program, Confirmed the default works:
https://localhost:7087/
Created README.txt for documentation.
Created a image folder Under root folder
Added a suitable image to the folder
Added a background image to the layout page by editing site.css file

0049
Add a Product class under Model folder
Added 13 attributes for the towel product(Category,Price,Size,Color,Image,Material,FabricType,Pattern,Style,Theme,Shape,Feature)
I Used the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the product model.

0200
Add Migrations feature to create the database
Examine the 20240610055502_InitialCreate migration file:
Confirmed with table creation called Product.
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Products
https://localhost:7087/Products/Create

0239
Once started to input new entries 
Realized data type of Size field needs to be change
Hence it is changed from double to string
and the updated database is
20240610063758_UpdateField
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Products/Create

0256
This project has created with individual account as an authentication type 
This Mvc app created with two database
ApplicationDbContext database runs while executing individual account , 
Executed the command Add-Migration InitialCreate -Context ApplicationDbContext using package manage console
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Identity/Account/Register
Got confirmation message for the account registration
To Confirm the account creation
The URL to confirm
https://localhost:7087/Identity/Account/Login
Successfully login as a test individual account" teacher.123@gmail.com"

0316
Tested the with new entries
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Products/Create
https://localhost:7087/Products/Edit/1
https://localhost:7087/Products/Details/1

1253
Updated two fields in the product table not to allow NULL,  rest all fields set as allow NULL
Form elements need to be change according to the attributes values
Tried to change shape attribute from text element to select form element in createand edit page of product
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Products/Create
https://localhost:7087/Products/Edit/1
https://localhost:7087/Products/Details/1

2024-06-12
2220
Tried to change Category,Pattern and Feature attributes from text form element to select form element in create and edit page of product
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Products/Create
https://localhost:7087/Products/Edit/1
https://localhost:7087/Products/Details/1

2024-06-13
0846
Added Filter option for product Category on product index page 
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Products

1400
Added Rating field to the product table
Updated the Rating Attribute to all the relevant pages.
Migrated database for new attributeRating 20240613183850_Rating.cs
Added SeedData file to insert the entries to the product table
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7087/Products

Test 












