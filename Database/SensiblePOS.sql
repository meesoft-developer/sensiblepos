
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](256) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Firstname] [nvarchar](256) NULL,
	[Lastname] [nvarchar](256) NULL,
	[Effective] [datetime] NOT NULL,
	[Expire] [datetime] NOT NULL,
	[AccountType] [int] NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountActiveZone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[ZoneId] [int] NOT NULL,
	[AccountId] [int] NOT NULL,
	[IsExpired] [bit] NOT NULL,
	[ExpireDate] [datetime] NULL,
 CONSTRAINT [PK_AccountActiveZone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](32) NOT NULL,
	[Title] [nvarchar](64) NOT NULL,
	[AccessPortal] [bit] NOT NULL,
	[AccessReport] [bit] NOT NULL,
	[AccessClient] [bit] NOT NULL,
	[AccessAccountReport] [bit] NOT NULL,
	[AccessClientSummary] [bit] NOT NULL,
	[CanVoidReceipt] [bit] NOT NULL,
	[CanModifyData] [bit] NOT NULL,
	[CanModifyStock] [bit] NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_AccountType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[UserName] [varchar](256) NOT NULL,
	[Action] [varchar](64) NOT NULL,
	[Detail] [nvarchar](2048) NULL,
 CONSTRAINT [PK_AdminLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCardIssuer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](32) NOT NULL,
	[Title] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](256) NULL,
 CONSTRAINT [PK_CreditCardIssuer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](32) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[Title] [nvarchar](64) NULL,
	[FirstName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[NickName] [nvarchar](128) NULL,
	[IdCard] [varchar](30) NULL,
	[BirthDate] [datetime] NULL,
	[Gender] [int] NOT NULL,
	[RegisterAddress] [nvarchar](1024) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](256) NULL,
	[ImageData] [image] NULL,
	[LastReceipt] [varchar](64) NULL,
	[Comment] [nvarchar](512) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[CallerNumber] [varchar](32) NOT NULL,
	[TagType] [varchar](16) NOT NULL,
	[CustomerCode] [varchar](32) NOT NULL,
	[Inactive] [bit] NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CustomerTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTax](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[CustomerCode] [varchar](32) NOT NULL,
	[TaxName] [nvarchar](256) NULL,
	[TaxId] [varchar](64) NULL,
	[TaxAddress] [nvarchar](256) NULL,
	[Remarks] [nvarchar](512) NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_CustomerTax] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ErrorLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[Reporter] [varchar](64) NOT NULL,
	[Location] [varchar](64) NOT NULL,
	[Subject] [varchar](256) NULL,
	[Msg] [nvarchar](1024) NULL,
 CONSTRAINT [PK_ErrorLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holiday](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Effective] [datetime] NOT NULL,
	[Expire] [datetime] NOT NULL,
	[Title] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](512) NULL,
 CONSTRAINT [PK_Holiday] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Price](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[EffectiveDate] [datetime] NOT NULL,
	[ExpireDate] [datetime] NOT NULL,
	[Value] [decimal](18, 2) NOT NULL,
	[FirstHalfSale] [bit] NOT NULL,
	[SecondHalfSale] [bit] NOT NULL,
	[WorkdaySale] [bit] NOT NULL,
	[NotWorkdaySale] [bit] NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_Price] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrintJob](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RefNo] [varchar](32) NOT NULL,
	[Text] [ntext] NOT NULL,
	[IsSuccess] [bit] NOT NULL,
	[SuccessCount] [int] NOT NULL,
	[LastPrintDate] [datetime] NOT NULL,
	[NumberOfCopy] [int] NOT NULL,
	[IpAddress] [varchar](30) NOT NULL,
 CONSTRAINT [PK_PrintJob] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrintLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RefNo] [varchar](32) NOT NULL,
	[Seller] [varchar](128) NOT NULL,
	[PrintDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PrintLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](32) NOT NULL,
	[SKU] [varchar](64) NOT NULL,
	[Title] [nvarchar](128) NOT NULL,
	[ImageData] [image] NULL,
	[Salable] [bit] NOT NULL,
	[UnitName] [nvarchar](32) NOT NULL,
	[PromotionEffect] [bit] NOT NULL,
	[ServiceChargeSupport] [bit] NOT NULL,
	[Remarks] [nvarchar](250) NULL,
	[UseQty] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](32) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[Title] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](256) NULL,
	[Effective] [datetime] NOT NULL,
	[Expire] [datetime] NOT NULL,
	[PercentDC] [decimal](18, 2) NOT NULL,
	[ValueDC] [decimal](18, 2) NOT NULL,
	[MaximumDC] [decimal](18, 2) NOT NULL,
	[MaxUsagePerDay] [int] NOT NULL,
	[HasCondition] [bit] NOT NULL,
	[HasSubSchedule] [bit] NOT NULL,
	[HasAttachItem] [bit] NOT NULL,
	[TargetProductId] [int] NOT NULL,
	[LimitProductQty] [int] NOT NULL,
	[ShowInList] [bit] NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_Promotion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromotionAttachment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PromotionId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[ProductQty] [int] NOT NULL,
	[IsRedeemLater] [bit] NOT NULL,
 CONSTRAINT [PK_PromotionAttachment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromotionCondition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PromotionId] [int] NOT NULL,
	[Condition] [varchar](16) NOT NULL,
	[TargetId] [int] NOT NULL,
	[Qty] [decimal](18, 2) NOT NULL,
	[Remarks] [nvarchar](256) NULL,
 CONSTRAINT [PK_PromotionCondition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromotionSubSchedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PromotionId] [int] NOT NULL,
	[EffectiveDate] [datetime] NOT NULL,
	[ExpireDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PromotionSubSchedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromotionUsage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PromotionId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Invoice] [varchar](64) NOT NULL,
	[TotalDC] [decimal](18, 2) NOT NULL,
	[EffectInvoice] [varchar](64) NULL,
	[IsClose] [bit] NOT NULL,
 CONSTRAINT [PK_PromotionUsage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromotionZone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PromotionId] [int] NOT NULL,
	[ZoneId] [int] NOT NULL,
	[Remarks] [nvarchar](256) NULL,
 CONSTRAINT [PK_PromotionZone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[SerialNumber] [varchar](32) NOT NULL,
	[CustomerCode] [varchar](32) NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Discount] [decimal](18, 2) NOT NULL,
	[Vat] [decimal](18, 2) NOT NULL,
	[VatType] [varchar](32) NOT NULL,
	[VatPercent] [decimal](10, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Payment] [decimal](18, 2) NOT NULL,
	[Change] [decimal](18, 2) NOT NULL,
	[PaymentType] [varchar](20) NOT NULL,
	[CardIssuer] [int] NOT NULL,
	[QueueNumber] [bigint] NOT NULL,
	[ZoneId] [int] NOT NULL,
	[StationName] [varchar](50) NOT NULL,
	[Seller] [varchar](128) NOT NULL,
	[IsVoid] [bit] NOT NULL,
	[VoidAdmin] [varchar](128) NULL,
	[Remarks] [nvarchar](512) NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SerialNumber] [varchar](32) NOT NULL,
	[OrderIndex] [int] NOT NULL,
	[SKU] [varchar](64) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[TotalPrice] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Discount] [decimal](18, 2) NOT NULL,
	[PromotionId] [int] NOT NULL,
	[IsDiscount] [bit] NOT NULL,
	[StockUpdated] [bit] NOT NULL,
	[Remarks] [nvarchar](512) NULL,
 CONSTRAINT [PK_ReceiptDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NOT NULL,
	[AccountId] [int] NOT NULL,
	[Cash] [decimal](18, 2) NOT NULL,
	[Credit] [decimal](18, 2) NOT NULL,
	[Promptpay] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Remarks] [nvarchar](1024) NULL,
 CONSTRAINT [PK_SaleLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[ProductId] [int] NOT NULL,
	[SKU] [varchar](64) NOT NULL,
	[Action] [varchar](32) NOT NULL,
	[Qty] [int] NOT NULL,
	[AdjustQty] [int] NOT NULL,
	[StockKey] [varchar](10) NOT NULL,
	[Remarks] [nvarchar](128) NULL,
 CONSTRAINT [PK_StockLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemInfo](
	[Name] [varchar](64) NOT NULL,
	[Value] [nvarchar](2048) NOT NULL,
 CONSTRAINT [PK_SystemInfo] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workday](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DayNumber] [int] NOT NULL,
	[StartTime] [varchar](5) NOT NULL,
	[EndTime] [varchar](5) NOT NULL,
	[HalfTime] [varchar](5) NOT NULL,
	[IsWeekend] [bit] NOT NULL,
 CONSTRAINT [PK_Workday] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](32) NULL,
	[ColorCode] [varchar](10) NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_Zone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZoneAccount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ZoneId] [int] NOT NULL,
	[AccountId] [int] NOT NULL,
	[Effective] [datetime] NOT NULL,
	[Expire] [datetime] NULL,
	[Inactive] [bit] NOT NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_ZoneAccount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZonePrinter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ZoneId] [int] NOT NULL,
	[PrinterIP] [varchar](20) NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_ZonePrinter] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZoneProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ZoneId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Category] [nvarchar](64) NULL,
	[Qty] [int] NOT NULL,
	[LastQty] [int] NOT NULL,
	[UpdateDate] [datetime] NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_ZoneProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZoneQueue](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ZoneId] [int] NOT NULL,
	[CurrentQueue] [bigint] NOT NULL,
	[Inactive] [bit] NOT NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_ZoneQueue] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 
