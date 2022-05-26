INSTRUCTIONS ON HOW TO RUN AND EDIT POS_VisualBasic solution

1. Install Microsoft Visual Studio 2019 (Community Version) and select all the .NET Framework 
   options during installation to recieve full capability of .NET Framework packages and libraries
2. Open Microsoft Visual Studio 2019 and on the get started options select open a local folder
3. Select the folder containing the POS_VisualBasic solution and open the folder
4. Once open, the solution explorer will display the solution on the right-hand side. 
   Double-click on POS_VisualBasic.sln to open the solution file options
5. Next double-click on Form1.vb to open up the Form1.vb[Design] file Note:this will display the file used 
   for the user interface.
6. There is an arrow to the left of the Form1.vb file click on it as it is a drop down menu
7. From this drop down menu double-click on Form1 to edit and see all the code for the button functionality.
   Alternatively, you can go on the Form1.vb[Design] and double click on the user interface on any button to bring
   up all the button, panel and DataGridView code.
8. In the same drop down menu also double-click Dispose(Boolean) to bring up the code used for creating
   the buttons, panels and DataGridView code
9. On the Form1.vb[Design] you can right click on the buttons and select property to edit the text contained
   within the button or its object name or even the physical appearances and color of the buttons.
10. To run the code simply click on the >Start option on the toolbar above and a new window for the application will appear

Structure of files:

Form1.vb - This file is used to create event handlers and utilize event driven programming for 
           allowing functionality of buttons when clicked on the actual application.
	   All of the code for the calculations, data manipulation and data binding will occur on this file.

Form1.vb[Design] - This file is meant to be used with the windows forms tool box for ease of creating a user interface layout
		   and helping manipulate buttons, panels, toolboxes, comboboxes, etc. on the user interface.
		   This file allows developers to easily position these objects.

Form1.Designer.vb - This file allows buttons to utilize the event call functionality. The code here creates buttons, toolboxes, etc.
                    and allows access to these objects from the scope from which they are defined.
		     
