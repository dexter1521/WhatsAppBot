# WhatsAppBot

## Prerequisites
- Windows machine with **Visual Studio 2017** or newer.
- **.NET Framework 4.5** installed.

## Building and Running
1. Open the solution file `BotSharks.sln` in Visual Studio.
2. Restore NuGet packages:
   - In Visual Studio: right-click the solution and choose **Restore NuGet Packages**; or
   - From the command line run:
     ```
     nuget restore BotSharks.sln
     ```
3. Build the project and run it:
   - Use **Build > Build Solution** (or press <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>B</kbd>);
   - Then start the application with <kbd>F5</kbd> or via **Debug > Start Debugging**.

## Chromedriver
Download the version of `chromedriver.exe` that matches your Chrome browser from
[chromedriver.chromium.org/downloads](https://chromedriver.chromium.org/downloads).
Place the downloaded `chromedriver.exe` in the same directory as `BotSharks.exe`
so Selenium can launch Chrome correctly.

## Repository notes
`packages/`, `bin/` and `obj/` directories are created when restoring packages
and building the project. These generated files are not tracked in the
repository.
