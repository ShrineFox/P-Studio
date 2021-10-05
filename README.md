# P-Studio
![](https://i.imgur.com/lHR0ViP.gif)
## Disclaimer
This is still a **major work in progress**! [Here](https://bit.ly/shrinefox) is what's left to do before release.
## Features
**Project Studio** (or *P-Studio*) simplifies the workflow of creating mods for Persona games.  
1. **Create a new project**. Enter a name, select a game, and provide an ISO/PKG to extract (just once). Afterward, you can use the extracted contents for all future mods of the game.  
![](https://i.imgur.com/KQVbUs8.png)  
3. **Choose files to edit**. Right click a file extracted from the game to transfer a copy to your project's working directory.  
![](https://i.imgur.com/xCYaiEo.png)  
5. **Double click project files** to open in an appropriate editor. The latest builds of [Amicitia](https://github.com/TGEnigma/Amicitia), [GFD Studio](https://github.com/TGEnigma/GFD-Studio), [AtlusScriptCompiler](https://github.com/TGEnigma/Atlus-Script-Tools) (and more) are included.  
![](https://i.imgur.com/tripVI1.png)  
7. **Build your mod.** Transfer the project to [Aemulus Package Manager](https://github.com/TekkaGB/AemulusModManager) for testing in-game. 

## Progress
- Right now, project settings are saved and loaded from ``YML``, and ``ISO`` contents are extracted from P3FES and P4 (PS2).  
- The contents of each ``CVM`` are fully extracted, as well as ``PAC`` archives and ``BF``/``BMD`` scripts.  
- The extracted game directory and project directory are browseable via the tabbed treview interface.  
- You can copy files from the game directory to the project directory with the right click context menu.  
- You can also open folders in Windows explorer, delete them from the project, or copy/rename them.  
- The entire project can be copied to a new project with a different name using "Save Project as..."  
- Amicitia and GFD Studio open their respective supported files, embedded within the P-Studio workspace.  
- Notepad++ can also be used to view and edit decompiled scripts with syntax highlighting.    
    
You can track further progress by [viewing my Trello tasklist](https://bit.ly/shrinefox).
# License
Code from [Aemulus Package Manager](https://github.com/TekkaGB/AemulusModManager) was used to achieve unpacking.
As such, this project is licensed under GPL-3.0.
