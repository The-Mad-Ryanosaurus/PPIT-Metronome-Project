
![](RackMultipart20230427-1-8qja12_html_9b0a9387ae1d3017.png)

# Professional Practice in IT

# Metronome Project

By
Ethen Conneely: G00393941 and Ryan Harte: G00338424

Supervisor
Damien Costello


## Project Summary

The project aims to solve a medical impediment with a software solution using AR Technologies and Visual Software Aids. It is being developed for a client that has mobility issues and we have learned how to create software specifications that meet client requirements by analyzing their needs and listening to their feedback.

## Background

At the very start of the semester our project supervisor gave us a choice of three projects to choose from. We chose this project for several reasons but the main ones being that it combined a development environment we both know and love (Unity) with an area of technology we had never touched on before (Augmented Reality). The project itself is being developed to aid in our client's ability to walk. It was found that visual aids help greatly in our client's ability to get from point A to B, as this project started as a bicycle helmet with a windshield wiper going back and forth. As the project progressed it eventually landed us to create an AR solution so that our client would be able to use a visual aid in a real-world setting.

## Technologies Used for Development
Augmented Reality (AR), Unity and Blender

### Augmented Reality (AR)

Augmented reality (AR) is an interactive technology that seamlessly blends digital elements with the real world, enhancing the user's perception of their environment. By overlaying digital information, such as images, sounds, or text, onto the user's view, AR provides a composite experience that bridges the gap between the physical and virtual realms. Unlike virtual reality (VR), which completely immerses users in a computer-generated environment, AR allows users to maintain their connection with the real world. This distinction enables AR applications to support a wide range of practical uses, including navigation, education, entertainment, medical and professional tasks, by enriching the user's experience with contextually relevant digital content.

For our project this technology was essential as our client wants to be able to use (what we have dubbed) "The Metronome" visual aid in the real world.

### Unity

Unity Engine is a user-friendly and versatile tool that empowers creators to design and build both 3D and 2D content for various platforms, including computers, gaming consoles, smartphones, and websites. Developed by Unity Technologies, this game engine simplifies the development process by providing an array of helpful tools and features accessible to developers with different skill levels.

Unity works with multiple programming languages, but C# is the primary choice for scripting and is the language used for our projects development. The engine's adaptability and convenience have made it a popular option not just for game development, but also for crafting simulations, virtual and augmented reality experiences, and architectural visualizations. To make development even smoother, the Unity Asset Store provides a large collection of ready-to-use assets such as models, textures, and scripts.

Unity Engine is an excellent tool for developing AR applications due to its built-in compatibility with popular AR frameworks and libraries. By integrating these AR development kits, Unity streamlines the process of creating immersive AR experiences.

### Blender

Blender is a versatile, open-source 3D graphics software that people use for a variety of creative projects, like crafting 3D models, animations, visual effects, and even video games. Its comprehensive set of tools covers everything from modelling and sculpting to texturing, rigging, and rendering. Blender also offers features for video editing and compositing.

Using Unity and Blender together is a common approach in game development and other interactive projects. Blender excels in creating 3D models and for our project we used it to create the curve the metronome travels over and back on.

## Project Outlines/Goals

The project was split into two parts.

1. The Epson Moverio BT-300
2. The Microsoft Hololens

For a spec comparison see the end of the document.

Our client, when development started for this project, was using the Epson Moverio BT-300 (Moverio) headset that had an .mp4 file on it with a ball moving back and over on a red curved line. Our jobs for this project were to greatly enhance that in several ways.

- Project working in a 3D Space (AR).
- Tracking of Head Movements to the user's specification (Metronome locked on the y axis and cannot move up or down).
- User adjustable settings for the Metronomes height and distance it appears from a user, its speed back and forth and the Metronomes ball size.

## Epson Moverio BT-300

The application started in Unity where we began using and testing the headset for tracking ability via its gyroscope. It was quite easy to use as it is an android device and as such all that was required was to switch the build environment from unity to android and use unity remote 5 for testing. We then added the Moverio software development kit (sdk) to our project application and that gave us access to more functionality in the headset such as being able to go from a 2D view to a 3D view in our application. A grid was then built-in unity to mimic the floor so we could see just how well the tracking and viewing of the world would look in real time. After this the curve and ball for the Metronome were modeled in Blender. Once that was done, we imported the Metronome into Unity and from there created an animation curve for the ball to move along. A user interface was then implemented to allow setting changes for the Metronome. Movement was tracked using the headset inbuilt gyroscope.

### Moverio Problems

