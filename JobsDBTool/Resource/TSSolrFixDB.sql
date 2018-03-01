USE [JobsDB_ID]
GO

/****** Object:  View [dbo].[JsJobSeeker_ProfileForTalentSearch_View]    Script Date: 01/07/2016 14:46:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[JsJobSeeker_ProfileForTalentSearch_View]
AS

SELECT		GJS.Id, GJSE.EmailAddress, GJS.utcProfileLastModifiedTime AS utcLastModifiedTime, GJS.utcIndexLastUpdatedTime, GJS.utcLastActivityTime,
			JS.ProfileIsIndexPending, JS.ProfileUtcLastIndexedTime, JS.ProfileUtcIndexedLastModifiedTime,
			GJS.ProfilePrivacyLevel, GJS.DefaultResumeID, GJS.DefaultResumeStatus,
			GJS.FirstName, GJS.MiddleName, GJS.LastName, GJS.CountryOfResidence, GJS.LocationID, GJS.Nationality,
			GJS.HighestEducationLevel, GJS.YearOfWorkExperience, GJS.P1Position, GJS.P1JobFunction, GJS.P1Company, GJS.P1EmploymentPeriodStart, GJS.P1EmploymentPeriodEnd, GJS.P1ToPresent, GJS.HasP1Data, GJS.CurrencyCountry, GJS.SalaryType, GJS.SalaryFrom, GJS.SalaryTo,
			CAST(CASE WHEN GJPR.JobseekerId IS NOT NULL THEN (CASE WHEN GJPR.ShowLess = 0 THEN 1 ELSE 2 END) ELSE 0 END AS TINYINT) AS ParsedResume
FROM		JobsDB_Global.dbo.JsGlobal_JobSeekerBase AS GJS WITH (NOLOCK) INNER JOIN
			JobsDB_Global.dbo.JsGlobal_JobSeekerEmail AS GJSE WITH (NOLOCK) ON GJS.Id=GJSE.JobSeekerId INNER JOIN
			dbo.JsJobSeeker AS JS WITH (NOLOCK) ON GJS.Id=JS.Id LEFT JOIN
			(SELECT JobseekerId, ShowLess FROM JobsDB_Global.dbo.JsGlobal_ParsedJsResume WITH (NOLOCK) WHERE EmptyContent = 0) AS GJPR ON GJS.Id=GJPR.JobseekerId
WHERE		(GJS.Status='A' OR GJS.Status='X') AND GJS.RegisterCountry='ID' AND GJS.HasP1Data IN (1,3,4)



GO


USE [JobsDB_TH]
GO

/****** Object:  View [dbo].[JsJobSeeker_ProfileForTalentSearch_View]    Script Date: 01/07/2016 14:46:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[JsJobSeeker_ProfileForTalentSearch_View]
AS

SELECT		GJS.Id, GJSE.EmailAddress, GJS.utcProfileLastModifiedTime AS utcLastModifiedTime, GJS.utcIndexLastUpdatedTime, GJS.utcLastActivityTime,
			JS.ProfileIsIndexPending, JS.ProfileUtcLastIndexedTime, JS.ProfileUtcIndexedLastModifiedTime,
			GJS.ProfilePrivacyLevel, GJS.DefaultResumeID, GJS.DefaultResumeStatus,
			GJS.FirstName, GJS.MiddleName, GJS.LastName, GJS.CountryOfResidence, GJS.LocationID, GJS.Nationality,
			GJS.HighestEducationLevel, GJS.YearOfWorkExperience, GJS.P1Position, GJS.P1JobFunction, GJS.P1Company, GJS.P1EmploymentPeriodStart, GJS.P1EmploymentPeriodEnd, GJS.P1ToPresent, GJS.HasP1Data, GJS.CurrencyCountry, GJS.SalaryType, GJS.SalaryFrom, GJS.SalaryTo,
			CAST(CASE WHEN GJPR.JobseekerId IS NOT NULL THEN (CASE WHEN GJPR.ShowLess = 0 THEN 1 ELSE 2 END) ELSE 0 END AS TINYINT) AS ParsedResume
FROM		JobsDB_Global.dbo.JsGlobal_JobSeekerBase AS GJS WITH (NOLOCK) INNER JOIN
			JobsDB_Global.dbo.JsGlobal_JobSeekerEmail AS GJSE WITH (NOLOCK) ON GJS.Id=GJSE.JobSeekerId INNER JOIN
			dbo.JsJobSeeker AS JS WITH (NOLOCK) ON GJS.Id=JS.Id LEFT JOIN
			(SELECT JobseekerId, ShowLess FROM JobsDB_Global.dbo.JsGlobal_ParsedJsResume WITH (NOLOCK) WHERE EmptyContent = 0) AS GJPR ON GJS.Id=GJPR.JobseekerId
WHERE		(GJS.Status='A' OR GJS.Status='X') AND GJS.RegisterCountry='TH' AND GJS.HasP1Data IN (1,3,4)



GO


USE [JobsDB_SG]
GO

/****** Object:  View [dbo].[JsJobSeeker_ProfileForTalentSearch_View]    Script Date: 01/07/2016 14:46:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[JsJobSeeker_ProfileForTalentSearch_View]
AS

SELECT		GJS.Id, GJSE.EmailAddress, GJS.utcProfileLastModifiedTime AS utcLastModifiedTime, GJS.utcIndexLastUpdatedTime, GJS.utcLastActivityTime,
			JS.ProfileIsIndexPending, JS.ProfileUtcLastIndexedTime, JS.ProfileUtcIndexedLastModifiedTime,
			GJS.ProfilePrivacyLevel, GJS.DefaultResumeID, GJS.DefaultResumeStatus,
			GJS.FirstName, GJS.MiddleName, GJS.LastName, GJS.CountryOfResidence, GJS.LocationID, GJS.Nationality,
			GJS.HighestEducationLevel, GJS.YearOfWorkExperience, GJS.P1Position, GJS.P1JobFunction, GJS.P1Company, GJS.P1EmploymentPeriodStart, GJS.P1EmploymentPeriodEnd, GJS.P1ToPresent, GJS.HasP1Data, GJS.CurrencyCountry, GJS.SalaryType, GJS.SalaryFrom, GJS.SalaryTo,
			CAST(CASE WHEN GJPR.JobseekerId IS NOT NULL THEN (CASE WHEN GJPR.ShowLess = 0 THEN 1 ELSE 2 END) ELSE 0 END AS TINYINT) AS ParsedResume
FROM		JobsDB_Global.dbo.JsGlobal_JobSeekerBase AS GJS WITH (NOLOCK) INNER JOIN
			JobsDB_Global.dbo.JsGlobal_JobSeekerEmail AS GJSE WITH (NOLOCK) ON GJS.Id=GJSE.JobSeekerId INNER JOIN
			dbo.JsJobSeeker AS JS WITH (NOLOCK) ON GJS.Id=JS.Id LEFT JOIN
			(SELECT JobseekerId, ShowLess FROM JobsDB_Global.dbo.JsGlobal_ParsedJsResume WITH (NOLOCK) WHERE EmptyContent = 0) AS GJPR ON GJS.Id=GJPR.JobseekerId
WHERE		(GJS.Status='A' OR GJS.Status='X') AND GJS.RegisterCountry='SG' AND GJS.HasP1Data IN (1,3,4)




