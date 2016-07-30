IF EXISTS(SELECT * FROM sys.tables WHERE object_id = OBJECT_ID('Setting')) BEGIN
	DROP TABLE Setting
END

IF EXISTS(SELECT * FROM sys.tables WHERE object_id = OBJECT_ID('FieldValue')) BEGIN
	DROP TABLE FieldValue
END

IF EXISTS(SELECT * FROM sys.tables WHERE object_id = OBJECT_ID('Field')) BEGIN
	DROP TABLE Field
END

IF EXISTS(SELECT * FROM sys.tables WHERE object_id = OBJECT_ID('Contract')) BEGIN
	DROP TABLE [Contract]
END

IF EXISTS(SELECT * FROM sys.tables WHERE object_id = OBJECT_ID('Group')) BEGIN
	DROP TABLE [Group]
END

IF EXISTS(SELECT * FROM sys.tables WHERE object_id = OBJECT_ID('SystemUser')) BEGIN
	DROP TABLE SystemUser
END