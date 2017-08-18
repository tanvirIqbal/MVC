<b>Short Note:</b><br>
<b>*** Different mechanism to pass data in mvc ***</b>
1. action to action 
2. action to view 
3. controller to a view 

In mvc 
no view state
no behind code
no server controls

In mvc 3 different mechanism to pass data in mvc
1. Viewdata/ViewBag
2. TempData
3. Session variable <br>

<b>Viewdata/ViewBag</b>
controller/action to view = viewdata/viewbag.
Viewbag simplifies the viewdata syntex.
But viewbag use dynamic keyword, so there is performance issue. viewdata is better. 
When getting the data from viewdata we might need to cast or convert the data.
When getting the data ffrom viewbag we dint need to cast or convert the data.
Viewdata does not maintain data from action to action or from controller to controller. 
When View is rendered the ViewData & ViewBag are emptied.<br>

<b>TempData</b>
To pass data from action to action or from controller to controller we use tempdata. 
tempdata cannot survive in 2nd request unless-
1. tempdata preseves value if the tempdata is not read. 
2. if you read tempdata value and then call keep method, the tempdata value is preserved.
3. if you read tempdata value with peek method, the tempdata value is preserved.
tempdata internally use session variable.<br>

<b>Session variable</b>
session variable will survive different request until the browser is closed.

why 3 different mechanism?
To optimise server memory,  
Gurbage collector collects data after finished.

Choose wisely. 

<b>*** Validation ***</b>

Need Concept:
1. Attributes
2. Data Annotation
3. Regular Expression

Data annotations are attributes which helps to do validations. They are applied on the Model class.
Regex is a pattern matchining technique.

When a model object is filled with data, the validation happens. If any error occurs, it goes to the Model State class.  

Model binding wont work with validation.

HTML Helper class helps to create UI 

Using validation with Data Annotation is a server side validation. When we submit the form it post back to the server and validation happens. 
If we want client side validation, we use jQery. We need to add 3 js file to our view.
1. jquery
2. jquery.validate
3. jquery.validate.unobtrusive

we need to use both client side and server side validation because client might turn off js in their browser. 

<b>*** ViewModel in MVC ***</b>

We know when a user requests a view,
the request comes to the controller
then controller gets the model data
then controller gets the view
then controller binds the model data to the view
then show it to the user.

Now
1. Where should I put my Presentation Logic?
2. Where should I put my Data Transformation Logic?
3. How to create a strognly typed view of multiple model?

We need to create a ViewModel class. In that model class we put our Presentation Logic and Data Transformation Logic.

We can put our Presentation Logic and Data Transformation Logic in the view but ViewModel makes it simpler.


<b> *** MVC with EF (Code First) *** </b>

This is a code first example. You have your Model and View. In your Model 1 field/property must be a KEY.

1. Create a table (Customer) in the Database
2. Add EF in your project using Nuget Manager.
3. Create a Data Access layer folder DAL
4. Create a DAL class (CustomerDAL).
5. Add a connection string in Web.Config file. Connnection string's name should match the DAL class.
6. Map your Model (Customer) to the database Table in the DAL class.
7. Now in the Controller, use this DAL clase to Insert,Update,Delete,Read in/from the Database.
