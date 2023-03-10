
--DROP TABLE UT_Town
--DROP TABLE UT_Country
--DROP TABLE UT_City
--DROP TABLE SH_User

CREATE TABLE UT_Country (
	Id UNIQUEIDENTIFIER DEFAULT NEWSEQUENTIALID(),
	Created DATETIME NULL DEFAULT GETDATE(),
	Changed DATETIME NULL,
	CreatedId UNIQUEIDENTIFIER NULL,
	ChangedId UNIQUEIDENTIFIER NULL,
	Name NVARCHAR(100),
	Shape GEOMETRY NULL

	CONSTRAINT [PK_UT_Country] PRIMARY KEY CLUSTERED ([Id] ASC) WITH 
	(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]





CREATE TABLE UT_City (
	Id UNIQUEIDENTIFIER DEFAULT NEWSEQUENTIALID(),
	Created DATETIME NULL DEFAULT GETDATE(),
	Changed DATETIME NULL,
	CreatedId UNIQUEIDENTIFIER NULL,
	ChangedId UNIQUEIDENTIFIER NULL,
	Name NVARCHAR(100),
	Shape GEOMETRY NULL,
	PlateNumber NVARCHAR(2) NOT NULL
	
	CONSTRAINT [PK_UT_City] PRIMARY KEY CLUSTERED ([Id] ASC) WITH 
	(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE UT_Town (
	Id UNIQUEIDENTIFIER DEFAULT NEWSEQUENTIALID(),
	Created DATETIME NULL DEFAULT GETDATE(),
	Changed DATETIME NULL,
	CreatedId UNIQUEIDENTIFIER NULL,
	ChangedId UNIQUEIDENTIFIER NULL,
	Name NVARCHAR(100),
	Shape GEOMETRY NULL,
	CityId UNIQUEIDENTIFIER NOT NULL
		
	CONSTRAINT [PK_UT_Town] PRIMARY KEY CLUSTERED ([Id] ASC) WITH 
	(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE SH_User (
	Id UNIQUEIDENTIFIER DEFAULT NEWSEQUENTIALID(),
	Created DATETIME NULL DEFAULT GETDATE(),
	Changed DATETIME NULL,
	CreatedId UNIQUEIDENTIFIER NULL,
	ChangedId UNIQUEIDENTIFIER NULL,
	
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Email NVARCHAR(250) NOT NULL,
	BirthDate DATETIME NOT NULL,
	CellPhone NVARCHAR(10) NOT NULL,
	IdentityNumber NVARCHAR(11) NOT NULL,
	Password NVARCHAR(250) NOT NULL,
	TownId UNIQUEIDENTIFIER NOT NULL,
	CityId UNIQUEIDENTIFIER NOT NULL,
	IsBlocked BIT NULL
		
	CONSTRAINT [PK_SH_User] PRIMARY KEY CLUSTERED ([Id] ASC) WITH 
	(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]







--------	FOREIGN KEYS



ALTER TABLE UT_Town ADD CONSTRAINT FK___UT_Town_CityId___UT_City_Id FOREIGN KEY (CityId)
REFERENCES UT_City(Id) ON DELETE NO ACTION ON UPDATE NO ACTION

ALTER TABLE SH_User ADD CONSTRAINT FK___SH_User_TownId___UT_Town_Id FOREIGN KEY (TownId)
REFERENCES UT_Town(Id) ON DELETE NO ACTION ON UPDATE NO ACTION

ALTER TABLE SH_User ADD CONSTRAINT FK___SH_User_CityId___UT_City_Id FOREIGN KEY (CityId)
REFERENCES UT_City(Id) ON DELETE NO ACTION ON UPDATE NO ACTION

