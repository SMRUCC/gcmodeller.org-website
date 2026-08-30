@echo off

set scanner="G:\GCModeller\src\runtime\httpd\tools\Sitemap.exe"
set host="https://gcmodeller.org/"

%scanner% /make --site ./ --host %host% --out ./ --depth 999 --max_urls 3000

pause