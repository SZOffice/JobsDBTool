/*
IsAddJob: $IsAddJob
IsAddCandidate: $IsAddCandidate

$if(IsAddJob==1)
JobCount: $JobCount
JobAdId: $foreach(job in JobList)$job.JobAdId, $end
JobTitle: $foreach(job in JobList)$job.JobTitle, $end
IndexofJobAd: $foreach(job in JobList)$job.IndexofJobAd, $end
$end

$if(IsAddCandidate==1)
CandidateCount: $CandidateCount
JobSeekerId: $foreach(candidate in CandidateList)$candidate.JobSeekerId, $end
Email: $foreach(candidate in CandidateList)$candidate.Email, $end
IsNewWorkforce: $IsNewWorkforce
IndexofCandidate:$foreach(candidate in CandidateList)$candidate.IndexofCandidate, $end
$end
*/


$if(IsAddJob==1)
$foreach(job in JobList)
/*start add job ad*/
USE [JobsDB_$CountryCode];
Go

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
SET DATEFORMAT YMD
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION

Declare @JobAdId BIGINT, @JobTitle nvarchar(200), @Now DATETIME, @InvoiceItemID int,
	@EmployerId BIGINT, @AccountNum BIGINT, @SubAccount BIGINT;
Select @JobAdId=$job.JobAdId, @JobTitle=N'$job.JobTitle', @Now = GETUTCDATE(), @InvoiceItemID=$InvoiceItemID,
	@EmployerId=$EmployerId, @AccountNum=$AccountNum, @SubAccount=$SubAccount;
		
-- Pointer used for text / image updates. This might not be needed, but is declared here just in case
DECLARE @pv binary(16)

PRINT(N'Add row to [dbo].[JobAd]')
INSERT INTO [dbo].[JobAd] ([Id], [AdsRef], [Company], [ActualCompanyName], [CompanyAltLang], [ActualCompanyAltLang], [HideCompanyNameFlag], [AccountNum], [SubAccount], [EmployerId], [RegCountry], [CountryCode], [CompanyDescription], [JobTitle], [JobTitleAltLang], [RefNo], [JobDescriptionRequirement], [JobDescriptionRequirementSystemModified], [JobDescriptionRequirementAltLang], [CareerLevel], [IndustryId], [JobLocationId], [CompanyLogoPath], [CompanyLogoId], [SalaryFrom], [SalaryTo], [SalaryType], [SalaryAdditionalInfo], [SalaryVisibleToJobseeker], [MonthlySalaryMin], [MonthlySalaryMax], [SalaryNegotiable], [utcFirstPostTime], [StartDate], [utcDisplayPostTime], [EndDate], [utcExpiryTime], [Keywords], [EducationLevel], [WorkExperience], [WorkExperienceFreshGrad], [Nationality], [WorkAuthorization], [ReceiveJobAppVia], [ReceiveResumesFrom], [EmailResumesTo], [EmailResumesCCTo], [EmploymentTermFullTime], [EmploymentTermPartTime], [EmploymentTermPermanent], [EmploymentTermTemporary], [EmploymentTermContract], [EmploymentTermInternship], [EmploymentTermFreelance], [EmploymentTermContractToPerm], [EmploymentTermTempToPerm], [EmploymentTermNonImmigrantVisa], [BenefitFivedayworkweek], [BenefitFlexibleWorkingHours], [BenefitWorkfromhome], [BenefitMedicalinsurance], [BenefitDentalinsurance], [BenefitLifeinsurance], [BenefitDoublepay], [BenefitPerformancebonus], [BenefitGratuity], [BenefitOvertimepay], [BenefitEducationallowance], [BenefitHousingallowance], [BenefitTravelallowance], [BenefitFreeshuttlebus], [BenefitTransportationallowance], [EmpTemplateId], [JobsDBTemplateId], [HostOpt], [AdsType], [DataStatus], [JobAdFolderId], [Status], [WithRefund], [WithTerminatedInvoice], [MapSdId], [MapX], [MapY], [MapIsDisplay], [MapPostalCode], [MapCoId], [MapPlaceCategory], [MapPlaceName], [MapBlock], [MapStreetName], [MapUrl], [DisplayEffects], [Highlight], [ListingPriority], [utcLastModifiedTime], [utcIndexLastUpdatedTime], [utcCreatedTime], [utcDeactivatedTime], [VersionSequence], [CompanyAddress], [RepostParentId], [RepostParentAdsRef], [InvoiceItemID], [LocalResidentOnly], [AgeFrom], [AgeTo], [Race], [Gender], [AvailabilityType], [AvailabilityAfterDate], [AvailabilityNumberOfMonthRequired], [Religion], [DivertToExternalWebsiteLink], [DeactivatePreviousJobPost], [CompanyDescriptionIsInClassicMode], [JobDescriptionRequirementIsInClassicMode], [SystemScript], [NotShowInNormalJobList], [CompURL], [AccountType], [utcLastCompletelyIndexedTime], [ShortAdsRef], [JobDescriptionSnippet], [ShortDescription1], [ShortDescription2], [ShortDescription3], [JobLocationOverseasCountryId], [JobLocationOverseasCity], [IsRisky], [AdditionalServices], [BrandedAdTemplateId], [BrandedAdLogoFileName], [IsParent], [AutoRepostScheduledFrequency]) VALUES (@JobAdId, 'J$CountryCode@JobAdId', N'Company #1', N'Company #1', N'', N'', 0, @AccountNum, @SubAccount, @EmployerId, '$CountryCode', '$ToCountryCode', N'', @JobTitle, N'', '', N'<p>dev demo $CountryCode to $ToCountryCode desc</p>', NULL, NULL, 0, 2, 2147483647, N'https://v8.dev.content.jobsdb.com/Content/CmsContent/Logo/$CountryCode/JobsDBFiles/CompanyLogo/demoLogo1.jpg', 817, 11000, 13999, 1, 3, 0, NULL, NULL, NULL, @Now, @Now, @Now, DATEADD(m, 1, @Now), DATEADD(m, 1, @Now), N'', 0, 0, 0, NULL, NULL, 1, 2, 'miragelu+$job.IndexofJobAd@jobsdb.com', NULL, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, 1, 'J', 'N', 1, 0, 'A', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, 0, @Now, @Now, @Now, NULL, 2, NULL, NULL, NULL, @InvoiceItemID, NULL, NULL, NULL, 0, 0, 0, NULL, NULL, 0, '', 1, 0, 0, NULL, NULL, NULL, 'M', '1753-01-01 00:00:00.000', 'H00001N', N'', N'summary points 1', N'summary points 2', N'summary points 3', 0, N'', 0, 0, 0, '', NULL, -1)

