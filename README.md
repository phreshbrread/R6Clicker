# R6Clicker
An automatic Training Grounds renown grinder for Rainbow Six Siege.

I made this because I wanted to make something useful, It's pretty handy for grinding for skins and operators and stuff and It usually works pretty well.
**This will NOT level up your account**.

Direct download for the latest version can be found [here](https://github.com/phreshbrread/R6Clicker/releases/download/v6.0/R6Clicker.exe)

## How To Use
1. Set Training Grounds matchmaking preferences to PROTECT HOSTAGE ONLY.
2. Also set MM preferences to big maps only, I recommend just leaving it only on Fortress.
_Note: If the map is too small you will die too fast and wont gain any renown._
3. Load into a solo training grounds match on easy mode and start the clicker.
4. You should eventually die and fail but still recieve some renown bonus, the clicker automatically hits the restart button so the process repeats itself.

You'll probably only gain around 18-36 renown each time but if you leave it on for an entire day it adds up. I recommend also using a booster if you have one since obviously double the amount of renown gained in a certain time frame.
**Please note that this program cannot be used in the background while you do other things as it moves the mouse cursor every set interval**

## Supported Resolutions
- 3840 x 2160 (4K)
- 2560 x 1440
- 1920 x 1080
- 1366 x 768
- ### Program also supports custom mouse positions in case your resolution isn't listed.

## Changelog
### v6.0
- Made some UI tweaks
- Changed mouse positions for all 4 resolutions to account for High Calibre's UI changes
- Pre-game selection clicking now works for all 4 resolutions
- Slightly changed some things to be more reliable
### v5.0
- Fixed the mouse set position not appearing in the text box
- Clicking any resolution button saves settings now so you no longer need to click start to save
- Added a dialogue box that explains how to use the program so you don't need to open up the readme
- Removed WriteSettingsToFile.cs because it was unnecessary
### v4.2
- Cleaned up some repetitive code
- Now clicks specific buttons on the pre-game selection to speed up the process
  - Saves around 25 seconds with a 2500 interval
### v4.1
- Added hotkeys to make stopping & starting easier
### v4
- Changed the way it clicks so that it actually works
- Cleaned up and rewrote a bunch of code
- Added some exception handling
- Now saves and loads all values to and from a settings file in the program directory
  - To reset all settings just delete the settings.ini file
### v3
- Added support for custom mouse positions
- Changed some UI and made the window slightly less wide
### v2
- Added support for 4 common resolutions
### v1
- Initial upload
