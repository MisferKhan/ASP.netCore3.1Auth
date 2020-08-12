CREATE TABLE [dbo].[Person] (
    [PersonId]        INT            IDENTITY (1, 1) NOT NULL,
    [PersonName]      NVARCHAR (200) NOT NULL,
    [PersonTelephone] NVARCHAR (50)  NOT NULL,
    [PersonAddress]   NVARCHAR (500) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC)
);