PRINT(N'Add row to [dbo].[JobAd_CategoryAssociate]')
INSERT INTO [dbo].[JobAd_CategoryAssociate] ([JobAdId], [JobAdCategoryId]) VALUES (@JobAdId, 16)

PRINT(N'Add row to [dbo].[JobAd_Data]')
INSERT INTO [dbo].[JobAd_Data] ([Id], [JobTitleSlug], [ContactTelNum]) VALUES (@JobAdId, @JobTitle, '')

PRINT(N'Add row to [dbo].[JobAd_Statistic]')
INSERT INTO [dbo].[JobAd_Statistic] ([Id], [utcCreatedTime], [utcLastModifiedTime], [TotalCandidate], [JobApplicationCount], [JobApplicationMemberCount], [JobApplicationMemberWithAttachmentResumeCount], [JobApplicationMemberWithOnlineResumeCount], [JobApplicationNonMemberCount], [ApprovedResumeRequestCount], [CopyFromOtherJobCount], [UnprocessedCandidateCount]) VALUES (@JobAdId, @Now, @Now, 0, 0, 0, 0, 0, 0, 0, 0, 0)
COMMIT TRANSACTION

Go
$if(CountryCode!=ToCountryCode)
USE [JobsDB_$ToCountryCode];
Go

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
SET DATEFORMAT YMD
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION

Declare @JobAdId BIGINT, @JobTitle nvarchar(200), @Now DATETIME, @InvoiceItemID int,
	@EmployerId BIGINT, @AccountNum BIGINT, @SubAccount BIGINT;
Select @JobAdId=$job.JobAdId, @JobTitle=N'$job.JobTitle', @Now = GETUTCDATE(), @InvoiceItemID=$InvoiceItemID,
	@EmployerId=$EmployerId, @AccountNum=$AccountNum, @SubAccount=$SubAccount;
		
-- Pointer used for text / image updates. This might not be needed, but is declared here just in case
DECLARE @pv binary(16)

PRINT(N'Add row to [dbo].[JobAd]')
INSERT INTO [dbo].[JobAd] ([Id], [AdsRef], [Company], [ActualCompanyName], [CompanyAltLang], [ActualCompanyAltLang], [HideCompanyNameFlag], [AccountNum], [SubAccount], [EmployerId], [RegCountry], [CountryCode], [CompanyDescription], [JobTitle], [JobTitleAltLang], [RefNo], [JobDescriptionRequirement], [JobDescriptionRequirementSystemModified], [JobDescriptionRequirementAltLang], [CareerLevel], [IndustryId], [JobLocationId], [CompanyLogoPath], [CompanyLogoId], [SalaryFrom], [SalaryTo], [SalaryType], [SalaryAdditionalInfo], [SalaryVisibleToJobseeker], [MonthlySalaryMin], [MonthlySalaryMax], [SalaryNegotiable], [utcFirstPostTime], [StartDate], [utcDisplayPostTime], [EndDate], [utcExpiryTime], [Keywords], [EducationLevel], [WorkExperience], [WorkExperienceFreshGrad], [Nationality], [WorkAuthorization], [ReceiveJobAppVia], [ReceiveResumesFrom], [EmailResumesTo], [EmailResumesCCTo], [EmploymentTermFullTime], [EmploymentTermPartTime], [EmploymentTermPermanent], [EmploymentTermTemporary], [EmploymentTermContract], [EmploymentTermInternship], [EmploymentTermFreelance], [EmploymentTermContractToPerm], [EmploymentTermTempToPerm], [EmploymentTermNonImmigrantVisa], [BenefitFivedayworkweek], [BenefitFlexibleWorkingHours], [BenefitWorkfromhome], [BenefitMedicalinsurance], [BenefitDentalinsurance], [BenefitLifeinsurance], [BenefitDoublepay], [BenefitPerformancebonus], [BenefitGratuity], [BenefitOvertimepay], [BenefitEducationallowance], [BenefitHousingallowance], [BenefitTravelallowance], [BenefitFreeshuttlebus], [BenefitTransportationallowance], [EmpTemplateId], [JobsDBTemplateId], [HostOpt], [AdsType], [DataStatus], [JobAdFolderId], [Status], [WithRefund], [WithTerminatedInvoice], [MapSdId], [MapX], [MapY], [MapIsDisplay], [MapPostalCode], [MapCoId], [MapPlaceCategory], [MapPlaceName], [MapBlock], [MapStreetName], [MapUrl], [DisplayEffects], [Highlight], [ListingPriority], [utcLastModifiedTime], [utcIndexLastUpdatedTime], [utcCreatedTime], [utcDeactivatedTime], [VersionSequence], [CompanyAddress], [RepostParentId], [RepostParentAdsRef], [InvoiceItemID], [LocalResidentOnly], [AgeFrom], [AgeTo], [Race], [Gender], [AvailabilityType], [AvailabilityAfterDate], [AvailabilityNumberOfMonthRequired], [Religion], [DivertToExternalWebsiteLink], [DeactivatePreviousJobPost], [CompanyDescriptionIsInClassicMode], [JobDescriptionRequirementIsInClassicMode], [SystemScript], [NotShowInNormalJobList], [CompURL], [AccountType], [utcLastCompletelyIndexedTime], [ShortAdsRef], [JobDescriptionSnippet], [ShortDescription1], [ShortDescription2], [ShortDescription3], [JobLocationOverseasCountryId], [JobLocationOverseasCity], [IsRisky], [AdditionalServices], [BrandedAdTemplateId], [BrandedAdLogoFileName], [IsParent], [AutoRepostScheduledFrequency]) VALUES (@JobAdId, 'J$CountryCode@JobAdId', N'Company #1', N'Company #1', N'', N'', 0, @AccountNum, @SubAccount, @EmployerId, '$CountryCode', '$ToCountryCode', N'', @JobTitle, N'', '', N'<p>dev demo $CountryCode to $ToCountryCode desc</p>', NULL, NULL, 0, 2, 2147483647, N'https://v8.dev.content.jobsdb.com/Content/CmsContent/Logo/$CountryCode/JobsDBFiles/CompanyLogo/demoLogo1.jpg', 817, 11000, 13999, 1, 3, 0, NULL, NULL, NULL, @Now, @Now, @Now, DATEADD(m, 1, @Now), DATEADD(m, 1, @Now), N'', 0, 0, 0, NULL, NULL, 1, 2, 'miragelu+$job.IndexofJobAd@jobsdb.com', NULL, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, 1, 'J', 'N', 1, 0, 'A', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, 0, @Now, @Now, @Now, NULL, 2, NULL, NULL, NULL, @InvoiceItemID, NULL, NULL, NULL, 0, 0, 0, NULL, NULL, 0, '', 1, 0, 0, NULL, NULL, NULL, 'M', '1753-01-01 00:00:00.000', 'H00001N', N'', N'summary points 1', N'summary points 2', N'summary points 3', 0, N'', 0, 0, 0, '', NULL, -1)

