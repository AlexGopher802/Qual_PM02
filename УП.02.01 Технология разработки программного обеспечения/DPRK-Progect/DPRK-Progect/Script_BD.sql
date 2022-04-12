set ansi_nulls on
go
set quoted_identifier on
go
set ansi_padding on
go

create database [DP_Repair_Kit]
go

use [DP_Repair_Kit]
go

create table [dbo].[Role]
(
	[ID_Role] [int] not null identity(1,1),
	[Name] [varchar] (50) not null UNIQUE,

	constraint [PK_Role] primary key clustered 
		([ID_Role] ASC) on [PRIMARY]
) 
go

create table [dbo].[Dolznost]
(
	[ID_Dolznosti] [int] not null identity(1,1),
	[Name] [varchar] (50) not null UNIQUE,

	constraint [PK_Dolznost] primary key clustered 
		([ID_Dolznosti] ASC) on [PRIMARY]
) 
go

create table [dbo].[Sotrudnic]
(
	[ID_Sotrudnica] [int] not null identity(1,1),
	[Familiya] [varchar] (50) not null,
	[ID_Dolznosti] [int] not null,
	[Ima] [varchar] (50) not null,
	[Otchestvo] [varchar] (50) null,
	[Nomer_Telefona] [varchar] (50) null,
	[Login] [varchar] (50) not null,
	[Password] [varchar] (50) not null,
	[ID_Role][int] not null
	

	constraint [PK_Sotrudnic] primary key clustered 
		([ID_Sotrudnica] ASC) on [PRIMARY],

	constraint [FK_Dolznosti_Sotrudnic] foreign key ([ID_Dolznosti])
	references [dbo].[Dolznost] (ID_Dolznosti) ON DELETE CASCADE,

	constraint [FK_Role_Sotrudnic] foreign key ([ID_Role])
	references [dbo].[Role] (ID_Role) ON DELETE CASCADE
) 
go

create table [dbo].[Brigadir]
(
	[ID_Brigadira] [int] not null identity(1,1),
	[ID_Sotrudnica] [int] not null,

	constraint [PK_Brigadir] primary key clustered 
		([ID_Brigadira] ASC) on [PRIMARY],

	constraint [FK_Sotrudnic_Brigadir] foreign key ([ID_Sotrudnica])
	references [dbo].[Sotrudnic] (ID_Sotrudnica) ON DELETE CASCADE

)
go

create table [dbo].[Sostav_Brigadi]
(
	[ID_Sostav_Brigadi] [int] not null identity(1,1),
	[ID_Brigadira] [int] not null,
	[ID_Sotrudnica] [int] not null
	

	constraint [PK_Sostav_Brigadi] primary key clustered 
		([ID_Sostav_Brigadi] ASC) on [PRIMARY],

	constraint [FK_Brigadira_Sostav_Brigadi] foreign key ([ID_Brigadira])
	references [dbo].[Brigadir] (ID_Brigadira) ON DELETE CASCADE,

	constraint [FK_Sotrudnic_Sostav_Brigadi] foreign key ([ID_Sotrudnica])
	references [dbo].[Sotrudnic] (ID_Sotrudnica)  ON UPDATE NO ACTION
) 
go

create table [dbo].[Vid_Rabot]
(
	[ID_Vida] [int] not null identity(1,1),
	[Name] [varchar] (100) not null UNIQUE,

	constraint [PK_Vid_Rabot] primary key clustered 
		([ID_Vida] ASC) on [PRIMARY]
)
go

create table [dbo].[Rabota_Brigadi]
(
	[ID_Raboti] [int] not null identity(1,1),
	[ID_Brigadira] [int] not null,
	[ID_Vida] [int] not null

	constraint [PK_Rabota_Brigati] primary key clustered 
		([ID_Raboti] ASC) on [PRIMARY],

	constraint [FK_Brigadira_Rabota_Brigati] foreign key ([ID_Brigadira])
	references [dbo].[Brigadir] (ID_Brigadira) ON DELETE CASCADE,

	constraint [FK_Vida_Rabota_Brigati] foreign key ([ID_Vida])
	references [dbo].[Vid_Rabot] (ID_Vida) ON DELETE CASCADE
)
go

create table [dbo].[Stroitelnaya_Tekhnica]
(
	[ID_Teknici] [int] not null identity(1,1),
	[Name] [varchar] (100) not null UNIQUE,

	constraint [PK_Stroitelnaya_Tekhnica] primary key clustered 
		([ID_Teknici] ASC) on [PRIMARY]
)
go