Glasses are not capable of spatially tracking the headset so issues with quick head movements will not be counteracted, but the glasses are able to track rotation, via the headset's gyroscope, so we are able to keep the metronome aligned with the horizon (the height it's positioned at) with the added allowance of customization to the metronome's height, distance and speed by the user. Lack of ability for the headset to anchor the metronome doesn't solve the issue for quick jarring head movements which is an issue for our client. The headset has very little in terms of power as you can see from the specifications above and with only one camera it is impossible to triangulate a person's position for the following reasons. The camera works the same as any mobile device. It is capable of recording and taking pictures but unlike other AR headsets (such as the Microsoft Hololens) it cannot recognize a real-world space (due to lack of Spatial Mapping) with a person standing at its centre. We can project videos/applications and many other forms of media to the headset's lenses while a user is wearing them. This is what we have done with our project to make it work as best it can on such a piece of technology. In Unity we have 3 cameras added to a scene to generate our metronome in a 3D environment. These cameras mimic a users' head/eyes. Tracking then works via the headset's gyroscope so that when a person's head moves, the cameras in unity move. The metronome then follows the users' movements at the same parameters mentioned earlier. In doing this we eliminated the mp4's dark background that the original file had and have a metronome now moving while a user can see their surroundings.

### Moverio Solutions

The lack of ability to anchor the metronome due to the headsets lack of capabilities to do so means the only solution is to develop this application on a headset that is capable. A Microsoft Hololens would be the only headset currently we feel is capable of doing so. The reasons being it is capable of spatial mapping meaning the headset recognises real world objects/environments. This along with the cameras on the headset allow for the headset to understand where a person is standing while they wear the headset -\> allowing for triangulation of that person's position. That combined with the hardware specifications being significantly better on the Hololens, it would solve the head bobbing issue as the rendering and refresh rates of the application would be far superior.

## Microsoft Hololens

After deciding that the Moverio headset was underpowered for what we needed we moved on to porting the moverio project over to work with the hololens. Before starting we spent time researching the sdk and how to compile and debug the application on the headset. I decided on using Unity 2019 and the mixed reality toolkit as it had plenty of pre-made assets and prefabs that we went on to incorporate into the project.

### Hololens Problems

While developing the project we ran into a number of issues that we had to solve. In the start while working on the project I discovered the Hololens 1 did not support building on the latest version of Unity and Mixed Reality toolkit. After having our customer test out the Hololens project he had various feedback on how the project could be improved. In no particular order they were.

- The cursor was distracting while walking
- While he was walking the pendulum would drift down below the head
- While testing it by going outside the sun was overpowering the brightness of the projections on the AR display
- The spatial mapping mesh was distracting while walking
- Darker color preset for the pendulum

### Hololens Solutions

We solved the issue of the hololens not supporting the latest version of unity by downgrading the project's unity version to version 2019 which supports building and debugging of the hololens gen 1.

We took the customers feedback and improved the application by making the requested changes he wanted. To start we fixed the cursor which was distracting while walking. I made it so that the cursor was invisible while the settings menu was open. Then to fix the pendulum drift I made the pendulum recalculate the height from the person's head every 3 seconds and if it is too far away from where it used to be it will slowly move up to the correct height that the user settings was asked for. The solution to the outside problem is only partially fixable as the hololens's projectors are overpowered by the brightness of the sun. During development it was useful to see the spatial mapping mesh but for daily use we turned it off in the Mixed Reality Toolkit settings. The darker colors were not a viable fix for making the pendulum more visible as making stuff darked on the hololens only makes the image you see more transparent.

## Project Architecture

Our tech stack for the project was a mix of Unity, Android, the Moverio SDK and Hololens SDK. Unity was used to build out the 3D scene and integrate the view from the AR glasses into the scenes. Android was our build target for the Moverio headset and how we debugged and tested the app. Moverio SDK was used to get specific headset data into unity.

The hololens tech stack was very similar which helped us reuse code we had written from the moverio project. We used Unity 2019 and the mixed reality toolkit for tracking and input detection along with building for the Universal Windows Platform which is what the Hololens gen 1 targets.

## Project Management

In our project management approach, we utilized Kanban boards and GitHub to facilitate effective collaboration, organization, and progress tracking. Kanban boards provided a visual representation of our workflow, enabling us to efficiently prioritize tasks and monitor their statuses. We divided our work into various stages, Backlog, Sprints, TODO, In Progress, and Done, allowing us to easily identify bottlenecks and balance workloads across the development cycle.

GitHub served as our version control system and collaboration platform, helping us manage the project's source code and other digital assets. Furthermore, GitHub's pull request mechanism allowed team members to review, discuss, and approve changes before merging them into the main branch. This process ensured code quality, encouraged knowledge sharing, and made sure both of us were up to speed on the project's development at all times.

By combining the visual organization of Kanban boards with the robust version control and collaboration features of GitHub, our team maintained a streamlined workflow, ensuring efficient task completion and effective communication throughout the project's lifecycle.

A few times a week we would also gather in one of the library's study rooms to work on the project in the same space. It also facilitated a space where we could conduct stand up meetings together in person instead of over Discord or Microsoft teams.

