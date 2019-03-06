::BatPath:$BatPath
::Params:$foreach(param in Params)$param;$end
cd /d "%~dp0"
set date=$Date
::rmdir /S /Q %date%

$if(BatType==1)
$foreach(server in ServerList)
set server=$server.Host
net use /delete \\%server%\c$ /Y
net use \\%server%\d$ $server.Password /user:$server.User

xcopy \\%server%\$server.Source %date%\$server.Target
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
