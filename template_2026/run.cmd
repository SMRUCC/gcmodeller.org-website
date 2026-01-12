@echo off

set msbuild="G:\GCModeller\src\runtime\httpd\tools\FluteBuild.exe"
set src="G:\gcmodeller.org-website\template_2026"
set output="Z:\html"

CALL %msbuild% /compile /view %src% /wwwroot %output% --listen