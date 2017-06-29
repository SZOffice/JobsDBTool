

USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_Analysis set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_Analysis
GO

USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_AttachmentResumeConversion set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_AttachmentResumeConversion
GO

USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_AU set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_AU
GO


USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_AuditLog set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_AuditLog
GO


USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_Counter set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_Counter
GO


USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_EmailAlert set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_EmailAlert
GO


USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_EmailDelivery set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_EmailDelivery
GO


USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_Global set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_Global
GO



USE master
go
--将数据库回滚到原始配置状态
alter database JobsDB_HK set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_HK
GO


use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_ID set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_ID
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_IN set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_IN
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_KR set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_KR
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_MY set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_MY
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_PH set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_PH
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_SG set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_SG
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_System set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_System
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_TH set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_TH
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_TW set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_TW
GO

use master
go
--将数据库回滚到原始配置状态
alter database JobsDB_US set single_user with rollback immediate
go
--删除数据库
drop database JobsDB_US
GO