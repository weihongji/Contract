select * from [Group]
select * from [Contract]
select * from field
select * from fieldvalue
select * from systemuser

insert into [Group](Name) values ('һ���ͬ')
insert into Contract(Name, GroupId) values ('��ͬһ��', 1)
insert into field (contractid, name, token, typeid) values (2, '�ͻ�����', '%customername%', 1)
insert into field (contractid, name, token, typeid) values (2, '������', '%loanamount%', 1)

insert into systemuser(Name, account, [password]) values ('������', 'jacklee', '12346')
insert into fieldvalue(fieldid, systemuserId, value) values (3, 1, 'Jesse')


SELECT *
FROM [Group] G
	INNER JOIN [Contract] C ON C.GroupId = G.Id
	INNER JOIN Field F ON F.ContractId = C.Id
	LEFT JOIN FieldValue V ON V.FieldId = F.Id
	LEFT JOIN SystemUser U ON U.Id = V.SystemUserId