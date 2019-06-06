0) Восстановить пакеты NuGet

1)Создать БД с имененм DB_test


2) Запрос на создание таблицы сотрудников

CREATE TABLE [dbo].[Employees] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NULL,
    [LastName]  NVARCHAR (MAX) NULL,
    [Dep]       NVARCHAR (MAX) NULL,
    [Salary]    INT            NOT NULL,
    CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED ([Id] ASC)
);


3)Запрос на создание таблицы отделов

CREATE TABLE [dbo].[Departments] (
    [Id] INT            IDENTITY (1, 1) NOT NULL,
    [DP] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED ([Id] ASC)
);




4)Заполнить таблицу сотрудников исходными данными

INSERT INTO Employees(FirstName,LastName,Dep,Salary) VALUES (N'Павел',N'Бекешко',N'Отдел обработки',100000)
INSERT INTO Employees (FirstName,LastName,Dep,Salary) VALUES (N'Никита',N'Журавко',N'Отдел обработки',50000)


5)Заоплнить таблицу отделов исходными данными

INSERT INTO Departments(DP) VALUES (N'Отдел обработки')
INSERT INTO Departments(DP) VALUES (N'Отдел интерпретации')
INSERT INTO Departments(DP) VALUES (N'Отдел техподдержки')