GO
INSERT [dbo].[Account] ([Id], [Username], [Password], [Firstname], [Lastname], [Effective], [Expire], [AccountType], [Inactive]) VALUES (1, N'admin', N'00000', N'Initial', N'Admin', CAST(N'2020-12-30T00:00:00.000' AS DateTime), CAST(N'2029-01-01T00:00:00.000' AS DateTime), 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[AccountType] ON 
GO
INSERT [dbo].[AccountType] ([Id], [Code], [Title], [AccessPortal], [AccessReport], [AccessClient], [AccessAccountReport], [AccessClientSummary], [CanVoidReceipt], [CanModifyData], [CanModifyStock], [Inactive]) VALUES (1, N'00000001', N'SystemAdmin', 1, 1, 1, 1, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[AccountType] ([Id], [Code], [Title], [AccessPortal], [AccessReport], [AccessClient], [AccessAccountReport], [AccessClientSummary], [CanVoidReceipt], [CanModifyData], [CanModifyStock], [Inactive]) VALUES (2, N'00000002', N'User', 0, 0, 1, 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[AccountType] ([Id], [Code], [Title], [AccessPortal], [AccessReport], [AccessClient], [AccessAccountReport], [AccessClientSummary], [CanVoidReceipt], [CanModifyData], [CanModifyStock], [Inactive]) VALUES (3, N'00000003', N'Supervisor', 0, 1, 1, 0, 0, 1, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[AccountType] OFF
GO
SET IDENTITY_INSERT [dbo].[CreditCardIssuer] ON 
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (1, N'I001', N'BKL', N'Bangkok Bank')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (2, N'I002', N'KBANK', N'Kasikorn Bank')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (3, N'I003', N'SCB', N'ไทยพาณิชย์')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (4, N'I004', N'KRUNSRI', N'กรุงศรี')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (5, N'I005', N'CITI', N'ซิตีแบงค์')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (6, N'I006', N'KTC', N'KTC ในเครือธนาคารกรุงไทย')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (7, N'I007', N'UOB', N'ยูโอบี')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (8, N'I008', N'AEON', N'AEON อิออน')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (9, N'I009', N'TMB', N'TMB ธนาคารทหารไทย')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (10, N'I010', N'STANDARD', N'สแตนดาร์ดชาร์เตอร์ด')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (11, N'I011', N'AMEX', N'บริษัท อเมริกัน เอ็กซ์เพรส จำกัด')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (12, N'I012', N'VISA', N'อื่นๆ Visa')
GO
INSERT [dbo].[CreditCardIssuer] ([Id], [Code], [Title], [Description]) VALUES (13, N'I013', N'MASTER', N'อื่นๆ Master Card')
GO
SET IDENTITY_INSERT [dbo].[CreditCardIssuer] OFF
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'DB_CREATE_DATE', N'30 December 2020')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'DBVERSION', N'1')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'PRINT_COPY', N'2')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'PROMPTPAY_ENABLE', N'False')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'PROMPTPAY_ID', N'')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'QUEUE_ENABLE', N'False')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'RECEIPT_HEADER', N'My company Co.,Ltd. 
123 อาคารทดสอบ ชั้น 4 ห้อง 456
สามเสนนอก ห้วยขวาง
กรุงเทพ 10310
TAXID:0123456789000
POSID:UP_TO_YOU')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'RECEIPT_TAILER', N'
             Thank you             
      Call center (02) 234-5678      ')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'SERVICE_CHARGE', N'5.0')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'SERVICE_CHARGE_ENABLE', N'False')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'SUMMARY_PROTECTION_ENABLE', N'False')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'VAT', N'7.0')
