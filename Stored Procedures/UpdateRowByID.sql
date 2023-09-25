SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateRowByID 
	@ID int,
	@FullName varchar(50),
	@PhoneNo varchar(15),
	@BirthDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE PhoneBook
	SET FullName=@FullName, PhoneNo=@PhoneNo, BirthDate=@BirthDate
	WHERE ID=@ID
END
GO