create table [dbo].[Uchastok]
(
	[ID_Uchastka] [int] not null identity(1,1),
	[ID_Sotrudnica] [int] not null,
	[Name] [varchar] (100) not null UNIQUE,

	constraint [PK_Uchastok] primary key clustered 
		([ID_Uchastka] ASC) on [PRIMARY],

	constraint [FK_Sotrudnic_Uchastok] foreign key ([ID_Sotrudnica])
	references [dbo].[Sotrudnic] (ID_Sotrudnica) ON DELETE CASCADE
)
go

create table [dbo].[Tekhnica_Na_Uchastke]
(
	[ID_Tekhnica_Na_Uchastke] [int] not null identity(1,1),
	[Kolichestvo] [int] not null,
	[ID_Uchastka] [int] not null,
	[ID_Teknici] [int] not null,

	constraint [PK_Tekhnica_Na_Uchastke] primary key clustered 
		([ID_Tekhnica_Na_Uchastke] ASC) on [PRIMARY],

	constraint [FK_Uchastka_Tekhnica_Na_Uchastke] foreign key ([ID_Uchastka])
	references [dbo].[Uchastok] (ID_Uchastka) ON DELETE CASCADE,

	constraint [FK_Teknici_Tekhnica_Na_Uchastke] foreign key ([ID_Teknici])
	references [dbo].[Stroitelnaya_Tekhnica] (ID_Teknici) ON DELETE CASCADE
)
go

create table [dbo].[Tip_Obyekta]
(
	[ID_Tipa_Obyekta] [int] not null identity(1,1),
	[Name] [varchar] (100) not null UNIQUE,

	constraint [PK_Tip_Obyekta] primary key clustered 
		([ID_Tipa_Obyekta] ASC) on [PRIMARY]
)
go

create table [dbo].[Stroitelniy_Object]
(
	[ID_Objecta] [int] not null identity(1,1),
	[ID_Tipa_Obyekta] [int] not null,
	[ID_Uchastka] [int] not null,
	[Status] [varchar] (50) not null,

	constraint [PK_Stroitelniy_Object] primary key clustered 
		([ID_Objecta] ASC) on [PRIMARY],

	constraint [FK_Tipa_Obyekta_Stroitelniy_Object] foreign key ([ID_Tipa_Obyekta])
	references [dbo].[Tip_Obyekta] (ID_Tipa_Obyekta) ON DELETE CASCADE,

	constraint [FK_Uchastka_Stroitelniy_Object] foreign key ([ID_Uchastka])
	references [dbo].[Uchastok] (ID_Uchastka) ON DELETE CASCADE
)
go

create table [dbo].[Zakazchik]
(
	[ID_Zakazchika] [int] not null identity(1,1),
	[Name] [varchar] (100) not null ,
	[INN_Number] [varchar] (20) not null UNIQUE,
	[Phone_Number] [varchar] (20) not null,


	constraint [PK_Zakazchik] primary key clustered 
		([ID_Zakazchika] ASC) on [PRIMARY]
)
go

create table [dbo].[Dogovor]
(
	[ID_Dogovora] [int] not null identity(1,1),
	[Data_Zacluchenia_Dogovora] [varchar] (100) not null,
	[ID_Objecta] [int] not null,
	[ID_Zakazchika] [int] not null


	constraint [PK_Dogovor] primary key clustered 
		([ID_Dogovora] ASC) on [PRIMARY],

	constraint [FK_Stroitelniy_Object_Dogovor] foreign key ([ID_Objecta])
	references [dbo].[Stroitelniy_Object] (ID_Objecta) ON DELETE CASCADE,

	constraint [FK_Zakazchik_Dogovor] foreign key ([ID_Zakazchika])
	references [dbo].[Zakazchik] (ID_Zakazchika) ON DELETE CASCADE
)
go

create table [dbo].[Raboti_Na_Obiecte]
(
	[ID_Raboti_Na_Obiecte] [int] not null identity(1,1),
	[ID_Objecta] [int] not null,
	[ID_Raboti] [int] not null,
	[Status] [varchar] (100) not null,
	[Srok_Vipolnenia_Rabot] [date] not null,
	[Prioritet] [int] not null


	constraint [PK_Raboti_Na_Obiecte] primary key clustered 
		([ID_Raboti_Na_Obiecte] ASC) on [PRIMARY],

	
	constraint [FK_Rabota_Brigadi_Raboti_Na_Obiecte] foreign key ([ID_Raboti])
	references [dbo].[Rabota_Brigadi] (ID_Raboti) ON DELETE CASCADE,

	constraint [FK_Stroitelniy_Object_Raboti_Na_Obiecte] foreign key ([ID_Objecta])
	references [dbo].[Stroitelniy_Object] (ID_Objecta) 
)
go

