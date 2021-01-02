@echo off

set _programFiles=%ProgramFiles(x86)%
if not defined _programFiles set _programFiles=%ProgramFiles%

dotnet restore --force "..\src\SnippetManager.sln"

"%_programFiles%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\msbuild" "..\src\SnippetManager.sln" ^
 /t:Clean,Build ^
 /p:Configuration=Release,TreatWarningsAsErrors=true,WarningsNotAsErrors=1591 ^
 /v:normal ^
 /fl ^
 /m

if errorlevel 1 (
 pause
 exit
)

echo OK
pause
