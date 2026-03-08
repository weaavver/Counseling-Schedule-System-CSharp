Pre requisite

Microsoft sql server eval and
SSMS(optional but recommended)
https://www.microsoft.com/en-us/evalcenter/evaluate-sql-server-2025
https://learn.microsoft.com/en-us/ssms/install/install

Microsoft Visual Studio (2026 recommended)
https://visualstudio.microsoft.com/insiders/

Bcrypt tool
install bcryp 
in Visual Studio Go to Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution
Click Browse
find BCrypt.Net-Next and install it

after cloning run create database and tables in the sql file
here Counseling Schedule System\CASESTUDY_SQLs.sql
Reminder: You also have to change the connection string in the code according to your pc:

string connectionString = @"Data Source=DESKTOP-IRCI6E2;Initial Catalog=CounselingScheduleSystem;Integrated Security=True;Encrypt=False;";
                                        ^^^^^^^^^^^^^^^
You can also just replace the DESKTOP-IRCI6E2 in this^ with your pc name and replace the connection string in the initial configuration of
your SSMS
