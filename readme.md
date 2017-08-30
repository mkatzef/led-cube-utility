# LED Cube Utility

A tool to set the image for an LED cube to display.

## Getting Started

The utility is contained in a Visual Studio Project. Please run the most recent build (`LED Cube Utility\bin\Debug\LED Cube Utility.exe`).

### Prerequisites

To run LED Cube Utility, the host machine must have the following installed:
* `Windows (7/8/8.1/10)`

### Running

The tool may be started by running the executable named `LED Cube Utility.exe` found in `LED Cube Utility\bin\Debug\`, or by running the shortcut `LED Cube Utility Shortcut` in the root directory of this project.

### Plan workflow
Create new image:  
1. Select File > New  
2. Select cube dimensions  

Open existing image:  
1. Select File > Open  
2. Direct utility to an existing cube image file  

Editing  
1. Select current layer from drop-down box  
2. Toggle pixels by clicking on buttons in a grid  
Optional  
a. Select Edit > New Frame  
b. Select Edit > Frames > Frame number  
c. Select Edit > Fill Layer  
d. Select Edit > Clear Layer  
e. Set frame duration using text box  

Saving  
a. Use keyboard shortcut Ctrl+s  
b. Select File > Save  
c. Select File > Save as... > direct tool to location, provide file name

Programming a device  
1. Select Tools > Program Image  
2. Select COM port from drop-down box  
3. Select Baud rate  
4. Observe progress and/or status messages  

### Save file format
A single JSON object containing the following fields:  
- Cube width
- Cube length
- Cube height
- Number of frames
- Array of frame durations in milliseconds. Has length "number of frames".
- Array of frame arrays. Has length "number of frames", where each item is an array of "cube height" arrays of "cube length" arrays of length "cube width".