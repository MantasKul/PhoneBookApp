SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertRow
	@FullName varchar(255),
	@PhoneNo varchar(50),
	@BirthDate DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO PhoneBook (FullName, PhoneNo, BirthDate) 
	VALUES 
		(@FullName, @PhoneNo, @BirthDate)
END
GO