As mentioned previously our main form of communication outside of the library/in person was Discord. Over the course of the project we had calls back and forth to one another and used its built-in messaging system to discuss the project's development and any problems we were having.

## Conclusions

In conclusion, this project focused on developing an augmented reality app to help in the recovery of our client. This project has demonstrated the power of augmented reality technology and its potential to improve the lives of individuals with mobility issues. We leveraged the power of Unity and Blender to create a 3D space where a metronome visual aid can assist the client in walking. We successfully implemented user-adjustable settings for the metronome's height, distance, speed, color, and ball size, as well as head movement tracking to keep the metronome locked on the y-axis. By developing an AR solution, we bridged the gap between the physical and virtual world, providing the client with a virtual visual aid to help them. This project demonstrates how technology can be used to improve people's lives, and our team has gained valuable experience in working with AR and Unity.

## Headset Specifications

### Hololens Gen 1 Specifications
SOFTWARE
- Windows 10
- Windows Mixed Reality
Optics / Display
- megapixel widescreen see-through holographic lenses(waveguides)
- 2 HD 16:9 light engines (screen aspect ratio)
- Holographic Density: \>2.5k radiant (light points per radian)
- 1 2.4-megapixel photographic video camera
- Automatic pupillary distance calibration
SENSORS
- 1 IMU (Accelerometer, gyroscope, and magnetometer)
- 4 environment sensors
- 1 energy-efficient depth camera with a
- 120°x120° angle of view
- Four-microphone array
- 1 ambient light sensor
PROCESSORS
- Intel 32-bit (1GHz) with TPM 2.0 support
- Custom-built Microsoft Holographic Processing Unit (HPU 1.0)
MEMORY
- 2GB RAM
STORAGE
- 64GB (flash memory)
POWER
- Battery life up to 2-3 hours of active use and up to 2 weeks on standby mode
- Fully functional when charging
- Passively cooled (no fans)
- Battery status LED nodes (battery level and power/standby mode settings)
SECURITY
- Windows 10 software updates
- Additional security and device management available for Commercial Suite
WIRELESS
- Wi-Fi 802.11ac wireless networking
- Bluetooth 4.1 Low Energy (LE) wireless connectivity
AUDIO
- 3D audio speakers
- 3.5mm audio jack
PORTS
- Micro USB 2.0
PHYSICAL BUTTONS
- Power
- Volume up/down
- Brightness up/down
WHAT'S IN THE BOX
- HoloLens Development Edition
- Clicker
- Carrying case
- Charger and cable
- Microfiber cloth
- Nose pads
- Overhead strap
WEIGHT
- 579g (1.28 lbs.)
OS AND APPS
- Windows 10
- Calibration
- Holograms
- Learn Gestures
- Settings
- Windows Feedback
- Windows Store
- Microsoft Edge
- Photos
### Epson Moverio BT-300 
MOVERIO OS PLATFORM
- OS Version Moverio OS
- OS Update Via network
- Pre-installed Application Live wallpaper, Moverio Apps Market, Moverio Air, Moverio Mirror (for WiFi Miracast)
OPTICAL
- Driving Method Mono Crystalline Silicon Active Matrix
- Display Size 0.43 inch wide panel (16:9)
- Pixel Number 921,600 pixels (1280 RGB x 720)
- Refresh Rate 30 Hz
- Field of View 23 degrees (diagonal)
- Screen Size (Projected Distance)40 inch at 2.5m - 320 inch at 20m
- Colour Reproduction 24 bit-colour (16.77 million colours)
SENSORS
- Camera 5 Megapixel
- GPS Yes, in Controller
- Compass Yes, 3-axis in both Headset and Controller
- Gyroscope Yes, 3-axis in both Headset and Controller
- Accelerometer Yes, 3-axis in both Headset and Controller
CONNECTIVITY
- Wireless LAN IEEE 802.11a/b/g/n/ac with Wi-Fi CERTIFIED™, Miracast® (source/sink) ODFM, DS-SS
- Bluetooth Bluetooth Smart Ready Class2 (2.5 mW, 10 m), V4.1 support profile: HSP/A2DP/HID/OPP/SPP/AVRCP/PAN
CPU AND MEMORY
- CPU Intel Atom x5 1.44GHz Quad Core
- RAM 2 GB
- Internal Memory Approx. 16 GB (including Moverio OS)
- USER INTERFACE
- Touch-pad Pointing Method Capacitive Multitouch
- Function Key Power, Home, Recents, Back, Function (Lock, Brightness, 2D/3D), Volume (+/-)
SUPPORTED FILE FORMATS
- Video MP4 (MPEG4/H.264+AAC), MPEG2 (H.264+AAC), VP8
- Audio WAV, MP3, AAC
- 3D Supports Side By Side
SOUND OUTPUT
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
WHAT'S IN THE BOX
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
