# Pokemon-Go-Rocket-API
[![Stories in Ready](https://badge.waffle.io/1461748123/Pokemon-Go-Rocket-API.svg?label=in progress&title=In Progress)](http://waffle.io/1461748123/Pokemon-Go-Rocket-API)
[![Stories in Ready](https://badge.waffle.io/1461748123/Pokemon-Go-Rocket-API.png?label=ready&title=Ready)](https://waffle.io/1461748123/Pokemon-Go-Rocket-API)
## Official discord channel for user and developer discussions.
* https://discord.gg/y6EU2qY

## Window
![alt tag](https://github.com/1461748123/Pokemon-Go-Rocket-API/blob/master/MainWindow.png)  
![alt tag](https://github.com/1461748123/Pokemon-Go-Rocket-API/blob/master/MainSettings2.png)


A Pokémon Go bot in C#

## Features
* PTC / Google Login
* Get Map Objects and Inventory
* Live map showing Pokéstops and farming path
* Search for Gyms / Pokéstops / Spawns
* Farm Pokéstops
* Farm all Pokémon in the neighbourhood
* Evolve Pokémon
* Transfer Pokémon
* Powerup Pokémon
* Force unban
* Use LuckyEgg
* Auto-Recycle uneeded items
* View all Pokémon CP/IV %
* Transfer/Powerup/Evolve Pokémon
* Output level and needed XP for levelup
* Output Username, Level, Stardust, XP/hour, Pokémon/hour in Console Title
* Automatic use of Razzberries
* Automatic Update checker
* Logs everything into Logs folder

## Getting Started
### Download
Download the bot from the [release](https://github.com/1461748123/Pokemon-Go-Rocket-API/releases) tab.  
If you want the latest Beta-Build, you have to download the build from the Beta-Build branch and compile them by yourself with VisualStudio 2015.   
**Waning: Beta-Builds are unstable and might cause damage to your account, use at your own risk**
### Login
There are problems with google oauth login, so we have to use account and password to login for now.  
To ensure your account's safety, we suggest you to creat an app password just for botting. This will also allows users with 2-fact-auth enable to use the bot.  
Tutorial on how to use app password: [Google support](https://support.google.com/mail/answer/185833?hl=en)
### Settings
Change your settings using the settings tab on the bot. If you want more advance settings, edit the settings file under the bot's folder.
### Wola
Click Start Bot and enjoy!

# Settings
## AuthType
* *google* - Google login
* *ptc* - Pokémon Trainer Club

## PtcUsername
* *username* - for PTC account. No need for when using Google.

## PtcPassword
* *password* - for PTC account. No need for when using Google.

## Email
* *email@gmail.com* - for Google account. No need for when using PTC.

## Password
* *password* - for Google account. No need for when using PTC.

## GoogleRefreshToken
* *token* - for Google account. No need for wen using PTC. (Obsolete)

## DefaultLatitude
* *12.345678* - Latitude of your location you want to use the bot in. Number between -90 and +90. Doesn't matter how many numbers stand after the comma.

## DefaultLongitude
* *123.456789* - Longitude of your location you want to use the bot in. Number between -180 and +180. Doesn't matter how many numbers stand after the comma.

## LevelOutput
* *time* - Every X amount of time it prints the current level and experience needed for the next level.
* *levelup* - Only outputs the level and needed experience for next level on levelup.

## LevelTimeInterval
* *seconds* - After X seconds it will print the current level and experience needed for levelup when using *time* mode.

## Recycler
* *false* - Recycler not active.
* *true* - Recycler active.

## RecycleItemsInterval
* *seconds* - After X seconds it recycles items from the filter in *Settings.cs*.

## Language
* *english* - Outputs caught Pokémon in english name.
* *german*  - Outputs caught Pokémon in german name.

## RazzBerryMode
* *cp* - Use RazzBerry when Pokémon is over specific CP.
* *probability* - Use RazzBerry when Pokémon catch chance is under a specific percentage.

## RazzBerrySetting
* *cp value* - If RazzBerryMode is cp. Use RazzBerry when Pokémon is over this value
* *probability value* - If RazzBerryMode is probability. Use Razzberry when % of catching is under this value. Between 0 and 1.

## TransferType
* *none* - disables transferring
* *cp* - transfers all Pokémon below the CP threshold in the app.config, EXCEPT for those types specified in program.cs in TransferAllWeakPokemon
* *leaveStrongest* - transfers all but the highest CP Pokémon of each type SPECIFIED IN program.cs in TransferAllButStrongestUnwantedPokemon (those that aren't specified are untouched)
* *duplicate* - same as above but for all Pokémon (no need to specify type), (will not transfer favorited Pokémon)
* *all* - transfers all Pokémon

## TransferCPThreshold
* *CP* - transfers all Pokémon with less CP than this value.

## TransferIVThreshold
* *IV* - transfers all Pokémon with less IV than this value. Between 0 and 1.

## TravelSpeed
* *Speed* - Travel speed in km/h

## ImageSize
* *px* - Pixel size for Pokémon Thumbnails

## CatchPokemon
* *true* - Catch Pokémon and get Items from PokéStops
* *false* - Don't catch Pokémon and get Items from PokéStops

## EvolveAllGivenPokemons
* *false* - Evolves no Pokémon.
* *true* - Evolves all Pokémon.
