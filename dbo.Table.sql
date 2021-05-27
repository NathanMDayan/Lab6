CREATE TABLE [dbo].[PersonV2] (
    [EBook_ID]          BIGINT        NOT NULL,
    [Title]             NVARCHAR (50) NULL,
    [AuthorsFirstName]  NVARCHAR (50) NULL,
    [AuthorsLastName]   NVARCHAR (50) NULL,
    [AuthorsEmail]      NVARCHAR (75) NULL,
    [Pages]             INT           NULL,
    [DatePublished]     DATETIME      NULL,
    [DateRentalExpires] DATETIME      NULL,
    [BookMark]          INT           NULL,
    [Price]             FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([EBook_ID] ASC)
);

