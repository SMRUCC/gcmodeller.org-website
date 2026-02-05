@echo off

set msbuild="G:\GCModeller\src\runtime\httpd\tools\FluteBuild.exe"
set src="./"
set output="../release/"

CALL %msbuild% /compile /view %src% /wwwroot %output% --listen