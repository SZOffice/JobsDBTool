::BatPath:$BatPath
::Dates:$foreach(date in DateList)$date;$end
::Params:$foreach(param in Params)$param;$end
cd /d "%~dp0"
::rmdir /S /Q %date%

$foreach(date in DateList)
set date=$date

$if(BatType==1)
$foreach(server in ServerList)
set server=$server.Host
net use /delete \\%server%\c$ /Y
net use \\%server%\d$ $server.Password /user:$server.User

xcopy \\%server%\$server.Source %date%\${server.Target}
$end
$end

$if(BatType==2)
$foreach(server in ServerList)
set server=$server.Host
net use /delete \\%server%\c$ /Y
net use \\%server%\d$ $server.Password /user:$server.User


xcopy \\%server%\$server.Target \\%server%\${server.Target}.%date%
xcopy $server.Source \\%server%\$server.Target
$end
$end

$if(BatType==3)
set pscp="D:\Program Files\PuTTY\pscp.exe"
set base=D:\Tools\JobsDBTool\Resource\
set confirm="%base%confirm.txt"

$foreach(server in ServerList)
set server=$server.Host

set target=%date%\${server.Target}

if not exist %target% ( 
    echo create %target%         
    md %target%  
)

call %pscp% -pw $server.Password -l $server.User %server%:$server.Source %target%  < %confirm%

$end
$end

$end