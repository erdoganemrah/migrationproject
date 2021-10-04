git clone https://github.com/dalibo/sqlserver2pgsql.git
cd sqlserver2pgsql
vim sqlserver2pgsql.pl

hierarchyid => bytea
geography => bytea
geomerty => bytea

sed -i 's/\[dbo\]\.\[AccountNumber\]/[nvarchar](15)/g' tables.sql
sed -i 's/\[dbo\]\.\[Flag\]/[bit]/g' tables.sql
sed -i 's/\[dbo\]\.\[Name\]/[nvarchar](50)/g' tables.sql
sed -i 's/\[dbo\]\.\[NameStyle\]/[bit]/g' tables.sql
sed -i 's/\[dbo\]\.\[OrderNumber\]/[nvarchar](25)/g' tables.sql
sed -i 's/\[dbo\]\.\[Phone\]/[nvarchar](25)/g' tables.sql

perl sqlserver2pgsql.pl -f tables.sql -b tables-before.sql -a tables-after.sql -u tables-unsure.sql

