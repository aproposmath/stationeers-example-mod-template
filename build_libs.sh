#!/bin/bash

# dotnet tool install -g JetBrains.Refasmer.CliTool
OUT_DIR=`pwd`/libs
cd $HOME/.steam/steam/steamapps/common/Stationeers/rocketstation_Data/Managed/
refasmer --all -O $OUT_DIR \
    Unity.TextMeshPro.dll \
    UniTask.dll \
    Newtonsoft.Json.dll \
    netstandard.dll \
    UnityEngine.UI.dll \
    RG.ImGui.dll \
    Assembly-CSharp.dll