PRINT(N'Add row to [dbo].[JobAd_CategoryAssociate]')
INSERT INTO [dbo].[JobAd_CategoryAssociate] ([JobAdId], [JobAdCategoryId]) VALUES (@JobAdId, 16)

PRINT(N'Add row to [dbo].[JobAd_Data]')
INSERT INTO [dbo].[JobAd_Data] ([Id], [JobTitleSlug], [ContactTelNum]) VALUES (@JobAdId, @JobTitle, '')

PRINT(N'Add row to [dbo].[JobAd_Statistic]')
INSERT INTO [dbo].[JobAd_Statistic] ([Id], [utcCreatedTime], [utcLastModifiedTime], [TotalCandidate], [JobApplicationCount], [JobApplicationMemberCount], [JobApplicationMemberWithAttachmentResumeCount], [JobApplicationMemberWithOnlineResumeCount], [JobApplicationNonMemberCount], [ApprovedResumeRequestCount], [CopyFromOtherJobCount], [UnprocessedCandidateCount]) VALUES (@JobAdId, @Now, @Now, 0, 0, 0, 0, 0, 0, 0, 0, 0)

COMMIT TRANSACTION
GO

$end

/*end add job ad*/
$end
$end


$if(IsAddCandidate==1)
$foreach(candidate in CandidateList)
/*start add job seeker*/
USE [JobsDB_Global];
Go
		
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
SET DATEFORMAT YMD
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
-- Pointer used for text / image updates. This might not be needed, but is declared here just in case
DECLARE @pv binary(16)

Declare @JobSeekerId BIGINT, @Email nvarchar(200), @JobSeekerEmailId BIGINT, @JsResumeId BIGINT,
	@JobSeekerStateID BIGINT, @JobSeekerStatisticID BIGINT, @JobSeekerWorkExperienceID BIGINT,
	@JobSeekerBasePastItem BIGINT, @Now DATETIME;
