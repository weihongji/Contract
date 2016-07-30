IF EXISTS(SELECT * FROM sys.procedures WHERE name = 'spLoginUser') BEGIN
	DROP PROCEDURE spLoginUser
END
GO

CREATE PROCEDURE spLoginUser
	@account as varchar(50),
	@password as varchar(50),
	@result as varchar(100) output
AS
BEGIN
	SET NOCOUNT ON;
	SET @result = 'unknown'

	DECLARE @pwd varchar(100)
	SELECT @pwd = Password FROM SystemUser WHERE Account = @account

	IF @@ROWCOUNT = 0 BEGIN
		SET @result = 'account not found'
		RETURN
	END

	IF @pwd = @password BEGIN
		SET @result = 'matched'
	END
	ELSE BEGIN
		SET @result = 'wrong pwd'
	END
END
