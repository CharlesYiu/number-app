# Number App
A MacOS based number editing app made for practice
# Information
- Uses Xamarin.Mac
- The number 0 will be the default
- Opens .number files (basicaly numbers in .txt files)
- The app only supports non-decimal numbers
# Latest Updates
## Features
### Directly edit numbers
You can type numbers into the app.  
#### Usage:
On the top bar when focused to the app, Edit -> Change.  
If you want to stop editing, you can either press return or go to Edit -> Stop Changing.
### Copy and Paste
The ability to copy and paste numbers.  
**Paste:** The number pasted will be parsed from text to number.  
**Copy:** The number copied will be in text.  
### Reset number
Resets the number to it's default value.
## Issues
### Parsing files to numbers
**Past behavior:** Defaults 0 when there is an error parsing.
**Changed behavior:** Reformats characters before parsing.
(E.g. "ab-c1de-2fg3h" will be reformated to "-123" before parsing)
### Files with decimal points
**Past behavior:** Decimal points are just shown.
**Changed behavior:** Decimal points will be rounded off.
# Controls
## Basic
### Left click
Adds 1
### Right click
Subtracts 1
## Trackpad only
### Rotate left
Changes the number to negative
### Rotate right
Changes the number to positive
### Magnify in
Adds 1 repeatedly   
(When the number is negative it will subtract instead)
### Magnify out
Subtracts 1 repeatedly   
(When the number is negative it will add instead)