create table [dbo].[Sdacha_Rabot]
(
	[ID_Sdachi_Rabot] [int] not null identity(1,1),
	[Data_Sdachi] [date] not null,
	[ID_Raboti_Na_Obiecte] [int] not null UNIQUE,


	constraint [PK_Sdacha_Rabot] primary key clustered 
		([ID_Sdachi_Rabot] ASC) on [PRIMARY],

	constraint [FK_Raboti_Na_Obiecte_Sdacha_Rabot] foreign key ([ID_Raboti_Na_Obiecte])
	references [dbo].[Raboti_Na_Obiecte] (ID_Raboti_Na_Obiecte) ON DELETE CASCADE,
)
go

create table [dbo].[Material]
(
	[ID_Materiala] [int] not null identity(1,1),
	[Name] [varchar] (100) not null UNIQUE,

	constraint [PK_Material] primary key clustered 
		([ID_Materiala] ASC) on [PRIMARY]
)
go

create table [dbo].[Rashod_Materialov]
(
	[ID_Rashoda_Materialov] [int] not null identity(1,1),
	[Kolichestvo] [int] not null,
	[ID_Materiala] [int] not null,
	[ID_Sdachi_Rabot] [int] not null

	constraint [PK_Rashod_Materialo] primary key clustered 
		([ID_Rashoda_Materialov] ASC) on [PRIMARY],

	constraint [FK_Materiala_Rashod_Materialov] foreign key ([ID_Materiala])
	references [dbo].[Material] (ID_Materiala) ON DELETE CASCADE,

	constraint [FK_Sdachi_Rabot_Rashod_Materialov] foreign key ([ID_Sdachi_Rabot])
	references [dbo].[Sdacha_Rabot] (ID_Sdachi_Rabot) ON DELETE CASCADE
)
go

create table [dbo].[Unicalnie_Atributi]
(
	[ID_Atributa] [int] not null identity(1,1),
	[Name] [varchar] (100) not null UNIQUE,

	constraint [PK_Unicalnie_Atributi] primary key clustered 
		([ID_Atributa] ASC) on [PRIMARY]
)
go

create table [dbo].[Perechen_Atributuv]
(
	[ID_Perechena_Atributuv] [int] not null identity(1,1),
	[ID_Objecta] [int] not null,
	[ID_Atributa] [int] not null,
	[Value] [varchar] (100) not null,

	constraint [PK_Perechen_Atributuv] primary key clustered 
		([ID_Perechena_Atributuv] ASC) on [PRIMARY],

	constraint [FK_Stroitelniy_Object_Perechen_Atributuv] foreign key ([ID_Objecta])
	references [dbo].[Stroitelniy_Object] (ID_Objecta) ON DELETE CASCADE,

	constraint [FK_Unicalnie_Atributi_Perechen_Atributuv] foreign key ([ID_Atributa])
	references [dbo].[Unicalnie_Atributi] (ID_Atributa) ON DELETE CASCADE
)
go


INSERT INTO [dbo].[Dolznost]
VALUES
('������������� �������������� �������'),
('����� ������������� ����������'),
('��������� �������'),
('��������'),
('�������� �� ������ � ���������'),
('HR ��������'),
('������'),
('������'),
('�������'),
('���������')
go

INSERT INTO [dbo].[Role]
VALUES
('���������-�����������'),
('�������')
go

