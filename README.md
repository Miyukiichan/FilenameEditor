# Filename Editor

This is a graphical tool used to rename whole directories of files in an editor. 
This works well in combination with other powerful text editors such as vim to edit names quickly.
An installer project is included which will add a context menu item for folders that will open the app.
To use this with other editors, use the (File | Open Current Folder in Editor) action which will update the buffer on save.
You can then press the rename files button to process the selected files.

## Todo

### GUI Project

- Create separate project to launch the GUI
	- Use this project as the launcher for the context menu item.
	- This will be safer than running managed code from the windows shell.

### Console Project

- Create console app that just does the following
	- Internally open a whole folder for editing
	- Open the files directly into the preferred text editor
	- Apply the file changes and exit
- This will be a more stremlined program that will require a separate installer and possibly another installer for the combined projects
	- Alternatively, a single installer with component options
- Also need to create another console app to launch that app in order to not run managed code from the windows shell
- Need to reoganise the main GUI project to use a controller architecture for doing the actual funtionality and split everything up into functions to make things easier
