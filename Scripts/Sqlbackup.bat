rem // Sqlbackup.bat
 sqlcmd -U "sa" -P "lanchonete" -S .\SQLEXPRESS -Q "EXEC sp_BackupDatabases @backupLocation='C:\Users\jacks\OneDrive\UDV\BackupBanco\', @databaseName='LANCHONETE', @backupType='F'"
