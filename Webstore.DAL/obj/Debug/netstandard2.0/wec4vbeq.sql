ALTER TABLE [Products] ADD [Manufacturer] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191002132819_addedProductManufacturer', N'2.2.6-servicing-10079');

GO

