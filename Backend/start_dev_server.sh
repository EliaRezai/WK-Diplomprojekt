#!/bin/bash
rm -rf ".vs" &> /dev/null
rm -rf ".vscode" &> /dev/null
rm -rf "Physiotool.Application\bin" &> /dev/null
rm -rf "Physiotool.Application\obj" &> /dev/null
rm -rf "Physiotool.Webapi\bin" &> /dev/null
rm -rf "Physiotool.Webapi\obj" &> /dev/null

dotnet build Physiotool.Webapi --no-incremental --force
dotnet watch run -c Debug --project Physiotool.Webapi
