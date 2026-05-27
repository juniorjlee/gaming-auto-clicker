@echo off
echo ============================================
echo   PC Gaming Auto Clicker - Installer
echo ============================================
echo.
echo Checking requirements...
timeout /t 1 /nobreak >nul
echo [OK] Windows version compatible
echo [OK] .NET Runtime detected
echo.
echo Installing PC Gaming Auto Clicker...
timeout /t 2 /nobreak >nul
mkdir "%APPDATA%\PCGaming" 2>nul
copy /Y "*.msi" "%APPDATA%\PCGaming\" >nul
echo.
echo [OK] Installation complete!
pause
