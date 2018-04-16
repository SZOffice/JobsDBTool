cd /d "%~dp0"
set date=$Date
::rmdir /S /Q %date%


$foreach(server in ServerList)
set server=$server.Host
net use /delete \\%server%\c$ /Y
net use \\%server%\d$ $server.Password /user:$server.User
$if(IsToLocal!=1)
xcopy \\%server%\$server.Target \\%server%\${server.Target}.%date%
xcopy $server.Source \\%server%\$server.Target
$else
xcopy \\%server%\$server.Source %date%\$server.Target
$end
$end
 