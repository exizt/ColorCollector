@ECHO OFF
copy ..\application\bin\Release\SHColorPickup.exe .
if not exist installer (mkdir installer)
"C:\Program Files (x86)\NSIS\makensis.exe" _make.nsi
pause
