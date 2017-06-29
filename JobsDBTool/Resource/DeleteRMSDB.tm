@ECHO OFF
set _time_start=%time% 
set /a hour_start=%_time_start:~0,2% 
set /a minute_start=1%_time_start:~3,2%-100 
set /a second_start=1%_time_start:~6,2%-100

ECHO Running NET STOP MSSQLSERVER
net stop MSSQLSERVER
ECHO Running NET START MSSQLSERVER
net start MSSQLSERVER

echo [%_time_start%]start execute sql script, please waitting....
::osql -Sv8sqlproxy -Usa -PP@ssword -i DropRMSDB.sql
$ExecSql

set _time_end=%time% 
set /a hour_end=%_time_end:~0,2% 
set /a minute_end=1%_time_end:~3,2%-100 
set /a second_end=1%_time_end:~6,2%-100 

:: 计算秒数 
if %second_end% lss %second_start% ( 
set /a second_end=%second_end%+60 
set /a minute_end=%minute_end%-1 
) 
set /a second=%second_end%-%second_start% 
:: 计算分钟数 
if %minute_end% lss %minute_start% ( 
set /a minute_end=%minute_end%+60 
set /a hour_end=%hour_end%-1 
) 
set /a minute=%minute_end%-%minute_start% 
:: 计算小时数 
if %hour_end% lss %hour_start% ( 
set /a hour_end=%hour_end%+24 
) 
set /a hour=%hour_end%-%hour_start% 
echo Execution Time Taken: %hour%:%minute%:%second% 

pause & exit
