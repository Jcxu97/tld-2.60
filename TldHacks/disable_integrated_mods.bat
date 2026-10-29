@echo off
setlocal
title TldHacks - Disable Conflicting Mods
rem Keep this file ASCII only. cmd can lose "call :label" targets in files with multibyte text.
rem The file works in the Mods folder and in the game folder next to Mods.

set "MODS=%~dp0"
if exist "%~dp0Mods\TldHacks.dll" set "MODS=%~dp0Mods\"
if not exist "%MODS%TldHacks.dll" (
    echo [ERROR] TldHacks.dll is not found.
    echo Put this file in the game Mods folder, or in the game folder next to Mods.
    pause
    exit /b 1
)
"%SystemRoot%\System32\tasklist.exe" /FI "IMAGENAME eq tld.exe" 2>nul | "%SystemRoot%\System32\find.exe" /I "tld.exe" >nul
if not errorlevel 1 (
    echo [ERROR] The Long Dark is running. Close the game, then run this file again.
    pause
    exit /b 1
)

pushd "%MODS%"
if not exist _disabled mkdir _disabled
set /a N_NEW=0
set /a N_OLD=0

echo ================================================
echo   TldHacks - Disable Conflicting Mods
echo   Mods folder: %CD%
echo ================================================
echo.

call :mv SonicMode
call :mv Jump
call :mv GunZoom
call :mv VehicleFov
call :mv FastTravel
call :mv StretchArmstrong
call :mv TorchTweaker
call :mv KeroseneLampTweaks
call :mv AutoToggleLights
call :mv GearDecayModifier
call :mv BowRepair
call :mv DisableAutoEquipCharcoal
call :mv RememberBreakDownItem
call :mv DroppableUndroppables
call :mv CraftAnywhereRedux
call :mv MoreCookingSlots
call :mv TimeScaleHotkey
call :mv FullSwing
call :mv SilentWalker
call :mv QoL
call :mv AutoSurvey
call :mv MapManager
call :mv TinyTweaks-MapTextOuline
call :mv TinyTweaks-NoSaveOnSprain
call :mv TinyTweaks-WakeUpCall
call :mv TinyTweaks-BuryHumanCorpses
call :mv TinyTweaks-RunWithLantern
call :mv SleepWithoutABed
call :mv SkipIntroRedux
call :mv PlaceFromInventory
call :mv CaffeinatedSodas
call :mv Sprainkle
call :mv RnStripped
call :mv ImprovedFlasks
call :mv ImprovedTrader
call :mv HouseLights
call :mv ShowTraderTrust
call :mv ExtraGraphicsSettings
call :mv UniversalTweaks
call :mv StackManager
call :mv GfxBoost
call :mv LightCull
call :mv DarkerNights
call :mv FeatSettings
call :mv ItemRarities

echo.
echo ================================================
if %N_NEW%==0 (
    echo   Done. Nothing new to disable.
) else (
    echo   Done. Disabled now: %N_NEW%
)
if not %N_OLD%==0 echo   Disabled before: %N_OLD%
echo   These mods are part of TldHacks now.
echo   The files are in Mods\_disabled.
echo   To use one again, move its files back to Mods.
echo ================================================
popd
pause
exit /b 0

:mv
if not exist "%~1.dll" if not exist "%~1.dll.disabled" goto :notfound
if exist "_disabled\%~1.dll" del /f /q "_disabled\%~1.dll" >nul 2>nul
move /y "%~1.dll" _disabled\ >nul 2>nul
move /y "%~1.dll.disabled" _disabled\ >nul 2>nul
move /y "%~1.json" _disabled\ >nul 2>nul
move /y "%~1.modcomponent" _disabled\ >nul 2>nul
set /a N_NEW+=1
echo [DISABLED] %~1
exit /b
:notfound
if exist "_disabled\%~1.dll" set /a N_OLD+=1
if exist "_disabled\%~1.dll.disabled" set /a N_OLD+=1
exit /b