Select @JobSeekerId=$candidate.JobSeekerId, @Email=N'$candidate.Email', @JsResumeId=$candidate.JobSeekerId,
	@JobSeekerEmailId=$candidate.JobSeekerId, 
	@JobSeekerStateID=$candidate.JobSeekerId, @JobSeekerStatisticID=$candidate.JobSeekerId, --JobSeekerStatisticID*2
	@JobSeekerWorkExperienceID=$candidate.JobSeekerId, @JobSeekerBasePastItem=$candidate.JobSeekerId,--@JobSeekerBasePastItem*4 
	@Now = GETUTCDATE();

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerBase]')
INSERT INTO [dbo].[JsGlobal_JobSeekerBase] ([Id], [utcLastModifiedTime], [utcIndexLastUpdatedTime], [utcCreatedTime], [RegisterCountry], [EmailAddress], [EncryptedPassword], [Title], [FirstName], [MiddleName], [LastName], [PrimaryContactType], [PrimaryContactNo], [SecondaryContactType], [SecondaryContactNo], [VerificationLevel], [Gender], [DateOfBirth], [CountryOfResidence], [SpecificCountryOfResidence], [utcVerifiedDate], [utcVerificationEmailSentTime], [VerificationEmailSent], [HasPendingEmailChange], [PendingEmailAddress], [JobAlertEmailFormat], [MyJobsDBSectionsOrder], [Guid], [Status], [DeletedKey], [NonUniqueEmailKey], [VersionNumber], [VersionDc], [IsMiniProfile], [HasSkippedFillMoreInfo], [LatestJobTitle], [LatestJobFunction], [AccountCompletedLevel], [IsJobAlertRegistered], [PrimaryContactAreaCode], [HighestEducationLevel], [YearOfWorkExperience], [LocationId], [HasP1Data], [PrimaryContactAreaID], [P1Position], [P1JobFunction], [P1Company], [P1EmploymentPeriodStart], [P1EmploymentPeriodEnd], [P1ToPresent], [Nationality], [ProfilePrivacyLevel], [DefaultResumeID], [DefaultResumeCountry], [DefaultResumeStatus], [HasP1Plus], [utcP1CreatedTime], [utcProfileLastModifiedTime], [utcLastActivityTime], [CurrencyCountry], [SalaryFrom], [SalaryTo], [SalaryType], [P1Industry], [SalaryFromApplication]) 
VALUES (@JobSeekerId, @Now, @Now, @Now, '$JobSeekerCountryCode', @Email, '7C4A8D09CA3762AF61E59520943DC26494F8941B', NULL, N'$candidate.FirstName$candidate.IndexofCandidate', N'', N'$candidate.LastName', 1, '111', 0, '', 1, 3, NULL, $CountryOfResidence, N'', @Now, @Now, 1, 0, '', 2, NULL, '20b43039-c5b4-424b-8cf7-bb0ebadf6676', 'A', NULL, NULL, 5, 1, 1, 0, N'latest job $candidate.IndexofCandidate -- $candidate.Email', 46, NULL, 0, '', 14, 
$if(IsNewWorkforce==1)
1
$else
4
$end, 0, 1, 2, N'latest job  $candidate.IndexofCandidate', 46, N'latest employer $candidate.IndexofCandidate', '2008-04-01', '9999-01-01', 1, 0, $ProfilePrivacyLevel, 
$if(IsNewWorkforce==1)
0, '', 0
$else
@JsResumeId, '$JobSeekerCountryCode', 2
$end, 0, @Now, @Now, @Now, 'HK', 46000, 59800, 1, 36, 1)

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerEligibleToWorkAssociate]')
INSERT INTO [dbo].[JsGlobal_JobSeekerEligibleToWorkAssociate] ([EligibleToWork], [JobSeekerId], [FromWorkPermit]) VALUES ($CountryOfResidence, @JobSeekerId, 1)

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerEmail]')
INSERT INTO [dbo].[JsGlobal_JobSeekerEmail] ([Id], [utcCreatedTime], [utcLastModifiedTime], [JobSeekerId], [EmailAddress], [Status], [DeletedKey], [NonUniqueEmailKey], [VerificationLevel], [utcVerifiedDate], [VersionNumber], [VersionDc]) VALUES (@JobSeekerEmailId, '2015-09-25 02:59:02.723', '2015-09-25 02:59:02.723', @JobSeekerId, @Email, 'A', NULL, NULL, 0, NULL, 1, 1)

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerEmailMetaItem]')
INSERT INTO [dbo].[JsGlobal_JobSeekerEmailMetaItem] ([Id], [utcLastModifiedTime], [utcCreatedTime], [VersionNumber], [VersionDc], [utcVersionTimestamp], [VersionKnowledge]) VALUES (@JobSeekerEmailId, '2015-09-25 02:59:02.730', '2015-09-25 02:59:02.730', 1, 1, '2015-09-25 02:59:02.000', '1|1;')

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerMetaItem]')
INSERT INTO [dbo].[JsGlobal_JobSeekerMetaItem] ([Id], [utcLastModifiedTime], [utcCreatedTime], [VersionNumber], [VersionDc], [utcVersionTimestamp], [VersionKnowledge]) VALUES (@JobSeekerId, '2015-09-25 03:02:02.527', '2015-09-25 02:59:02.720', 5, 1, '2015-09-25 03:02:02.000', '5|1;4|1;3|1;2|1;1|1;')

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerState]')
INSERT INTO [dbo].[JsGlobal_JobSeekerState] ([Id], [utcCreatedTime], [utcLastModifiedTime], [JobSeekerId], [Country], [StateCategory], [State], [VersionNumber], [VersionDc]) VALUES (@JobSeekerStateID, '2015-09-25 02:59:03.020', '2015-09-25 02:59:03.020', @JobSeekerId, '$JobSeekerCountryCode', 1, 1, 1, 1)

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerStateMetaItem]')
INSERT INTO [dbo].[JsGlobal_JobSeekerStateMetaItem] ([Id], [utcLastModifiedTime], [utcCreatedTime], [VersionNumber], [VersionDc], [utcVersionTimestamp], [VersionKnowledge]) VALUES (@JobSeekerStateID, '2015-09-25 02:59:03.023', '2015-09-25 02:59:03.023', 1, 1, '2015-09-25 02:59:02.000', '1|1;')

PRINT(N'Add rows to [dbo].[JsGlobal_JobSeekerStatistic]')
INSERT INTO [dbo].[JsGlobal_JobSeekerStatistic] ([Id], [utcCreatedTime], [utcLastModifiedTime], [JobSeekerId], [Country], [StatisticCategory], [StatisticValue], [IsCount], [VersionNumber], [VersionDc]) VALUES (@JobSeekerStatisticID, '2015-09-25 02:59:02.733', '2015-09-25 02:59:02.733', @JobSeekerId, '$JobSeekerCountryCode', 8, 1, 0, 1, 1)
INSERT INTO [dbo].[JsGlobal_JobSeekerStatistic] ([Id], [utcCreatedTime], [utcLastModifiedTime], [JobSeekerId], [Country], [StatisticCategory], [StatisticValue], [IsCount], [VersionNumber], [VersionDc]) VALUES (@JobSeekerStatisticID+1, '2015-09-25 03:02:02.583', '2015-09-25 03:02:02.583', @JobSeekerId, '$JobSeekerCountryCode', 4, 1, 1, 1, 1)
PRINT(N'Operation applied to 2 rows out of 2')

