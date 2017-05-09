--For Database "mvc_test

drop table testdata;

create table testdata
(
	index_id int identity(1,1),
	input varchar(100) not null,
	daytime datetime,

	constraint pk_testdata primary key(index_id)
);

INSERT INTO testdata VALUES ('hello',SYSDATETIME());
select * from testdata;