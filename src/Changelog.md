# Changelog
### v7.0
- Program now clicks the bonus button at the end of matches rather than waiting for it to switch, this saves around 4 or 5 seconds on top of everything else
- Moved changelog to it's own file
- Removed unnecessary comments
- Removed a debug log line
### v6.0
- Made some UI tweaks
- Changed mouse positions for all 4 resolutions to account for High Calibre's UI changes
- Pre-game selection clicking now works for all 4 resolutions
- Slightly changed some things to be more reliable
### v5.0
- Fixed the mouse set position not appearing in the text box
- Clicking any resolution button saves settings now so you no longer need to click start to save
- Added a dialogue box that explains how to use the program so you don't need to open up the readme
- Removed WriteSettingsToFile.cs because it was unnecessary and just complicated things more
### v4.2
- Cleaned up some repetitive code
- Now clicks specific buttons on the pre-game selection to speed up the process
  - Saves around 30 seconds with a 500ms interval
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
- Changed some UI and made the window slightly thinner
### v2
- Added support for 4 common resolutions
### v1
- Initial upload