rem // Sqlbackup.bat
 sqlcmd -U "sa" -P "lanchonete" -S .\SQLEXPRESS -i sp_BackupDatabases.sql

pause