PRINT(N'Add rows to [dbo].[JsGlobal_JobSeekerStatisticMetaItem]')
INSERT INTO [dbo].[JsGlobal_JobSeekerStatisticMetaItem] ([Id], [utcLastModifiedTime], [utcCreatedTime], [VersionNumber], [VersionDc], [utcVersionTimestamp], [VersionKnowledge]) VALUES (@JobSeekerStatisticID, '2015-09-25 02:59:02.740', '2015-09-25 02:59:02.740', 1, 1, '2015-09-25 02:59:02.000', '1|1;')
INSERT INTO [dbo].[JsGlobal_JobSeekerStatisticMetaItem] ([Id], [utcLastModifiedTime], [utcCreatedTime], [VersionNumber], [VersionDc], [utcVersionTimestamp], [VersionKnowledge]) VALUES (@JobSeekerStatisticID+1, '2015-09-25 03:02:02.587', '2015-09-25 03:02:02.587', 1, 1, '2015-09-25 03:02:02.000', '1|1;')
PRINT(N'Operation applied to 2 rows out of 2')

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerEducation]')
INSERT INTO [dbo].[JsGlobal_JobSeekerEducation] (JobSeekerId, EducationLevel, Institution, CompletedYear, FieldOfStudy, Grade) VALUES (@JobSeekerId, 14, N'Institution_$candidate.JobSeekerId', 1998, 'FieldOfStudy_$candidate.JobSeekerId', N'Grade_$candidate.JobSeekerId')
INSERT INTO [dbo].[JsGlobal_JobSeekerEducation] (JobSeekerId, EducationLevel, Institution, CompletedYear, FieldOfStudy, Grade) VALUES (@JobSeekerId, 14, N'Institution2_$candidate.JobSeekerId', 1994, 'FieldOfStudy2_$candidate.JobSeekerId', N'Grade2_$candidate.JobSeekerId')

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerSkill]')
INSERT INTO [dbo].[JsGlobal_JobSeekerSkill] (JobSeekerId, Skill) VALUES (@JobSeekerId, N'C#_$candidate.JobSeekerId')
INSERT INTO [dbo].[JsGlobal_JobSeekerSkill] (JobSeekerId, Skill) VALUES (@JobSeekerId, N'css_$candidate.JobSeekerId')

