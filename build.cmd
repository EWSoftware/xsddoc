@ECHO OFF

if not exist bin mkdir bin

:: Note: We're not using parallel build (/m) because it doesn't seem to
::       work with Sandcastle Help File Builder.

"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" /t:restore;build /nologo /m /v:m /nr:false /flp:verbosity=normal;LogFile=bin\msbuild.log %*
