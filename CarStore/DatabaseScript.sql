USE [CarStore]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 27.06.2016 11:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 27.06.2016 11:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Plate] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Vehicle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201606270714554_InitialCreate', N'Data.DataContext.CarStoreDataContext', 0x1F8B0800000000000400CD58DB6EDB38107D5FA0FF20F0A90BA4662E2FBB81D422719245B0CD05559A775A1ADB4429524B5281FD6D7DD84FDA5FD8A1445D6DC776DD164580C01ACD9CB9710EC7FEEFEBBFE18745268217D0862B199193D1310940262AE5721691C24EDFFD413EBC7FF35B789D668BE0B9D63B737A68294D44E6D6E6E7949A640E1933A38C275A1935B5A3446594A58A9E1E1FFF494F4E28200441AC20083F15D2F20CCA077C1C2B99406E0B26EE540AC27839BE894BD4E09E656072964044AE986523F70F8D2C2C2C092E046718470C624A0226A5B2CC6294E79F0DC4562B398B731430F1B4CC01F5A64C18F0D19FB7EABB26727CEA12A1AD610D9514C6AA6C4FC093335F193A34FFA6FA92A67258BB6BACB15DBAACCBFA45E419E63C1198FBD0D7F95868A7E7AB5B3661E4B58F02273B6A7A8F47C4FD1D05E342D8424324A1B09A89A3E0B198089EFC0DCB27F50564240B21BAF16044F8AE2740D1A3563968BBFC04531FE56D4A02DAB7A343C3C6AC635325702BEDD92909EED1399B0868DADD4936B64AC35F2041330BE923B316B4741850166CC5FBC0D7A566B27187070C278504776CF111E4CCCE23821F4970C31790D6121FC267C971B0D0C8EA02B679297BF0C3BD3C0A2CC10FF7E2E0B7F5E77584185B57981AE35229014C6E4109693B00AB63E1D883713C03DEC398E9F25CF49865654E9052FCA8189F7A3FEC0A3B063B9CB836948AA846CD9B752137C1B544482B26AC19936EA0CCF08EE53976B143A15E12C4157F8EDFC5FB534B5661D0C4AC619826DAC6131692CD60F0165D63A4375C1BEB8A3C61AE61E3345B555BD38A0D65AE3DF6AB3DE498B6F8B5BEFB5CD90CAF93D10690B69037985B865451A6094D281BDD97B671C204D36B586BAC4491C94DCCF79AB5E7A12E8017ED8EE159A68BE145BB63780EE96278D1EE18154374212AC9EE08354374316AD92A4A4807CD1C1E19BA72660637D2F008BE36C54395C67B33CD83A90DFD046DDF865646AA52210196E785A76E9CE2A5B19095677C14FF23C68263BEADC21D937C0AC6569736C195E474B052FD3AEB0D352615BBED383F7DF1E0AEA85B578B3DEFBDDEAE215F984EE64CBFCDD8E2F72ED4DEFBC44148BD9DE120A4EE5E5096EFA0AD60C2B721ECB911ACDC5607DFF5D57046249D288CBA8AF3D04560952A42DAFD7A155E81E1B316C27DD99290B8196C416B9D5B3955759131B36E44B5CAF05C81652916E8425B3E6589C5D70918532E92CF4C14A8729D4D20BD950F85CD0B7B610C6413D1DBB243FABAFF72DBE9C71C3EE4EEC97C8F14304C8E29C083BC2CB8489BB86FD69CA00D10EEACF8B1C7A8709146B8D9B241BA577247205FBE2BC8413AD278822C77F3661E64CC5EE05B62C39DF523CC58B2AC197F33C8F646F4CB1E5E7136D32C331EA3B5773F1950F79BC1FBFF017847BF4465100000, N'6.1.3-40302')
