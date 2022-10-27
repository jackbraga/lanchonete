rem // Sqlbackup.bat
 sqlcmd -U "sa" -P "lanchonete" -S .\SQLEXPRESS -Q "EXEC sp_BackupDatabases @backupLocation='C:\Github\lanchonete\BackupBanco\', @databaseName='LANCHONETE', @backupType='F'"
pause