INSERT INTO [dbo].[Sotrudnic]
VALUES
('������',1,'������','����������','','AdminGercMV','admin2002',1),
('������',2,'����','��������','','GlavStroi','GlavSt21',2),
('�������',3,'����','����������','','NachYch','nachYchastocIvan',2),
('��������',4,'������','��������','','BrigadiresKMI','KylibMacsIvan',2),
('�����',4,'������','���������','','UrgenBrig','Urgen1997',2),
('������',4,'����','��������','','MencovIvan4','MencIvanov',2),
('�����',4,'������','���������','','MenkavMaks','MenkavMaks4Urg',2),
('�������',5,'�������','����������','','MenagerGaricMixail','GaricMixDmit',1),
('�������',6,'������','����������','','HRManagerAmenc','AmencovMaksimMaks',1),
('�������',7,'������','����������','','MasterBolot','MasterBolot288',2),
('�������',8,'������','����������','','TexnicPescov','TexnicPescov222',2),
('�������',9,'�����','���������','','SlesChue','SlecAntonAmenc',2),
('�������',10,'�����','����������','','SlesChue','SlecAntonAmenc',2),
('�������',3,'�����','�������','','UmixAnton','UmixAnton22',2),
('��������',3,'�������','��������','','Raevscix','Raevscix222',2)

INSERT INTO [dbo].[Brigadir]
VALUES
(4),(5),(6),(7)
go

INSERT INTO [dbo].[Sostav_Brigadi]
VALUES
(1,10),(2,11),
(3,12),(4,13)
go

INSERT INTO [dbo].[Vid_Rabot]
VALUES
('�������'),
('���������'),
('����������'),
('��������'),
('������������'),
('����������'),
('�������������'),
('��������'),
('���������'),
('����������'),
('����������������'),
('��������'),
('��������')
go

INSERT INTO [dbo].[Rabota_Brigadi]
VALUES
(1,1),(1,2),
(2,3),(3,4),
(3,6),(4,7)
go

INSERT INTO [dbo].[Uchastok]
VALUES
(3,'����� ������'),
(14,'23-33-76'),
(15, '���������-23')
go

INSERT INTO [dbo].[Stroitelnaya_Tekhnica]
VALUES
('����'),
('���������'),
('��������'),
('���'),
('���������'),
('��������'),
('���������'),
('�������������� �����'),
('���������'),
('���������'),
('�������������')
go

INSERT INTO [dbo].[Tekhnica_Na_Uchastke]
VALUES
(123,1,1),
(12,1,2),
(13,1,3),
(20,2,4),
(10,3,5)
go

INSERT INTO [dbo].[Tip_Obyekta]
VALUES
('����'),
('�����'),
('������ �����'),
('����� ���'),
('������ �����'),
('�����'),
('�������� �����'),
('����� �������')
go

INSERT INTO [dbo].[Stroitelniy_Object]
VALUES
(1,2,'�����������'),
(2,1,'�����������'),
(3,3,'�����������'),
(5,3,'�����������'),
(7,2,'�����������')
go


INSERT INTO [dbo].[Unicalnie_Atributi]
VALUES
('���������'),
('������� ���������'),
('��������'),
('����������� �������'),
('����������� ���������'),
('������'),
('���������� ������� �� ���������'),
('����������� ���������� ������ � �����')
go

INSERT INTO [dbo].[Perechen_Atributuv]
VALUES
(1,1,12),
(1,2,17),
(1,3,22),
(2,4,12),
(2,5,2),
(3,6,1)
go

INSERT INTO [dbo].[Zakazchik]
VALUES
('���.��������',1111111111,'79855438098'),
('���� ����� 12344',1111211111,'79855138098'),
('��.�������',1111121111,'79855638098'),
('��� ���� ������.�.�',1121111111,'79855431098'),
('��.�������',1111111114,'79855438098'),
('���.���� � ������',1111411111,'79855438098')
go

INSERT INTO [dbo].[Dogovor]
VALUES
('20.09.2002',1,2),
('20.09.2002',2,3),
('20.09.2002',3,2)
go


INSERT INTO [dbo].[Material]
VALUES
('���'),
('�����'),
('���'),
('�����'),
('�����'),
('�����'),
('��������'),
('�����'),
('������'),
('������')
go


INSERT INTO [dbo].[Raboti_Na_Obiecte]
VALUES
(1,1,'������ ���������','20.05.2002',0),
(1,2,'������ �����������','21.01.2002',1),
(1,3,'������ ���������','22.02.2012',2),
(1,2,'������ �����������','23.03.2009',3),
(2,5,'������ ���������','10.08.2009',4),
(2,6,'������ �����������','09.10.2019',1),
(2,2,'������ �����������','02.03.2009',0),
(2,3,'������ �����������','07.03.2009',1)
go

INSERT INTO [dbo].[Sdacha_Rabot]
VALUES
('21.05.2002',1),
('21.12.2001',5),
('21.12.2001',3)
go

