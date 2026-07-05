FROM mcr.microsoft.com/mssql/server:2022-latest

ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=S@mue!21

COPY init.sql /init.sql

CMD ["/opt/mssql/bin/sqlservr"]
