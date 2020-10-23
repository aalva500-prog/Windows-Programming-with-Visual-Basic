Contact Info Application.
Purpose: Store Contact Info within Database.

DisplayContactInfo Form logic:
  a. The Contact Info will be initially empty, but on Open will display the first Contact record from the Contact table.
  b. The Open Button on click should instantiate data object in the data layer, which will open the database using ADO.NET and TableAdapter, then set screen values based on the Datasource.
  c. The Next Record should display the next data record.
  d. The Previous Record should display the previous data record.
  e. The Exit Button on click will close the database and end the application.
 
EnterContactInfo Form logic:
  a. The Contact Info will be initially empty, except ComboBox, which should be loaded with specified values.
  b. The user should be able to enter all data values based on data types.
  c. Save Button on Click should add all values to the Contact, then clear the values from TextBoxes.
  d. Clear Button on Click should clear all values from the TextBoxes.
  e. Close Button on Click should close/hide form without saving data.