INSERT INTO [dbo].[Rashod_Materialov]
VALUES
(2,2,1),
(7,3,1),
(8,1,1),
(12,5,2),
(66,6,2),
(14,10,3),
(12,8,3),
(27,7,3)
go


--��������� ������� ���
create or alter view [dbo].[Chief_Brigades] ("��� ���������� ���������")
as
select
[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1)+'.'+SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.  '+
[dbo].[Dolznost].[Name]
	from [dbo].[Sotrudnic]
	inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] = [dbo].[Dolznost].[ID_Dolznosti]
	where [dbo].[Dolznost].[Name] = '��������'
go

--����� �������
create or alter view [dbo].[Employee_Raboch_Inform] ("��� ��������� ����������")
as
select
[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1) + '.' + SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.  '+
[dbo].[Dolznost].[Name]
	from [dbo].[Sotrudnic]
	inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] = [dbo].[Dolznost].[ID_Dolznosti]
	inner join [dbo].[Role] on [dbo].[Sotrudnic].[ID_Role] = [dbo].[Role].[ID_Role]
	where 
	[dbo].[Role].[Name] = '�������' and 
	[dbo].[Dolznost].[Name] != 'HR ��������' and 
	[dbo].[Dolznost].[Name] != '������������� �������������� �������'and 
	[dbo].[Dolznost].[Name] != '����� ������������� ����������' and 
	[dbo].[Dolznost].[Name] != '��������� �������' and
	[dbo].[Dolznost].[Name] != '��������' and
	[dbo].[Dolznost].[Name] != '�������� �� ������ � ���������' 
go

--����� ������� � ��������� � �������� �� ������ id ���������
create or alter function [dbo].[Output_Workers] (@idBrigadir [int])
returns table
as
	return(
		select
		[dbo].[Sotrudnic].[Familiya] "�������",
		[dbo].[Sotrudnic].[Ima] "���",
		[dbo].[Dolznost].[Name] as "���������"
		from [dbo].[Sostav_Brigadi]
		inner join [dbo].[Sotrudnic] on [dbo].[Sostav_Brigadi].[ID_Sotrudnica] = [dbo].[Sotrudnic].[ID_Sotrudnica]
		inner join [dbo].[Brigadir] on [dbo].[Sostav_Brigadi].[ID_Brigadira] = [dbo].[Brigadir].[ID_Brigadira]
		inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] = [dbo].[Dolznost].[ID_Dolznosti]
		where [dbo].[Brigadir].[ID_Brigadira] = @idBrigadir
	)
go


--����� ��������� �� ��� ��������������
create or alter function [dbo].[Brigadir_Search] (@employee [varchar] (max))
returns table
as
	return(
		select
		[dbo].[Brigadir].[ID_Brigadira] as "����� ���������",
		[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1) + '.' + SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.  '+
		[dbo].[Dolznost].[Name] as "��� ���������"
		from [dbo].[Brigadir]
		inner join [dbo].[Sotrudnic] on [dbo].[Brigadir].[ID_Sotrudnica] = [dbo].[Sotrudnic].[ID_Sotrudnica]
		inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] = [dbo].[Dolznost].[ID_Dolznosti]

		where [dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1) + '.' + SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.  '+
		[dbo].[Dolznost].[Name] = @employee
	)
go

--����� ������ ����������
create or alter function [dbo].[Employee_Search] (@employee [varchar] (max))
returns table
as
	return(
		select
		[dbo].[Sotrudnic].[ID_Sotrudnica] as ����������,
		[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1) + '.' + SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.  '+
		[dbo].[Dolznost].[Name] as "��� ���������"
		from [dbo].[Sotrudnic]
		inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] = [dbo].[Dolznost].[ID_Dolznosti]

		where [dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1) + '.' + SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.  '+
		[dbo].[Dolznost].[Name] = @employee
	)
go

