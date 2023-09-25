SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE CreatePhoneBookTable
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Creates table if it doesn't exist
	IF OBJECT_ID(N'dbo.PhoneBook', N'U') IS NULL
	CREATE TABLE PhoneBook (
		ID int IDENTITY PRIMARY KEY,
		FullName varchar(255),
		PhoneNo varchar(50),
		BirthDate DATE
	)
END
GO
