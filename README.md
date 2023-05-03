# SP23-Gesture-Elicitation-Using-Open-Brush

Open Brush is a free fork of Tilt Brush, a room-scale 3D-painting virtual-reality application available from Google, originally developed by Skillman & Hackett. Our group from CSU deployed the application and came with improved ways to ease the use of base brush by creating custom brushes that can be implemented by users not wanting to use the base brush.

## Building the application
Get the Open Brush open-source application running on your own devices.

### Prerequisites
Unity 2021.3.9f1
Python 3 (Optional — needed only if you wish to run the scripts in the Support/bin directory) Tested with Python 3.8.
### Running the application in the Unity editor
Follow these steps when running the application for the first time:

1. Start Unity.
2. Go to File > Open Scene. \
3. Select /Assets/Scenes/Main.unity. Unity should automatically prompt you to import TextMesh Pro.
4. Choose Import TMP Essentials.
You can also do this through Window > TextMesh Pro > Import TMP Essential Resources.
Press Play.
These steps have been tested with Release 1.0.54.

### Building the application from the Unity editor
Although it's possible to build Open Brush using the standard Unity build tools, we recommend using a build script to ensure the application builds with the correct settings. To run this script, go to Open Brush > Build > Do Build, or build from the Open Brush build window by navigating to Open Brush > Build > Build Window.

Note: The application may take a while to build the first time.

Building the application from the Windows command line
Use the build script in the Support/bin directory to specify the target platform and the build options you wish to enable. Run build —help to see the various build options.

####

#### OCCULUS QUEST NOT CONNECTING PROPERLY? 
* Go to the following **URL** **https://www.tomsguide.com/how-to/how-to-connect-oculus-quest-2-to-a-pc** for a step bystep connection guide

## Acknowledgements
* Thank you to the Tilt Brush developers for your amazing work and for finding a way to open source the app! 
* [SiMonk0](http://www.furjandesign.com/) for the great new logo!
* The [SideQuest](https://sidequestvr.com/) team for your support.
* [VR Rosie](https://twitter.com/vr_rosie) for promotional artwork, banners, and videos.
