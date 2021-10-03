@ECHO OFF
if not exist source (mkdir source)
if not exist installer (mkdir installer)
copy ..\application\bin\Release\SHColorPickup.exe .\source

"C:\Program Files (x86)\NSIS\makensis.exe" /INPUTCHARSET UTF8 _make.nsi
pause
