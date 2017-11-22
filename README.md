# L2RBot

Lineage 2 Revolution Pixel Bot

I am currently refactoring the bot to work with the US release of the game, specifically v1.x.

I have tested the following features and I mostly satisfied with their consistant performance:
Weekly Quest

I have tested the following and they are working but not quite as desired:
Main Quest
Scroll Quest

The following are features that are still being refactored and I expect to get them done over the Thanksgiving holiday.
Daily Dungeon
Tower of Insoloence
Alter of Darkness(I will get this to where I can have a quick feature release once Rifts are release into the game)

This bot is configured to use NoxPlayer to emulate Android on your PC. It has been tested with Nox Player v5.0-v6.0. 

If you are using a different android emulator you should be able to change the following to get it working. I will be adding additional functionality into the settings tab of the MainWindow in the future to make this easier.
1. Screen.cs - change the pixel measurements for the 4 borders to match your emulator.
2. Bot.BindNoxPlayer - edit the emulator string value to match your emulators .ProcessName
3. Nox player/Emulator - resolution set to 1280x720. if you get an error in the log regarding your screen size then you need to reset you Nox screen settings.

I am open to feedback, if you would like a feature added or changed let me know!
