select * from information_schema.tables

sp_help target_url

insert into target_url
( url, size_in_bytes )
values ('http://theonion.com', null)

insert into target_url
( url)
values ('http://ibm.com')

select id, url as new_column_name, size_in_bytes
from target_url

update target_url
set url='http://goal.com'
where Id = 2

delete target_url
where id = 2

begin tran -- commit tran rollback
insert into target_url
( url )
values
( 'http://www.microsoft.com' )


select * from target_url