$if(IsNewWorkforce==1)
COMMIT TRANSACTION
GO
$else
PRINT(N'Add rows to [dbo].[JsGlobal_JobSeekerBasePastItem]')
SET IDENTITY_INSERT [dbo].[JsGlobal_JobSeekerBasePastItem] ON
INSERT INTO [dbo].[JsGlobal_JobSeekerBasePastItem] ([Id], [utcLastModifiedTime], [utcIndexLastUpdatedTime], [utcCreatedTime], [DataReferenceId], [RegisterCountry], [EmailAddress], [EncryptedPassword], [Title], [FirstName], [MiddleName], [LastName], [PrimaryContactType], [PrimaryContactNo], [SecondaryContactType], [SecondaryContactNo], [VerificationLevel], [Gender], [DateOfBirth], [CountryOfResidence], [SpecificCountryOfResidence], [utcVerifiedDate], [utcVerificationEmailSentTime], [VerificationEmailSent], [HasPendingEmailChange], [PendingEmailAddress], [JobAlertEmailFormat], [MyJobsDBSectionsOrder], [Guid], [Status], [DeletedKey], [NonUniqueEmailKey], [VersionNumber], [VersionDc]) VALUES (@JobSeekerBasePastItem, '2015-09-25 02:59:34.737', '2015-09-25 02:58:59.000', '2015-09-25 02:59:34.737', @JobSeekerId, '$JobSeekerCountryCode', @Email, '7C4A8D09CA3762AF61E59520943DC26494F8941B', NULL, N'mirage', N'', N'lu', NULL, '', NULL, NULL, 1, 3, NULL, 0, NULL, '2015-09-25 02:58:59.000', '2015-09-25 02:58:59.000', 1, 0, '', 2, NULL, '20b43039-c5b4-424b-8cf7-bb0ebadf6676', 'A', NULL, NULL, 1, 1)
INSERT INTO [dbo].[JsGlobal_JobSeekerBasePastItem] ([Id], [utcLastModifiedTime], [utcIndexLastUpdatedTime], [utcCreatedTime], [DataReferenceId], [RegisterCountry], [EmailAddress], [EncryptedPassword], [Title], [FirstName], [MiddleName], [LastName], [PrimaryContactType], [PrimaryContactNo], [SecondaryContactType], [SecondaryContactNo], [VerificationLevel], [Gender], [DateOfBirth], [CountryOfResidence], [SpecificCountryOfResidence], [utcVerifiedDate], [utcVerificationEmailSentTime], [VerificationEmailSent], [HasPendingEmailChange], [PendingEmailAddress], [JobAlertEmailFormat], [MyJobsDBSectionsOrder], [Guid], [Status], [DeletedKey], [NonUniqueEmailKey], [VersionNumber], [VersionDc]) VALUES (@JobSeekerBasePastItem+1, '2015-09-25 02:59:41.583', '2015-09-25 02:59:34.000', '2015-09-25 02:59:41.583', @JobSeekerId, '$JobSeekerCountryCode', @Email, '7C4A8D09CA3762AF61E59520943DC26494F8941B', NULL, N'mirage', N'', N'lu', NULL, '', NULL, NULL, 1, 3, NULL, 2, NULL, '2015-09-25 02:58:59.000', '2015-09-25 02:58:59.000', 1, 0, '', 2, NULL, '20b43039-c5b4-424b-8cf7-bb0ebadf6676', 'A', NULL, NULL, 2, 1)
INSERT INTO [dbo].[JsGlobal_JobSeekerBasePastItem] ([Id], [utcLastModifiedTime], [utcIndexLastUpdatedTime], [utcCreatedTime], [DataReferenceId], [RegisterCountry], [EmailAddress], [EncryptedPassword], [Title], [FirstName], [MiddleName], [LastName], [PrimaryContactType], [PrimaryContactNo], [SecondaryContactType], [SecondaryContactNo], [VerificationLevel], [Gender], [DateOfBirth], [CountryOfResidence], [SpecificCountryOfResidence], [utcVerifiedDate], [utcVerificationEmailSentTime], [VerificationEmailSent], [HasPendingEmailChange], [PendingEmailAddress], [JobAlertEmailFormat], [MyJobsDBSectionsOrder], [Guid], [Status], [DeletedKey], [NonUniqueEmailKey], [VersionNumber], [VersionDc]) VALUES (@JobSeekerBasePastItem+2, '2015-09-25 03:00:52.773', '2015-09-25 02:59:41.000', '2015-09-25 03:00:52.773', @JobSeekerId, '$JobSeekerCountryCode', @Email, '7C4A8D09CA3762AF61E59520943DC26494F8941B', NULL, N'mirage', N'', N'lu', NULL, '', NULL, NULL, 1, 3, NULL, 2, NULL, '2015-09-25 02:58:59.000', '2015-09-25 02:58:59.000', 1, 0, '', 2, NULL, '20b43039-c5b4-424b-8cf7-bb0ebadf6676', 'A', NULL, NULL, 3, 1)
INSERT INTO [dbo].[JsGlobal_JobSeekerBasePastItem] ([Id], [utcLastModifiedTime], [utcIndexLastUpdatedTime], [utcCreatedTime], [DataReferenceId], [RegisterCountry], [EmailAddress], [EncryptedPassword], [Title], [FirstName], [MiddleName], [LastName], [PrimaryContactType], [PrimaryContactNo], [SecondaryContactType], [SecondaryContactNo], [VerificationLevel], [Gender], [DateOfBirth], [CountryOfResidence], [SpecificCountryOfResidence], [utcVerifiedDate], [utcVerificationEmailSentTime], [VerificationEmailSent], [HasPendingEmailChange], [PendingEmailAddress], [JobAlertEmailFormat], [MyJobsDBSectionsOrder], [Guid], [Status], [DeletedKey], [NonUniqueEmailKey], [VersionNumber], [VersionDc]) VALUES (@JobSeekerBasePastItem+3, '2015-09-25 03:02:02.493', '2015-09-25 03:02:02.000', '2015-09-25 03:02:02.493', @JobSeekerId, '$JobSeekerCountryCode', @Email, '7C4A8D09CA3762AF61E59520943DC26494F8941B', NULL, N'mirage', N'', N'lu', 1, '111', 0, '', 1, 3, NULL, 2, N'', '2015-09-25 02:58:59.000', '2015-09-25 02:58:59.000', 1, 0, '', 2, NULL, '20b43039-c5b4-424b-8cf7-bb0ebadf6676', 'A', NULL, NULL, 4, 1)
SET IDENTITY_INSERT [dbo].[JsGlobal_JobSeekerBasePastItem] OFF
PRINT(N'Operation applied to 4 rows out of 4')

PRINT(N'Add row to [dbo].[JsGlobal_JobSeekerWorkExperience]')
SET IDENTITY_INSERT [dbo].[JsGlobal_JobSeekerWorkExperience] ON
INSERT INTO [dbo].[JsGlobal_JobSeekerWorkExperience] ([Id], [JobSeekerId], [Sequence], [Position], [Company], [EmploymentPeriodStart], [EmploymentPeriodEnd], [ToPresent], [JobFunction], [Industry], [JobDuties]) VALUES (@JobSeekerWorkExperienceID, @JobSeekerId, 0, N'latest job $candidate.IndexofCandidate -- $candidate.Email', N'latest employer $candidate.IndexofCandidate', '2008-04-01', '9999-12-01', 1, 46, 9, N'')
SET IDENTITY_INSERT [dbo].[JsGlobal_JobSeekerWorkExperience] OFF
COMMIT TRANSACTION
GO

PRINT(N'Reseed identity on [dbo].[JsGlobal_JobSeekerWorkExperience]')
DBCC CHECKIDENT(N'[dbo].[JsGlobal_JobSeekerWorkExperience]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsGlobal_JobSeekerWorkExperience]', RESEED)
GO

PRINT(N'Reseed identity on [dbo].[JsGlobal_JobSeekerBasePastItem]')
DBCC CHECKIDENT(N'[dbo].[JsGlobal_JobSeekerBasePastItem]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsGlobal_JobSeekerBasePastItem]', RESEED)
GO
$end


USE [JobsDB_$JobSeekerCountryCode];
Go

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
SET DATEFORMAT YMD
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
-- Pointer used for text / image updates. This might not be needed, but is declared here just in case
DECLARE @pv binary(16)


