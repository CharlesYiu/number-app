# Number App
A MacOS based number editing app I made for practice
# Build
## Reqirements
- [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
- [Xcode](https://developer.apple.com/xcode/)
- [MacOS](https://www.apple.com/macos/)
## Steps
1. Download all of the files and put it all in a folder
2. Open the file "Number.sln" from the project folder with Visual Studio
3. On the top left of Visual Studio, change the compiler configuration from "Debug" to "Release" 
4. On the top bar, click Build -> Build Number
5. After the app is built, you will find the application in \[project folder]/bin/Release/
# Features
## Directly edit numbers
You can type numbers into the app.  
### Usage:
On the top bar when focused to the app, Edit -> Change.  
If you want to stop editing, you can either press return or go to Edit -> Stop Changing.
## Copy and Paste
The ability to copy and paste numbers.  
**Paste:** The number pasted will be parsed from text to number.  
**Copy:** The number copied will be in text.  
## Reset number
Resets the number to its default value.
## Decimal points
The app can add or minus numbers with decimals
## Preferences
Customize the behavior of the app.  
**Default value:** The value to use when there is a reset or new file.  
**Add value:** The preferred value to add.  
**Minus value:** The preferred value to minus.  
## Files
The ability to save, load, and create .number files.
# Controls
## Basic
### Left click
Adds 1 or the preferred value
### Right click
Subtracts 1 or the preferred value
## Trackpad only
### Rotate left
Changes the number to negative
### Rotate right
Changes the number to positive
### Magnify in
Adds 1 or the preferred value repeatedly   
(When the number is negative it will subtract instead)
### Magnify out
Subtracts 1 or the preferred value repeatedly   
(When the number is negative it will add instead)
# Shortcuts
## Change number
Command+e
## Reset number
Command+r
## Preferences
Command+comma