GO
INSERT [dbo].[SystemInfo] ([Name], [Value]) VALUES (N'VAT_TYPE', N'include')
GO
SET IDENTITY_INSERT [dbo].[Zone] ON 
GO
INSERT [dbo].[Zone] ([Id], [Title], [ColorCode], [Inactive]) VALUES (1, N'A', N'#000000', 0)
GO
SET IDENTITY_INSERT [dbo].[Zone] OFF
GO
SET IDENTITY_INSERT [dbo].[ZoneAccount] ON 
GO
INSERT [dbo].[ZoneAccount] ([Id], [ZoneId], [AccountId], [Effective], [Expire], [Inactive], [UpdateDate]) VALUES (1, 1, 1, CAST(N'2020-12-30T00:00:00.000' AS DateTime), CAST(N'2029-01-01T00:00:00.000' AS DateTime), 0, CAST(N'2020-12-01T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ZoneAccount] OFF
GO
SET IDENTITY_INSERT [dbo].[ZoneQueue] ON 
GO
INSERT [dbo].[ZoneQueue] ([Id], [ZoneId], [CurrentQueue], [Inactive], [UpdateDate]) VALUES (1, 1, 0, 0, CAST(N'2020-12-30T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ZoneQueue] OFF
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [AccessPortal]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [AccessReport]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [AccessClient]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [AccessAccountReport]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [AccessClientSummary]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [CanVoidReceipt]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [CanModifyData]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [CanModifyStock]
GO
ALTER TABLE [dbo].[AccountType] ADD  DEFAULT ((0)) FOR [Inactive]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((2)) FOR [Gender]
GO
ALTER TABLE [dbo].[PrintJob] ADD  DEFAULT ((0)) FOR [SuccessCount]
GO
ALTER TABLE [dbo].[Promotion] ADD  DEFAULT ((0)) FOR [HasCondition]
GO
ALTER TABLE [dbo].[Receipt] ADD  DEFAULT ((7.0)) FOR [VatPercent]
GO
ALTER TABLE [dbo].[ReceiptDetail] ADD  DEFAULT ((0)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[ReceiptDetail] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[ReceiptDetail] ADD  DEFAULT ((0)) FOR [PromotionId]
GO
ALTER TABLE [dbo].[ReceiptDetail] ADD  DEFAULT ((0)) FOR [IsDiscount]
GO
ALTER TABLE [dbo].[Zone] ADD  DEFAULT ((0)) FOR [Inactive]
GO
