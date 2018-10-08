# SpawnGenerator
A multi-purpose SQL generator for cmangos tbc-db created in Windows Forms. 

Features are primarily being added when I have a need for them myself, but suggestions are welcome. 

Current features:
1. The application supports both MDI childs and separate windows
2. Filter sniff files based on a packet white- or blacklist.
3. Import creature and gameobject spawn data from sniff files. Sort them by entry, delete duplicates and generate SQL for insertion into tbc-db.
4. Easily generate a large amount of pools based on parameters you enter.
5. Subtract packet timestamps (useful when working on scripts that require delicate timing)
6. Easily add single creature spawns by pasting the position string and other data
7. Time spellcasts from sniffs
8. Import and update model speed from sniffs
9. Generate waypoints for flying creatures using points sent in CreateObject
10. Import creature and gameobject spawns from sniffs into a temporary DB in order to later add them to tbc-db
11. Parse texts from multiple files and filter them
12. Convert SMSG_PET_SPELLS_MESSAGE packets into SQL
13. Update creature_template data from sniffs

![Main](http://i.imgur.com/J7qv5dr.png)
![Filterer](http://i.imgur.com/wYsOgzF.png)
![Multi-Spawn Window](https://i.imgur.com/f9dtcE2.png)
![Pool Window](http://i.imgur.com/cINuPKo.png)
![Timestamp](http://i.imgur.com/s7oJYMO.png)






