# SP23-Customizing the Features and Gesture Elicitation on Open Brush

Open Brush is a free fork of Tilt Brush, a room-scale 3D-painting virtual-reality application available from Google, originally developed by Skillman & Hackett. Our group from CSU deployed the application and incorporated ways to improve the use of base brush by creating custom brushes that can be implemented by users not wanting to use the base brush.

![Instructions_HCI](https://user-images.githubusercontent.com/101088744/236285083-7ea8b44e-8a4f-4501-b570-df140fcf0568.jpeg)


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

### Building the application from the Windows command line
Use the build script in the Support/bin directory to specify the target platform and the build options you wish to enable. Run build —help to see the various build options.

### Experiencing Build Errors?
* Use the following link for troubleshooting **https://levelup.gitconnected.com/unity-command-line-build-error-the-only-standalone-target-supported-is-windows-x64-with-openxr-ef0bec06e5**

### VR set not detected? 
* Easy fix in this **URL** **https://www.tomsguide.com/how-to/how-to-connect-oculus-quest-2-to-a-pc** for a step bystep connection guide

## Video Links :
 * Short overview video  **URL** ** https://youtu.be/H7eZV6DcjPo**
 *Presentation video **URL** ** https://youtu.be/kgu4FJZbFAI**
 *Explanation of code and experiment video **URL** ** https://youtu.be/XNQ1_BivUzw**

## Acknowledgements
* Thank you to the Tilt Brush developers for your amazing work and for finding a way to open source the app! 
* [SiMonk0](http://www.furjandesign.com/) for the great new logo!
* The [SideQuest](https://sidequestvr.com/) team for your support.
* [VR Rosie](https://twitter.com/vr_rosie) for promotional artwork, banners, and videos.