--������ ����� 
create or alter function [dbo].[List_Worke] (@idBrigadir [int])
returns table
as
	return(
		select
		[dbo].[Raboti_Na_Obiecte].[ID_Raboti_Na_Obiecte] as "����� ������ �� �������",
		[dbo].[Vid_Rabot].[Name] as "��� ������",
		[dbo].[Raboti_Na_Obiecte].[Srok_Vipolnenia_Rabot] as "���� ����������",
		[dbo].[Raboti_Na_Obiecte].[Prioritet] as "���������",
		[dbo].[Raboti_Na_Obiecte].[Status] as "������"
		from [dbo].[Raboti_Na_Obiecte]
		inner join [dbo].[Rabota_Brigadi] on [dbo].[Raboti_Na_Obiecte].[ID_Raboti] = [dbo].[Rabota_Brigadi].[ID_Raboti]
		inner join [dbo].[Vid_Rabot] on [dbo].[Rabota_Brigadi].[ID_Vida] = [dbo].[Vid_Rabot].[ID_Vida]
		inner join [dbo].[Brigadir] on [dbo].[Rabota_Brigadi].[ID_Brigadira] = [dbo].[Brigadir].[ID_Brigadira]
		where [dbo].[Rabota_Brigadi].[ID_Brigadira] = @idBrigadir and [dbo].[Raboti_Na_Obiecte].[Status] != '������ ���������'
	)
go

--�����������
create or alter function [dbo].[Autarization] (@login [varchar] (max),@password [varchar] (max))--�������� ������� ��� ������ �������, ���, �������� �����������, ���� ������ ����, ����� ������� �� ��������� ��� �������� (��������� �������)
returns table
as
	return(
		select
		[dbo].[Sotrudnic].[Login],
		[dbo].[Sotrudnic].[Password],
		[dbo].[Dolznost].[Name],
		[dbo].[Sotrudnic].[ID_Sotrudnica]
		from [dbo].[Sotrudnic] 
		inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] =[dbo].[Dolznost].[ID_Dolznosti] 
		where [Login] = @login and [Password] = @password
	)
go

--���������� �� ��������
create or alter view [dbo].[Information_About_Land_Plots] ("��� ����������","�������")
as
select
[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1)+'.'+SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.',
[dbo].[Uchastok].[Name]
	from [dbo].[Uchastok]
	inner join [dbo].[Sotrudnic] on [dbo].[Uchastok].[ID_Sotrudnica] = [dbo].[Sotrudnic].[ID_Sotrudnica]
go

--���������� �� ������� �� �������
create or alter view [dbo].[Equipment_On_The_Site] ("������������","��������")
as
select
[dbo].[Stroitelnaya_Tekhnica].[Name],
[dbo].[Tekhnica_Na_Uchastke].[Kolichestvo]
	from [dbo].[Tekhnica_Na_Uchastke]
	inner join [dbo].[Stroitelnaya_Tekhnica] on [dbo].[Tekhnica_Na_Uchastke].[ID_Teknici] = [dbo].[Stroitelnaya_Tekhnica].[ID_Teknici]
go

--��� ���������� �������
create or alter view [dbo].[Full_Name_Chief] ("�����","���")
as
select
[dbo].[Sotrudnic].[ID_Sotrudnica],
[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1)+'.'+SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.'
	from [dbo].[Sotrudnic]
	inner join [dbo].[Role] on [dbo].[Sotrudnic].[ID_Role] = [dbo].[Role].[ID_Role]
	inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] = [dbo].[Dolznost].[ID_Dolznosti]
	where [dbo].[Dolznost].[Name] = '��������� �������'
	--where [dbo].[Role].[Name] = '���������-�����������'
go



---������� ������������� � ���������� �������
create or alter function [dbo].[Information_Object_Uchastci_ComboBox] (@idEmployye [int])
returns table
as
	return(
	select 
			[dbo].[Tip_Obyekta].[Name] + ','+ [dbo].[Dogovor].[Data_Zacluchenia_Dogovora] as "��� ����",
			[dbo].[Stroitelniy_Object].[ID_Objecta] as "����� �������"
			from [dbo].[Dogovor]
			inner join [dbo].[Stroitelniy_Object] on [dbo].[Dogovor].[ID_Objecta] = [dbo].[Stroitelniy_Object].[ID_Objecta]
			inner join [dbo].[Tip_Obyekta] on [dbo].[Stroitelniy_Object].[ID_Tipa_Obyekta] = [dbo].[Tip_Obyekta].[ID_Tipa_Obyekta]
			inner join [dbo].[Uchastok] on [dbo].[Stroitelniy_Object].[ID_Uchastka] = [dbo].[Uchastok].[ID_Uchastka]
			where [dbo].[Uchastok].[ID_Sotrudnica]  = @idEmployye
	)
go


