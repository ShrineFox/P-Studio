# P-Studio
All-in-one toolset & project manager for Persona mods
![](https://cdn.discordapp.com/attachments/316239186736971776/891065055133716580/pstudio.gif)
# Disclaimer
At this time, the repository is pretty much a proof of concept. It is still a major work in progress.  
# Goal
This program is supposed to simplify the process of making mods for games supported by TekkaGB's [Aemulus Package Manager](https://github.com/TekkaGB/AemulusModManager).  
- When it's completed, you will be able to create "projects" by choosing a name, an input ``ISO``/``PKG`` to extract (or extracted ``CVM``/``CPK`` directory) and an output mod folder path.  
- Using those paths, a "game" treeview is constructed, where you can browse game files and add copies of them to your project's directory for editing.  
- Files copied to your project's directory will show up in a separate "project" treeview for you to select from.  
- From there, available built-in modding utilities for the selected file in the "project" treeview will appear in the viewport to the right.  
- This way, you can create a mod from start to finish without managing other applications or even leaving the window.  
- When finished, the mod can be built in Aemulus and launched in an emulator for testing.
# Progress
Right now, project settings are saved and loaded from ``YML``, and some ``ISO`` contents are extracted from P3FES.  
You can track further progress by [viewing my Trello tasklist](https://bit.ly/shrinefox).
# License
Code from [Aemulus Package Manager](https://github.com/TekkaGB/AemulusModManager) was used to achieve unpacking.
As such, this project is licensed under GPL-3.0.
