# Group Project: Book Store Application

**This application is used to purchase Books from a Book Collection. The customer comes to the store and requests to purchase titles. The employee enters the titles and quantities in the application and produces an invoice/receipt for the customer.**

As part of a team and using the BookStore (mdf) database partially developed, our team worked together to generate an object-oriented design, and multi-tier application called BookStore to purchase from titles with shopping cart. The design includes the classes, associated data, operations of the classes, and the multi-tier application that uses VB.NET logic to implement each of the classes. In addition, we designed and implemented the GUI using Windows forms and controls to create the objects, provide access to each object’s data properties and processing methods.

**The sections I developed were the "Shopping Cart Section" with all the Sales processing and the "Summary Screen", the "Login Section", the design of the "Main Form", the "Reports Screen" with all its functionalities, and all the forms related to the Publishers maintenance part. Furthermore, as I was the leader of the Group, I had the duty of correcting any errors before submitting the final product.**

**The following functionalities were required:**
* Design a maintenance screen for tables, to enter Titles, Authors, and Publishers
* Design a shopping cart order screen that includes these features:
  * Provide a means to search for and select a product by partial title by getting 
    the information from the database.
  * Allow a single purchase to include multiple titles, and any quantity of each product.
  * Show the current order subtotal, tax, and total when each product is added to the order. 
    Whenever a title is added or updated in the order, adjust the totals for product cost, tax, 
    and total order cost shown on the form.
* When the user commits the order, using a single ord_num, insert records to the Sales table 
  for each item ordered.
* Sales ord_num values should be automatically assigned.
* Design a summary screen to display invoice/receipt “report” showing the order, the items ordered, 
  total product cost, tax, and total order cost. This should be displayed for confirmation after order.
* Design a screen that allows for selection of start / end date, time ranges and button to produce a 
  formatted “report” file containing all items sold within a selected time range. Include Ord_Num, 
  TitleId and Title, qty, ord_date, and total value of sold products. Sort by ord_date.
* Ensure that menu allows access to maintenance, order and report screens.

## Video Walkthrough

Here's a walkthrough of the app:

<img src='walkthrough.gif' title='Video Walkthrough' width='' alt='Video Walkthrough' />

GIF created with [LiceCap](http://www.cockos.com/licecap/).