--������� � ��������
create or alter function [dbo].[Information_Uchastoc_Worcing] (@idEmployye [int])
returns table
as
	return(
		select 
		[dbo].[Tip_Obyekta].[Name] as "������� �������",
		[dbo].[Vid_Rabot].[Name] as "������������ �����"
		from [dbo].[Raboti_Na_Obiecte]
		inner join [dbo].[Stroitelniy_Object] on [dbo].[Raboti_Na_Obiecte].[ID_Objecta] = [dbo].[Stroitelniy_Object].[ID_Objecta]
		inner join [dbo].[Tip_Obyekta] on [dbo].[Stroitelniy_Object].[ID_Tipa_Obyekta] = [dbo].[Tip_Obyekta].[ID_Tipa_Obyekta]
		inner join [dbo].[Uchastok] on [dbo].[Stroitelniy_Object].[ID_Uchastka] = [dbo].[Uchastok].[ID_Uchastka]
		inner join [dbo].[Rabota_Brigadi] on [dbo].[Raboti_Na_Obiecte].[ID_Raboti] = [dbo].[Rabota_Brigadi].[ID_Raboti]
		inner join [dbo].[Vid_Rabot] on [dbo].[Rabota_Brigadi].[ID_Vida] = [dbo].[Vid_Rabot].[ID_Vida]
		where [dbo].[Uchastok].[ID_Sotrudnica] = @idEmployye
	)
go


--���������� �������
create or alter view [dbo].[Chief_Uchastca] ("��� ���������� ���������")
as
select
[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1)+'.'+SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.'
	from [dbo].[Sotrudnic]
	inner join [dbo].[Dolznost] on [dbo].[Sotrudnic].[ID_Dolznosti] = [dbo].[Dolznost].[ID_Dolznosti]
	where [dbo].[Dolznost].[Name] = '��������� �������'
go

---��������� word ����� � ������
create or alter function [dbo].[Information_Submission_Working_Date] (@idEmployye [int], @tipObject [varchar] (max))
returns table
as
	return(
		select 
		[dbo].[Sdacha_Rabot].[ID_Sdachi_Rabot] as "�����",
		[dbo].[Tip_Obyekta].[Name] as "������� �������",
		[dbo].[Vid_Rabot].[Name] as "������������ �����",
		rab.[Srok_Vipolnenia_Rabot],
		[dbo].[Uchastok].[Name],
		dog.[Data_Zacluchenia_Dogovora]
		from [dbo].[Sdacha_Rabot]
		inner join [dbo].[Raboti_Na_Obiecte] rab on [dbo].[Sdacha_Rabot].[ID_Raboti_Na_Obiecte] = rab.[ID_Raboti_Na_Obiecte]
		inner join [dbo].[Stroitelniy_Object] s1 on rab.[ID_Objecta] = s1.[ID_Objecta]
		
		inner join [dbo].[Dogovor] dog on dog.[ID_Objecta] = s1.[ID_Objecta]
		inner join [dbo].[Tip_Obyekta] on s1.[ID_Tipa_Obyekta] = [dbo].[Tip_Obyekta].[ID_Tipa_Obyekta]
		inner join [dbo].[Uchastok] on s1.[ID_Uchastka] = [dbo].[Uchastok].[ID_Uchastka]

		inner join [dbo].[Rabota_Brigadi] on rab.[ID_Raboti] = [dbo].[Rabota_Brigadi].[ID_Raboti]
		inner join [dbo].[Vid_Rabot] on [dbo].[Rabota_Brigadi].[ID_Vida] = [dbo].[Vid_Rabot].[ID_Vida]
		where 
		[dbo].[Uchastok].[ID_Sotrudnica] = @idEmployye and 
		[dbo].[Tip_Obyekta].[Name] + ','+dog.[Data_Zacluchenia_Dogovora] = @tipObject
	)
go

--�������� �� �����������
create or alter view [dbo].[Employee_Brigad] ("����� ���������","��� ����������")
as
select
	[dbo].[Brigadir].[ID_Brigadira],
	[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1)+'.'+SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.'
	from [dbo].[Brigadir]
	inner join [dbo].[Sotrudnic] on [dbo].[Brigadir].[ID_Sotrudnica] = [dbo].[Sotrudnic].[ID_Sotrudnica]
go

create or alter function [dbo].[Seartch_Brigadir_Search] (@employee [varchar] (max))
returns table
as
	return(
	select
	[dbo].[Brigadir].[ID_Brigadira] as "�����",
	[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1)+'.'+SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.' as "���"
	from [dbo].[Brigadir]
	inner join [dbo].[Sotrudnic] on [dbo].[Brigadir].[ID_Sotrudnica] = [dbo].[Sotrudnic].[ID_Sotrudnica]
	where [dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1)+'.'+SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.' =@employee
	)
