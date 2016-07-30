@echo off
choice /M "Run db scripts?"
echo.
IF ERRORLEVEL 2 GOTO END

echo Creating tables...
sqlcmd -S .\SQL2012 -d YLContract -i Tables.sql
echo Done
echo.
echo Initializing tables...
sqlcmd -S .\SQL2012 -d YLContract -i InitData.sql
echo Done
echo.

rem echo Creating stored functions...
rem cd SF
rem sqlcmd -S .\SQL2012 -d YLContract -i sfGetOrgId.sql
rem sqlcmd -S .\SQL2012 -d YLContract -i sfGetOrgs.sql
rem sqlcmd -S .\SQL2012 -d YLContract -i sfGetOrgsOf.sql
rem echo Done
rem echo.

rem echo Creating stored procedures...
rem cd ..\SP
rem sqlcmd -S .\SQL2012 -d YLContract -i spC_DQDKQK_M.sql
rem sqlcmd -S .\SQL2012 -d YLContract -i spC_JQDKMX_D.sql
rem echo Done
rem echo.

pause
:END