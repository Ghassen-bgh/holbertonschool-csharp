#!/usr/bin/env bash
dotnet new console -o 2-new_project
dotnet build 1-new_project
dotnet run --project 2-new_project