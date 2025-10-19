@echo off
setlocal enabledelayedexpansion

@REM ==========================
@REM Check for admin rights
@REM ==========================
net session >nul 2>&1
if %errorlevel% neq 0 (
    @REM Not running as admin, relaunch as admin
    echo Set UAC = CreateObject^("Shell.Application"^) : UAC.ShellExecute "cmd.exe", "/c ""%~f0""", "", "runas", 1 > "%temp%\getadmin.vbs"
    cscript //nologo "%temp%\getadmin.vbs"
    del "%temp%\getadmin.vbs"
    exit /b
)

@REM ==========================
@REM Intro / instructions
@REM ==========================
echo ==============================================
echo Auto Logon Configuration Utility
echo ==============================================
echo Use the menu to enable or disable Auto Logon services.
echo Note: This information is stored in plain text and can potentially be read by unauthorized users.
echo Enter a number 1 through 3 to make a selection.
echo.

set "key=HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon"

@REM ==========================
@REM Menu loop
@REM ==========================
:menu
echo ----------------------------------------------
echo Menu
echo 1: Enable Auto Logon
echo 2: Disable Auto Logon
echo 3: Exit the program
echo ----------------------------------------------
echo.

set /p menuChoice=Enter your choice: 

if "%menuChoice%"=="1" (
    echo.
    echo Enter credentials to enable Auto Logon Services.
    echo Press Enter to use the default values.
    echo.

    echo Current user:     %USERNAME%
    echo Current domain:   %USERDOMAIN%
    echo Current computer: %COMPUTERNAME%
    echo.

    @REM ==========================
    @REM Initialize defaults
    @REM ==========================
    set "DefaultUsername=%USERNAME%"
    set "DefaultPassword="
    set "DefaultDomainName=%USERDOMAIN%"

    :enterUsername
    set /p DefaultUsername=Username [default: !DefaultUsername!]: 
    if "!DefaultUsername!"=="" (
        echo Username cannot be blank.
        echo.
        goto enterUsername
    )

    set /p DefaultPassword=Password: 
    set /p DefaultDomainName=Domain [default: !DefaultDomainName!]: 

    @REM ==========================
    @REM Write registry values
    @REM ==========================
    reg add "!key!" /v AutoAdminLogon /t REG_SZ /d 1 /f >nul 2>&1
    reg add "!key!" /v DefaultUsername /t REG_SZ /d "!DefaultUsername!" /f >nul 2>&1
    reg add "!key!" /v DefaultPassword /t REG_SZ /d "!DefaultPassword!" /f >nul 2>&1
    reg add "!key!" /v DefaultDomainName /t REG_SZ /d "!DefaultDomainName!" /f >nul 2>&1

    @REM ==========================
    @REM Display results in aligned format
    @REM ==========================
    echo.
    echo Auto Logon has been enabled.
    echo The following values were added to "!key!":
    for %%V in (AutoAdminLogon DefaultUsername DefaultPassword DefaultDomainName) do (
        for /f "tokens=1,2,*" %%A in ('reg query "!key!" /v %%V 2^>nul') do (
            if /i "%%A"=="%%V" (
                call :padColumn "%%A" "%%B" "%%C"
            )
        )
    )
    echo.
    goto menu

) else if "%menuChoice%"=="2" (
    echo.
    echo Disabling Auto Logon Services...
    echo.

    @REM ==========================
    @REM Delete AutoAdminLogon first and show main success message
    @REM ==========================
    reg delete "!key!" /v AutoAdminLogon /f

    @REM Delete other values quietly to avoid clutter
    reg delete "!key!" /v DefaultUsername /f >nul 2>&1
    reg delete "!key!" /v DefaultPassword /f >nul 2>&1
    reg delete "!key!" /v DefaultDomainName /f >nul 2>&1

    echo Auto Logon has been disabled.
    echo.
    goto menu

) else if "%menuChoice%"=="3" (
    echo.
    echo Exiting the program...
    goto :eof

) else (
    echo.
    @REM Any other entry will cause the menu to repeat by restarting the loop
    echo Invalid choice. Please enter a number for your menu selection.
    echo.
    goto menu
)

@REM ==========================
@REM Padding subroutine
@REM ==========================
:padColumn
set "col1=%~1"
set "col2=%~2"
set "col3=%~3"

@REM Pad col1 to 20 characters
set "col1=%col1%                    "
set "col1=!col1:~0,20!"

@REM Pad col2 to 10 characters
set "col2=%col2%          "
set "col2=!col2:~0,10!"

echo !col1!!col2!!col3!
goto :eof