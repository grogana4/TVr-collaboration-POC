# TVr: a collaboration space proof of concept
This was a proof of concept I created during an internship during the COVID-19 pandemic. the POC was in line with the current mindset at the time of the pandemic to create an easily accessible collaborator space with a casual environment, allowing teams to perform MEttings such as scrums. This did not got picked up, and the company has allowed me to publish this project as open source. This was created in Unity, assets including the office supplies, furniture were found in the free sections of the Unity asset store or shapes created in unity, and the VR rig, openXR, was also found in Unity. The main TVr scene and all coding scripts related to the video player whiteboard and sticky notes were created by me.

## Warning
This code was run and tested using an Oculus Rift initially, and while I know there is compatability with the Quest 2, other VR systems such as the VIVE and the Valve Index, may not work for this POC, the controls may also be a little different, so keep this in mind. You will also need unity Version 2019.4.3f1 to check the code

## Features
- Video Player with video playlist and controls (play/pause, fast-forward, rewind, next/previous video)
- sitcky notes with built in keyboard
- interactive whiteboard

## How to run and play
you can select the TVr folder if you wish to examine the code in the Unity editor, or the TVR_demo, if you wish to just try the program. 

#### Movement
The main movement is teleportation Pads, which are the red circles across the floor, you can select them by moving your stick/touchpad towards a teleport pad. when the touchpad lights up, release the stick and you will teleport to that spot.

#### Video Player
when you start the program, you will be standing in front of a TV, you can use grip on  one of the many remotes in front of you and use trigger to activate the command on the remote, including play/pause, fast-forward, rewind, next/previous video.

#### Whiteboard
To the east of the room, there is a whiteboard. To use it, grab a marker on the board using grip and move the tip along as if you were writing on an actual whiteboard. Your writing should appear on the whiteboard. you can also use the eraser in a similar fashion to remove the writing.

#### Sticky Notes
Beside the whiteboard, there is a block of sticky notes on the wall. To use a sticky note, use grip to grab one (if you let go, the sitcky note with float in the air), and press trigger. This will open a built-in keyboard. you select keys using the green rectancle above your hands. hover over the key with the rectangle and press trigger to type onto the sticky note. After typing, grab the note again and press trigger to hide the keybord.
 
#### Quit
To quit the game in the dmeo version, pick up the remote in the southeast end of the room that's on the table using grip and use trigger to quit the game.

### Hopefully you find this project useful!