Declare @JobSeekerId BIGINT, @JsResumeId BIGINT,
	@JsResume_Other_ID BIGINT, @JsResume_WorkExperience_ID BIGINT;
Select @JobSeekerId=$candidate.JobSeekerId, @JsResumeId=$candidate.JobSeekerId,
	@JsResume_Other_ID=$candidate.JobSeekerId, @JsResume_WorkExperience_ID=$candidate.JobSeekerId;

PRINT(N'Add row to [dbo].[JsJobSeeker]')
INSERT INTO [dbo].[JsJobSeeker] ([Id], [utcLastModifiedTime], [utcCreatedTime], [utcLastLoginTime], [SubscribeJobsDBNews], [Subscribe88DBNews], [SubscribeAdvertisers], [SubscribeJobsAlert], [SeekingJobCategory], [IsMember], [BarCode], [MembershipCardNumber], [MembershipCardExpiryYear], [MembershipCardExpiryMonth], [WorkPermit], [utcLastActivityTime], [ProfileIsIndexPending], [ProfileUtcLastIndexedTime], [ProfileUtcIndexedLastModifiedTime]) VALUES (@JobSeekerId, '2015-09-25 03:02:02.523', '2015-09-25 02:58:59.843', NULL, 0, 0, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 1, '2015-09-25 03:02:02.000', 0, '1899-12-31 00:00:00.000', '1899-12-31 00:00:00.000')

$if(IsNewWorkforce==1)
COMMIT TRANSACTION
GO
$else
PRINT(N'Add row to [dbo].[JsResume]')
INSERT INTO [dbo].[JsResume] ([Id], [JobSeekerId], [utcLastModifiedTime], [utcCreatedTime], [CreateCountry], [ResumeTitle], [MaritalStatus], [Nationality], [ResidentialStatus], [NumberOfChildren], [Race], [Religion], [NationalService], [PassportType], [PassportNo], [DrivingLicenseType], [HasDrivingLicense], [OwnedVehicle], [OwnedCreditCard], [AddressLine1], [AddressLine2], [PostalCode], [LivingLocationId], [FreshGradFlag], [HighestEducationLevel], [YearOfWorkExperience], [LatestJobTitle], [LatestJobFunction], [LatestIndustrySector], [LatestCareerLevel], [AuthorizedToWork], [ExpectedSalary], [SalaryNegotiable], [AvailabilityType], [AvailabilityAfterDate], [AvailabilityNumberOfMonthRequired], [SkillsContent], [LanguageSpoken], [LanguageWritten], [CareerObjective], [HidePreviousEmployer], [JsResumeTemplateId], [ReleasedFlag], [ReleasedParentId], [ResumeRef], [SeekingJobFunction], [LatestSalary], [SeekingIndustrySector], [SeekingJobTitle], [utcLastUpdatedTimeForSearchIndex], [utcLastUpdatedTimeForSorting], [SectionsOrder], [ResumeVersion], [PrivacyStatus], [ApprovalStatus], [utcApprovedTime], [NeedsVerify], [AttachmentId], [AttachmentFileName], [AttachmentCountryCode], [VersionSequence], [Status], [PhotoAttachmentId], [PhotoAttachmentFileName], [PhotoThumbnailAttachmentId], [PhotoAttachmentCountryCode], [ProfessionalCertificationRawXml], [LatestEducationSchool], [LatestEducationQualification], [LatestEducationMajor], [LatestEducationGrade], [LatestCompany], [HideGender], [HideDateOfBirth], [SubmitSource], [NationalityId]) VALUES (@JsResumeId, @JobSeekerId, '2015-09-25 03:02:02.397', '2015-09-25 03:02:02.397', '$JobSeekerCountryCode', N'Resume Title $candidate.IndexofCandidate', 0, NULL, 0, '', 0, 0, 0, 0, '', NULL, NULL, 0, 0, N'Address Line 1', N'', '', 0, NULL, 14, 3, N'latest job $candidate.IndexofCandidate -- $candidate.Email', 46, 9, 3, 1, 1222, 0, 1, NULL, 10, N'', N'', N'', N'<p><a>Executive Summary/ Career Objective</a></p>', NULL, 1, 0, 0, 'C$JobSeekerCountryCode$candidate.JobSeekerId', NULL, NULL, NULL, NULL, NULL, NULL, '1,2,3,4,5,6,7,8,9', 1, 0, 2, NULL, 1, NULL, NULL, NULL, 1, 'A', NULL, NULL, NULL, NULL, N'', N'Institution', N'Qualification', N'Field of Study $candidate.IndexofCandidate', N'Grade GPA $candidate.IndexofCandidate', N'Company $candidate.IndexofCandidate', NULL, NULL, NULL, 0)

PRINT(N'Add row to [dbo].[JsResume_Education]')
SET IDENTITY_INSERT [dbo].[JsResume_Education] ON
INSERT INTO [dbo].[JsResume_Education] ([Id], [JsResumeId], [utcLastModifiedTime], [utcCreatedTime], [EducationPeriodStart], [EducationPeriodEnd], [School], [Qualification], [Major], [Grade]) VALUES (@JsResume_Other_ID, @JsResumeId, '2015-09-25 03:02:02.403', '2015-09-25 03:02:02.403', 2013, 2015, N'Institution $candidate.IndexofCandidate', N'Qualification $candidate.IndexofCandidate', N'Field of Study $candidate.IndexofCandidate', N'Grade GPA $candidate.IndexofCandidate')
SET IDENTITY_INSERT [dbo].[JsResume_Education] OFF