go

create or alter function [dbo].[Information_Object_Uchastci_Search] (@idEmployye [int], @value [varchar] (max))
returns table
as
	return(
		select 
		[dbo].[Tip_Obyekta].[Name] + ','+ [dbo].[Dogovor].[Data_Zacluchenia_Dogovora] as "��� ����",
		[dbo].[Stroitelniy_Object].[ID_Objecta] as "����� �������"
		from [dbo].[Dogovor]
		inner join [dbo].[Stroitelniy_Object] on [dbo].[Dogovor].[ID_Objecta] = [dbo].[Stroitelniy_Object].[ID_Objecta]
		inner join [dbo].[Tip_Obyekta] on [dbo].[Stroitelniy_Object].[ID_Tipa_Obyekta] = [dbo].[Tip_Obyekta].[ID_Tipa_Obyekta]
		inner join [dbo].[Uchastok] on [dbo].[Stroitelniy_Object].[ID_Uchastka] = [dbo].[Uchastok].[ID_Uchastka]
		where [dbo].[Uchastok].[ID_Sotrudnica] = @idEmployye and [dbo].[Tip_Obyekta].[Name] + ','+[dbo].[Dogovor].[Data_Zacluchenia_Dogovora] = @value
	)
go

--����� ���������� ������� �� ��� ��������������
create or alter function [dbo].[Sotrudnic_Search_Employee] (@employee [varchar] (max))
returns table
as
	return(
		select
		[dbo].[Sotrudnic].[ID_Sotrudnica] as "����� ���������� ������",
		[dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1) + '.' + SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.' as "���"
		from [dbo].[Sotrudnic]
		where [dbo].[Sotrudnic].[Familiya] +' '+ SUBSTRING ([dbo].[Sotrudnic].[Ima],1,1) + '.' + SUBSTRING ([dbo].[Sotrudnic].[Otchestvo],1,1)+'.' = @employee
	)
go

--�����
create or alter function [dbo].[Working_Material_Inform] (@idSdach [int])
returns table
as
	return(
		select 
		[dbo].[Sdacha_Rabot].[ID_Sdachi_Rabot] as "�����",
		[dbo].[Tip_Obyekta].[Name] as "������� �������",
		[dbo].[Vid_Rabot].[Name] as "������������ �����",
		[dbo].[Raboti_Na_Obiecte].[Srok_Vipolnenia_Rabot],
		[dbo].[Material].[Name] as "��� ���������",
		[dbo].[Rashod_Materialov].[Kolichestvo] as "�����������"
		from [dbo].[Rashod_Materialov]
		inner join [dbo].[Sdacha_Rabot] on [dbo].[Rashod_Materialov].[ID_Sdachi_Rabot] = [dbo].[Sdacha_Rabot].[ID_Sdachi_Rabot]
		inner join [dbo].[Material] on [dbo].[Rashod_Materialov].[ID_Materiala] = [dbo].[Material].[ID_Materiala]
		inner join [dbo].[Raboti_Na_Obiecte] on [dbo].[Sdacha_Rabot].[ID_Raboti_Na_Obiecte] = [dbo].[Raboti_Na_Obiecte].[ID_Raboti_Na_Obiecte]
		inner join [dbo].[Stroitelniy_Object] on [dbo].[Raboti_Na_Obiecte].[ID_Objecta] = [dbo].[Stroitelniy_Object].[ID_Objecta]
		inner join [dbo].[Tip_Obyekta] on [dbo].[Stroitelniy_Object].[ID_Tipa_Obyekta] = [dbo].[Tip_Obyekta].[ID_Tipa_Obyekta]
		inner join [dbo].[Uchastok] on [dbo].[Stroitelniy_Object].[ID_Uchastka] = [dbo].[Uchastok].[ID_Uchastka]
		inner join [dbo].[Rabota_Brigadi] on [dbo].[Raboti_Na_Obiecte].[ID_Raboti] = [dbo].[Rabota_Brigadi].[ID_Raboti]
		inner join [dbo].[Vid_Rabot] on [dbo].[Rabota_Brigadi].[ID_Vida] = [dbo].[Vid_Rabot].[ID_Vida]
		where [dbo].[Rashod_Materialov].[ID_Sdachi_Rabot] =@idSdach 
	)
go

