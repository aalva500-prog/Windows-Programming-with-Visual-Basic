# This is a Planner Application built using VB.NET syntax.
# Purpose: Store Task Information within Files

**PlannerApp Form logic:**
  *1 The Files listbox will be initially empty, but will have the FileNames
  added to the listbox on Create or Open click event.
  *2 The Create File Button on click should use the FileName textbox for
  filename and the StreamWriter to create a file, and then open the Task
  Details form for entry of task information.
  *3 c. The Open File Button on click should use the OpenFileDialog control to
  allow the user to select a filename, populate the FileName textbox with the
  selected filename and use the StreamReader to open the file, loop until end
  of file using ReadLine() to populate Details listbox and then show the
  Details form to display a list of task information.
  *3 The Exit Button on click will close any open file and end the application.
  
  
**PlannerDetails Form logic:**
  *1. Add Button on Click should add Name, Date, Time, Complete, and Category values to the Details listbox using the TaskInfo structure, then clear the values from TextBoxes, Label and uncheck Complete.
  *b. Remove Button on Click should remove selected item in Details listbox.
  *c. The Color Button on click should use color dialog, to allow selection of color and then populate the Category label and font color.
  *d. Using _SelectedIndexChanged and the selected item in Details listbox, should populate Task, Date, Time, Complete, and Category fields.
  *e. The Save and Cancel buttons should initially be disabled and only enable when Create File is clicked and the Details listbox is not empty.
  *f. Save Button on Click should using StreamWriter loop through the Details items and WriteLine() to write each record to file, then close/hide form.
  *g. Cancel Button on Click should first prompt the user YES/NO? For YES do not save to file, then close/hide Details form. For NO do not save to file, but stay on Details form.

