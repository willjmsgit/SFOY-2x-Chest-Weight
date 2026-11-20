# SFOY Chest Weight

BepInEx 5 mod for Survival: Fountain of Youth. Multiplies the weight limit of storage chests (default 2x). The player's carry limit is not changed.

## Install
1. Install BepInEx 5.4.x (Mono, x64) into the game folder.
2. Download `ChestWeight.dll` from the Releases page and put it in `BepInEx/plugins`.
3. Launch the game once. Edit `BepInEx/config/wmj.chestweight.cfg` to change `ChestMultiplier`.

Tested on game version: (Coop_1842)

## Config
1. Go to "<steam-dir>\Survival Fountain of Youth\BepInEx\config"
2. Open "wmj.sfoy.chestweight"
3. Change "ChestMultiplier = 2" to be whatever you want


## Build
`dotnet build -c Release -p:GameDir="path\to\game"`
