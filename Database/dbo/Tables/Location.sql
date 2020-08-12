CREATE TABLE [dbo].[Location] (
    [LocationId]      INT            IDENTITY (1, 1) NOT NULL,
    [LocationName]    NVARCHAR (500) NOT NULL,
    [LocationAddress] NVARCHAR (500) NOT NULL,
    [LocationOwner]   INT            NOT NULL,
    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([LocationId] ASC),
    CONSTRAINT [FK_Location_Person] FOREIGN KEY ([LocationOwner]) REFERENCES [dbo].[Person] ([PersonId])
);

