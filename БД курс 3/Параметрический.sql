﻿declare @doljnost nvarchar(MAX) = N'Программист'
select [Сотрудники].[Код сотрудника], [Сотрудники].[ФИО сотрудника], [Должности].[Название должности] from[Сотрудники]
INNER JOIN [Должности] ON [Должности].[Код должности] = [Сотрудники].[Должность]
where [Должности].[Название должности] = @doljnost