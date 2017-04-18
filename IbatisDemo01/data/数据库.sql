--简单的数据库sql语句
create database ibatisdata
use ibatisdata
create table calsses
(
calsses_id int primary key identity(1,1),
classes_name varchar(100),
classes_description varchar(100),
)
 insert into calsses(classes_name,classes_description) values('吴庭智初学者课堂','IbatisNet入门学习')