PRINT(N'Add row to [dbo].[JsResume_EmploymentPreference]')
SET IDENTITY_INSERT [dbo].[JsResume_EmploymentPreference] ON
INSERT INTO [dbo].[JsResume_EmploymentPreference] ([Id], [JsResumeId], [utcLastModifiedTime], [utcCreatedTime], [InterestedPositionFirst], [InterestedPositionSecond], [InterestedIndustry], [EmploymentTermFullTime], [EmploymentTermPartTime], [EmploymentTermPermanent], [EmploymentTermTemporary], [EmploymentTermContract], [EmploymentTermFreelance], [EmploymentTermInternship], [EmploymentTermContractToPerm], [EmploymentTermTempToPerm], [EmploymentTermNonImmigrantVisa], [WillingToWorkOverseas], [WillingToTravel], [AdditionalInformation]) VALUES (@JsResume_Other_ID, @JsResumeId, '2015-09-25 03:02:02.447', '2015-09-25 03:02:02.447', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[JsResume_EmploymentPreference] OFF

PRINT(N'Add row to [dbo].[JsResume_Link]')
SET IDENTITY_INSERT [dbo].[JsResume_Link] ON
INSERT INTO [dbo].[JsResume_Link] ([Id], [JsResumeId], [utcLastModifiedTime], [utcCreatedTime], [Label], [Url]) VALUES (@JsResume_Other_ID, @JsResumeId, '2015-09-25 03:02:02.430', '2015-09-25 03:02:02.430', N'', N'')
SET IDENTITY_INSERT [dbo].[JsResume_Link] OFF

PRINT(N'Add row to [dbo].[JsResume_OwnSection]')
SET IDENTITY_INSERT [dbo].[JsResume_OwnSection] ON
INSERT INTO [dbo].[JsResume_OwnSection] ([Id], [JsResumeId], [utcLastModifiedTime], [utcCreatedTime], [Name], [Description]) VALUES (@JsResume_Other_ID, @JsResumeId, '2015-09-25 03:02:02.423', '2015-09-25 03:02:02.423', N'', N'')
SET IDENTITY_INSERT [dbo].[JsResume_OwnSection] OFF

PRINT(N'Add row to [dbo].[JsResume_Referee]')
SET IDENTITY_INSERT [dbo].[JsResume_Referee] ON
INSERT INTO [dbo].[JsResume_Referee] ([Id], [JsResumeId], [utcLastModifiedTime], [utcCreatedTime], [Referee], [CompanyInstitution], [Position], [ContactNo], [ContactEmail]) VALUES (@JsResume_Other_ID, @JsResumeId, '2015-09-25 03:02:02.420', '2015-09-25 03:02:02.420', N'', N'', N'', '', '')
SET IDENTITY_INSERT [dbo].[JsResume_Referee] OFF

PRINT(N'Add row to [dbo].[JsResume_SearchEngineIndexStatus]')
INSERT INTO [dbo].[JsResume_SearchEngineIndexStatus] ([Id], [JobSeekerId], [utcCreatedTime], [utcLastModifiedTime], [utcIndexLastUpdatedTime]) VALUES (@JsResumeId, @JobSeekerId, '2015-09-25 03:02:02.580', '2015-09-25 03:02:02.580', '2015-09-25 03:02:02.000')

PRINT(N'Add row to [dbo].[JsResume_WorkExperience]')
SET IDENTITY_INSERT [dbo].[JsResume_WorkExperience] ON
INSERT INTO [dbo].[JsResume_WorkExperience] ([Id], [JsResumeId], [utcLastModifiedTime], [utcCreatedTime], [EmploymentPeriodStartMonth], [EmploymentPeriodStartYear], [EmploymentPeriodEndMonth], [EmploymentPeriodEndYear], [ToPresent], [Company], [Position], [MonthlySalary], [JobDuties], [Latest]) VALUES (@JsResume_WorkExperience_ID, @JsResumeId, '2015-09-25 03:02:02.413', '2015-09-25 03:02:02.413', 3, 2008, 0, 0, 1, N'Company $candidate.IndexofCandidate', N'Position $candidate.IndexofCandidate', N'1111', N'<p><span>Job Duties $candidate.IndexofCandidate</span></p>', 1)
SET IDENTITY_INSERT [dbo].[JsResume_WorkExperience] OFF
COMMIT TRANSACTION
GO

PRINT(N'Reseed identity on [dbo].[JsResume_WorkExperience]')
DBCC CHECKIDENT(N'[dbo].[JsResume_WorkExperience]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsResume_WorkExperience]', RESEED)
GO

PRINT(N'Reseed identity on [dbo].[JsResume_Referee]')
DBCC CHECKIDENT(N'[dbo].[JsResume_Referee]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsResume_Referee]', RESEED)
GO

PRINT(N'Reseed identity on [dbo].[JsResume_OwnSection]')
DBCC CHECKIDENT(N'[dbo].[JsResume_OwnSection]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsResume_OwnSection]', RESEED)
GO

PRINT(N'Reseed identity on [dbo].[JsResume_Link]')
DBCC CHECKIDENT(N'[dbo].[JsResume_Link]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsResume_Link]', RESEED)
GO

PRINT(N'Reseed identity on [dbo].[JsResume_EmploymentPreference]')
DBCC CHECKIDENT(N'[dbo].[JsResume_EmploymentPreference]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsResume_EmploymentPreference]', RESEED)
GO

PRINT(N'Reseed identity on [dbo].[JsResume_Education]')
DBCC CHECKIDENT(N'[dbo].[JsResume_Education]', RESEED, 1)
DBCC CHECKIDENT(N'[dbo].[JsResume_Education]', RESEED)
GO
$end
/*end add job seeker*/
$end
$end