# Ping Pong

#### C# practice for Epicodus, 07.13.2020

## By Brittany Lindgren & Benjamin Russell

## Description

Create an app that will replace numbers with ping, pong or ping-pong depending on what numbers they are divisible by.

## Setup/Installation Requirements

| Steps | Example |
| -------- | ----- |
|  1. Follow this [link to the project repository](https://github.com/LINDGRENBA/ping-pong-2) on GitHub.   |    |    
|  2. Click on the "Clone or download" button to copy the project link.   |   ![Image of GitHub Clone or download button](img/readme/clone-download-button.PNG)   |   
|  3. If you are comfortable with the command line, you can copy the project link and clone it through your commad line with the command `git clone`. Then run the command `npm install` followed by `npm run build`. Otherwise, I recommend choosing "**Download ZIP**".   |   ![Download ZIP option on GitHub](img/readme/download-zip.PNG)  |   
|   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.   |   ![ZIP folder in downloads](img/readme/zip-folder.PNG)  |   
|  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.    |   ![Saving ZIP to new location with 'Copy To'](img/readme/copy-to.PNG)  |   
|  6. Navigate to the final location where you have chosen to save the project folder.   |     |   
|  7. To view the code itself, right click, choose "open with..." and open using a text editor such as VS Code or Atom, etc.   |     |


#### Additional Setup/Installation Notes:

* You do not need to run a server to view this document.

* No additional code is necessary to view this project.   

## Specifications

| Behavior | Input | Output |  Completed(Y/N?)  |
| -------- | ----- | ------ | -------- |
| 1. A user a number and the program will count out every number up to the user input | 15 | 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 | Y |
| 2. All numbers divisible by 3 will be replaced with "ping" | 5 | 1,2,"ping",4,5 | Y |
| 3. All numbers divisible by 5 will be replaced with "pong" | 5 | 1,2,3,4,"pong" | Y |
| 4. All numbers divisible by 3 and 5 are replaced with "ping-pong" | 15 | 1,2,3,4,5,6,7,8,9,10,11,12,13,14,"ping-pong" | 4 |

## Known Bugs

| Bug | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | ------ | --------- |
| 15 is replaced with ping instead of pong | N | Placed condition for numbers divisible by 3 AND numbers divisible by 5 first in branching logic |


## Support and contact details

Please feel free to contact me through GitHub (username: LINDGRENBA) with any questions, ideas or concerns.  

## Technologies Used

* C#
* .NET Core 2.2
* Visual Studio Code 
* Git and Git BASH 


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_Brittany A Lindgren & Benjamin Russell 