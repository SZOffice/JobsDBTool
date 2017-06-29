echo this is Main bat
Set build_path="D:\\Normal\JobsDBTool\Resource\Main.build"
Set param_base_dir="D:\\Normal\JobsDBTool"
Set param_dll_copy_target="D:\\Normal\JobsDBTool\bin\Debug"

D:\workspaces_sourceForge\bin\nant\nant.exe -buildfile:%build_path% build -D:param.base.dir=%param_base_dir% -D:param.dll.copy.target=%param_dll_copy_target% %* -logfile:Main.log

pause