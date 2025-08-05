🧩 Project Name
Gnirehtet Easy Manager

📄 Project Description
Gnirehtet Easy Manager is a desktop application built in C# (Windows Forms, .NET Framework 4.8) to simplify the use of reverse tethering with gnirehtet — a tool that allows sharing your PC’s internet connection with your Android device via USB using a VPN tunnel.

⚙️ What It Does
This app streamlines the manual command-line workflow, automating common steps like:

Checking if the Android device is connected via ADB

Verifying if gnirehtet is installed on the device

Installing the gnirehtet client if needed

Launching the gnirehtet service (gnirehtet run) without freezing the UI

Stopping the gnirehtet service and terminating residual processes

Displaying real-time logs for monitoring

Offering a clean, beginner-friendly graphical interface

🎯 Motivation
The traditional way of using gnirehtet involves CLI commands and manual process management, which may be challenging for beginners. This project enables any user to manage the internet connection and sharing via visual controls and clear feedback.

🧠 Features
Auto-detects Android device connection via ADB

Verifies gnirehtet client presence on the Android device

One-click install for the gnirehtet client if required

Launches gnirehtet service asynchronously to keep the UI responsive

Terminates gnirehtet and cmd processes to free up ports

Displays live logs and status in a TextBox

Simple GUI optimized for user-friendliness

🧪 Tech Stack
C# using Windows Forms (.NET Framework 4.8)

ADB (Android Debug Bridge) for device communication

Windows process management for command execution and control

🚀 How to Use
Connect your Android device via USB with USB debugging enabled

Launch the app

The app automatically checks connection and gnirehtet status

If gnirehtet isn’t installed, click Install

Click Start to initiate the service

Use Stop to terminate the connection

Check the logs panel for actions and status feedback


🗂 Project Structure
Services/
  └── AdbService.cs         // Handles ADB commands and connection

Services/
  └── GnirehtetService.cs   // Manages gnirehtet operations and process control

Helpers/
  └── CmdHelper.cs          // Runs terminal commands and returns output
  
Form1.cs                    // Main UI and user interaction

📌 Notes
This project is built for Windows and Android. Make sure ADB and gnirehtet are properly placed in the project folder. Made for educational and personal use — contributions and improvements are welcome!

📦 Download
The debug build is available as a .rar archive. After extraction, simply run:

Tethering-Reverse-Easy-Start-Progam.exe

📦 Download debug (.rar)
