--For Database "mvc_test

drop table testdata;

create table testdata
(
	input varchar(100) not null,
	daytime datetime,
);

INSERT INTO testdata VALUES ('hello',SYSDATETIME());
select * from testdata;