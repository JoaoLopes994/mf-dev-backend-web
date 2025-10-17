BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Consumos]') AND [c].[name] = N'Descricao');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Consumos] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Consumos] ALTER COLUMN [Descricao] nvarchar(max) NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251016151050_M03-RenameDescricao', N'8.0.21');
GO

COMMIT;
GO

