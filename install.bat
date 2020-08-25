@echo off
echo 2005
start /wait 2005_x86.exe /q
start /wait 2005_x64.exe /q
echo 2008
start /wait 2008_x86.exe /qb
start /wait 2008_x64.exe /qb
echo 2010
start /wait 2010_x86.exe /passive /norestart
start /wait 2010_x64.exe /passive /norestart
echo 2012
start /wait 2012_x86.exe /passive /norestart
start /wait 2012_x64.exe /passive /norestart
echo 2013
start /wait 2013_x86.exe /passive /norestart
start /wait 2013_x64.exe /passive /norestart
echo 2015, 2017,2019
start /wait 2015_2017_2019_x86.exe /passive /norestart
start /wait 2015_2017_2019_x64.exe /passive /norestart
exit