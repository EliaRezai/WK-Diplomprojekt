rd /S /Q ".vs" 2> nul
rd /S /Q ".vscode"
rd /S /Q "Physiotool.Application\bin"  2> nul
rd /S /Q "Physiotool.Application\obj"  2> nul
rd /S /Q "Physiotool.Webapi\bin"  2> nul
rd /S /Q "Physiotool.Webapi\obj"  2> nul

echo Starte die WebAPI. Drücke CTRL+C, um den Server zu beenden.
dotnet build Physiotool.Webapi --no-incremental --force

:start
dotnet watch run -c Debug --project Physiotool.Webapi
goto start
