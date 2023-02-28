# Professional Practice in IT - Rundown of Project
### Pendulum Project
#### Group Project by: Ethan Conneely – G00393941 and Ryan Harte – G00338424

## Project Summary
Our project focuses on two main pieces of software. Unity and Augmented Reality (AR). The original pendulum that was being used was an mp4 file. We have taken the concept of that pendulum and rendered/built it in a 3D environment using Augmented Reality. A user can now see the pendulum in a real-world space no longer hindering their vision unlike the original mp4 files. 

## Project Outline and Goals
The following is a list of tasks that by the end of development we hope to have accomplished to deliver a revitalised product that we feel will be a huge improvement on the original mp4 files.
1.	The pendulum built and moving across its curve line.
2.	Pendulum Working in a 3D space in Augmented Reality.
3.	Tracking of Head Movements to the user’s specification (pendulum locked on the x axis and cannot move up or down).
4.	User adjustable settings for the pendulums height and distance it appears from a user, its speed back and forth and the pendulum balls size.
5.	Sound working so that when the pendulum hits both ends of the curve it makes a ticking noise. (Can be turned on or off by a user).
### What is accomplished so far?
So far goals 1-4 have been accomplished. Goal 5 is being worked on currently. What we need now is feedback so we can adjust the application to our customer/clients’ specifications, if they have any.

## Project Build
The following will explain how we have developed our project so far.
The application started in Unity where we began using and testing the headset for tracking ability via its gyroscope. It was quite easy to use as it is an android device and as such all that was required was to switch the build environment from unity to android and use unity remote 5 for testing. We then added the Moverio sdk (software development kit) to our project application and that gave us access to more functionality in the headset such as being able to go from a 2D view to a 3D view in our application. A grid was then built-in unity to mimic the floor so we could see just how well the tracking and viewing of the world would look in real time. After this the curve and ball for the pendulum were built in blender. Blender is a 3D computer graphics software application that allows for the building of 3D models and much more. Once that was done, we imported the pendulum into unity and from there created an array of empty objects along the curve that the ball uses to move along, one after the other. After this a user interface was implemented to allow setting changes for the pendulum. Now we aim to get sound working so that when the pendulum hits each end of the curve it will make a ticking noise.
