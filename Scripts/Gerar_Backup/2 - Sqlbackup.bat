rem // Sqlbackup.bat
 sqlcmd -U "sa" -P "lanchonete" -S .\SQLEXPRESS -Q "EXEC sp_BackupDatabases @backupLocation='%cd%\', @databaseName='LANCHONETE', @backupType='F'"

pause