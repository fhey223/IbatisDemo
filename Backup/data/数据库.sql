--�򵥵����ݿ�sql���
create database ibatisdata
use ibatisdata
create table calsses
(
calsses_id int primary key identity(1,1),
classes_name varchar(100),
classes_description varchar(100),
)
 insert into calsses(classes_name,classes_description) values('��ͥ�ǳ�ѧ�߿���','IbatisNet����ѧϰ')