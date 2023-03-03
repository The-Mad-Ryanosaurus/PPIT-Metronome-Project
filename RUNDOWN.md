# Professional Practice in IT - Rundown of Project
## Metronome Project
### Group Project by: Ethan Conneely – G00393941 and Ryan Harte – G00338424

## Rundown Summary
Our project focuses on two main pieces of software. Unity and Augmented Reality (AR). The original Metronome that was being used was an mp4 file. We have taken the concept of that Metronome and rendered/built it in a 3D environment using Augmented Reality. A user can now see the Metronome in a real-world space no longer hindering their vision unlike the original mp4 files.

## Project Outline and Goals
The following is a list of tasks that by the end of development we hope to have accomplished to deliver a revitalised product that we feel will be a huge improvement on the original mp4 files.
1.	The Metronome built and moving across its curve line.
2.	Metronome Working in a 3D space in Augmented Reality.
3.	Tracking of Head Movements to the user’s specification (Metronome locked on the x axis and cannot move up or down).
4.	User adjustable settings for the Metronomes height and distance it appears from a user, its speed back and forth and the Metronomes ball size.
5.	Sound working so that when the Metronome hits both ends of the curve it makes a ticking noise. (Can be turned on or off by a user).
### What is accomplished so far?
So far goals 1-4 have been accomplished. Goal 5 is being worked on currently. What we need now is feedback so we can adjust the application to our customer/clients' specifications, if they have any.

## Project Architecture 
Out tech stack for the project was a mix of Unity, Android, and the Moverio SDK.
Unity was used to build out the 3d scene and integrate the view from the AR glasses into the scene.
Andoid was our build target and how we debugged and tested the app.
Moverio SDK was used to get specific headset data into unity.

## Project Build
The following will explain how we have developed our project so far.
The application started in Unity where we began using and testing the headset for tracking ability via its gyroscope. It was quite easy to use as it is an android device and as such all that was required was to switch the build environment from unity to android and use unity remote 5 for testing. We then added the Moverio sdk (software development kit) to our project application and that gave us access to more functionality in the headset such as being able to go from a 2D view to a 3D view in our application. A grid was then built-in unity to mimic the floor so we could see just how well the tracking and viewing of the world would look in real time. After this the curve and ball for the Metronome were built in blender. Blender is a 3D computer graphics software application that allows for the building of 3D models and much more. Once that was done, we imported the Metronome into unity and from there created a animation curve for the ball to move along. After this a user interface was implemented to allow setting changes for the Metronome. Our next goal is to get user feedback and to research better devices the customer could potentially use.

## Epson Moverio BT-300 Problems – Headset Tech Specifications 

## OPTICAL
- Driving Method Mono Crystalline Silicon Active Matrix
- Display Size 0.43 inch wide panel (16:9)
- Pixel Number 921,600 pixels (1280 RGB x 720)
- Refresh Rate 30 Hz
- Field of View 23 degrees (diagonal)
- Screen Size (Projected Distance)40 inch at 2.5 m - 320 inch at 20 m
- Colour Reproduction 24 bit-colour (16.77 million colours)

## MOVERIO OS PLATFORM
- OS Version Moverio OS
- OS Update Via network
- Pre-installed Application Live wallpaper, Moverio Apps Market, Moverio Air, Moverio Mirror (for WiFi Miracast)

## SENSORS
- Camera 5 Megapixel
- GPS Yes, in Controller
- Compass Yes, 3-axis in both Headset and Controller
- Gyroscope Yes, 3-axis in both Headset and Controller
- Accelerometer Yes, 3-axis in both Headset and Controller

## CONNECTIVITY
- Wireless LAN IEEE 802.11a/b/g/n/ac with Wi-Fi CERTIFIED™, Miracast® (source/sink) ODFM, DS-SS
- Bluetooth Bluetooth Smart Ready Class2 (2.5 mW, 10 m), V4.1 support profile: HSP/A2DP/HID/OPP/SPP/AVRCP/PAN

## CPU AND MEMORY
- CPU Intel Atom x5 1.44GHz Quad Core
- RAM 2 GB
- Internal Memory Approx. 16 GB (including Moverio OS)
- USER INTERFACE
- Touch-pad Pointing Method Capacitive Multitouch
- Function Key Power, Home, Recents, Back, Function (Lock, Brightness, 2D/3D), Volume (+/-)

## SUPPORTED FILE FORMATS
- Video MP4 (MPEG4/H.264+AAC), MPEG2 (H.264+AAC), VP8
- Audio WAV, MP3, AAC
- 3D Supports Side By Side

## SOUND OUTPUT
- Sound Output Maximum Audio Output Level: 150 mV GENERAL
- Operating Temperature 5° C - 35° C, 41° F - 95° F, 20 % - 80 % Humidity
- Power Supply Voltage Controller 5 V, 900 mA via micro USB terminal
- Power Supply Voltage AC Adapter 100 - 240 V AC +/- 10%, 50/60 Hz with micro USB cable
- Battery Life 6 hrs
- Battery Type Li-Polymer
- Dimensions: Headset 178 mm x 191 mm x 25 mm (D x W x H) (without light shielding)
- Dimensions: Controller 116 mm x 56 mm x 23 mm (D x W x H)
- Weight Headset69 g (excluding cable)
- Weight Controller 129 g
- Warranty 12 months

## WHAT'S IN THE BOX
- Moverio BT-300 Smart Glasses
- AC adapter
- USB cable
- Carrying case
- Inner ear Earphone with Microphone
- Shade x2 (light and dark)
- Inner frame for optical lenses
- Temple rubber x2
- Quick Setup Guide
- User Manual

## Problems
Glasses are not capable of spatially tracking the headset so the head bobbing will not be counteracted, but the glasses are able to track rotation, via the headset’s gyroscope, so we are able to keep the metronome aligned with the horizon (the height it’s positioned at) with the added allowance of customization to the metronome’s height, distance and speed by the user. Lack of ability for headset to anchor the metronome doesn’t solve main head bobbing issue. So, what is the solution? 
The headset has very little in terms of power as you can see from the specifications above and with only one camera it is impossible to triangulate a person’s position for the following reasons. The camera works the same as any mobile device. It is capable of recording and taking pictures but unlike other AR headsets (such as the Microsoft Hololens) it cannot recognise a real-world space with a person standing at its centre. We can project videos/applications and many other forms of media to the headset’s lenses while a user is wearing them.
This is what we have done with our project to make it work as best it can on such a piece of technology. In unity we have 3 cameras added to a scene to generate our metronome in a 3D environment. These cameras mimic a users’ head/eyes. Tracking then works via the headset’s gyroscope so that when a person’s head moves, the cameras in unity move. The metronome then follows the users’ movements at the same parameters mentioned earlier. In doing this we eliminated the mp4’s dark background that the original file had and have a metronome now moving while a user can see their surroundings. 

## Solutions 
The lack of ability to anchor the metronome due to the headsets lack of capabilities to do so means the only solution is to develop this application on a headset that is capable. A Microsoft Hololens would be the only headset currently we feel is capable doing so. (add in why here)
