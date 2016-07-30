--USE [YLContract]
--GO

SET NOCOUNT OFF

IF NOT EXISTS(SELECT * FROM Setting) BEGIN
	INSERT INTO Setting (UserMaxLock)
	VALUES (10)
END

IF NOT EXISTS(SELECT * FROM SystemUser) BEGIN
	INSERT INTO SystemUser (Name, Account, Password, Role) VALUES (N'管理员', 'admin', '21232f297a57a5a743894a0e4a801fc3', 2)
	INSERT INTO SystemUser (Name, Account, Password, Role) VALUES (N'测试帐号', 'test', '098f6bcd4621d373cade4e832627b4f6', 1)
END

IF NOT EXISTS(SELECT * FROM [Group]) BEGIN
	INSERT INTO [Group](Id, Name) VALUES (1, N'全部合同')
END

IF NOT EXISTS(SELECT * FROM [Contract]) BEGIN
	INSERT INTO [Contract](Id, Name, GroupId, Sort) VALUES (1, N'合同 1', 1, 'A')
	INSERT INTO [Contract](Id, Name, GroupId, Sort) VALUES (2, N'合同 2', 1, 'B')
	INSERT INTO [Contract](Id, Name, GroupId, Sort) VALUES (3, N'合同 1.1', 1, 'A')
END

IF NOT EXISTS(SELECT * FROM [Field]) BEGIN
	INSERT INTO Field (ContractId, Token, Name, X, Y, Width, Height) VALUES (1, '%%field01%%', '每月x日前', 115, 16, 34, 14)
	INSERT INTO Field (ContractId, Token, Name, X, Y, Width, Height) VALUES (1, '%%field02%%', '月工资金额', 357, 16, 24, 14)
	INSERT INTO Field (ContractId, Token, Name, X, Y, Width, Height) VALUES (1, '%%field03%%', '或按x执行', 20, 40, 62, 14)
END

IF NOT EXISTS(SELECT * FROM [FieldValue]) BEGIN
	INSERT INTO FieldValue (SystemUserId, FieldId, Value) VALUES (1, 1, '31')
	INSERT INTO FieldValue (SystemUserId, FieldId, Value) VALUES (1, 2, '3420.00')
	INSERT INTO FieldValue (SystemUserId, FieldId, Value) VALUES (1, 3, '双方协商')
END
