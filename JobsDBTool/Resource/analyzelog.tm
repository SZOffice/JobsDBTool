::LogType: $foreach(type in LogTypeList)$type, $end
::LogDate: $foreach(date in LogDateList)$date, $end
::ProdWebCountry: $foreach(env in LogProdWebCountryList)$env, $end
::PreWebCountry: $foreach(env in LogPreWebCountryList)$env, $end
::IsToJsonByPy: $IsToJsonByPy
::IsImportToEs: $IsImportToEs

cd /d "%~dp0"
set basePath=$BasePath
set pyLog2JsonPath=$PyLog2JsonPath
$if(IsImportToEs==1)set pyJson2ESPath=$PyJson2ESPath$end

$foreach(logType in LogTypeList)
$foreach(logDate in LogDateList)

set date=$logDate
rmdir /S /Q %date%
$foreach(server in ServerList)
$for(i=1; i<=server.NumOfServer; i++)
set server=${server.ServerPrefix}$i
rem %server%
net use /delete \\%server%\d$ /Y
net use \\%server%\d$ $server.LoginPWD /user:$server.LoginId
xcopy \\%server%\e$\Jobsdb\Log\${server.Country}\%date%\${logType}.%date%.log ServerLogs\%server%\%date%\
$end
$end

$if(IsToJsonByPy==1)python %pyLog2JsonPath% %basePath%\ServerLogs\%server%\%date%\${logType}.%date%.log %basePath%\JsonLogs\%server%.${logType}.%date%.log $end
$if(IsImportToEs==1)python %pyJson2ESPath% %basePath%\JsonLogs\%server%.${logType}.%date%.log $ESHost $ESIndex $ESType $end

$end
$end
