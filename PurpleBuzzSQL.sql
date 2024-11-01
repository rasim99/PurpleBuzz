INSERT INTO TeamMembers(PhotoUrl,[Name],Surname,Position,CreateAt) VALUES
('/assets/img/team-01.jpg','Jhon','Doe','Business Development',GETDATE()),
('/assets/img/team-02.jpg','Jane','Doe','Media Development',GETDATE()),
('/assets/img/team-03.jpg','Sam',null,'Developer ',GETDATE())

SELECT * FROM TeamMembers

INSERT INTO AboutServices(Icon,Title,[Description],CreateAt) VALUES
('display-4 bx bxs-bulb text-light','Our Vision',' Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra.',GETDATE()),
('display-4 bx bx-revision text-light','Our Mission',' Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis.',GETDATE()),
('display-4 bx bxs-select-multiple text-light','Our Goal',' Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor.',GETDATE())

SELECT * FROM AboutServices


INSERT INTO Contacts(Icon,ContactTYpe,WorkerName,PhoneNumber,CreateAt) VALUES
('display-6 bx bx-news','Media Contact','Mr. John Doe','010-020-0340',GETDATE()),
('bx bx-laptop display-6','Technical Contact','Mr. John Stiles','010-020-0340',GETDATE()),
('bx bx-money display-6','Billing Contact','Mr. Richard Miles','010-020-0340',GETDATE())

SELECT * FROM Contacts

INSERT INTO Works(PhotoUrl,WorkName,[Description],CreateAt) VALUES
('/assets/img/services-01.jpg','UI/UX design','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE()),
('/assets/img/services-02.jpg','Social Media','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE()),
('/assets/img/services-03.jpg','Marketing','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE()),
('/assets/img/services-04.jpg','Graphic','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE()),
('/assets/img/services-05.jpg','Digtal Marketing','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE()),
('/assets/img/services-06.jpg','Market Research','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE()),
('/assets/img/services-07.jpg','Business','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE()),
('/assets/img/services-08.jpg','Branding','Lorem ipsum dolor sit amet, consectetur adipisicing',GETDATE())
SELECT * FROM Works

INSERT INTO RecentWorks(PhotoUrl,WorkName,[Description],CreateAt) VALUES
('/assets/img/recent-work-01.jpg','Social Media','Ullamco laboris nisi ut aliquip ex',GETDATE()),
('/assets/img/recent-work-02.jpg','Web Marketing ','Psum officia anim id est laborum.',GETDATE()),
('/assets/img/recent-work-03.jpg',' R & D','Sum dolor sit consencutur ' ,GETDATE()),
('/assets/img/recent-work-04.jpg' , 'Public Relation','Lorem ipsum dolor sit amet', GETDATE()),
('/assets/img/recent-work-05.jpg','Branding','Put enim ad minim veniam',GETDATE()),
('/assets/img/recent-work-06.jpg','Creative Design ','Mollit anim id est laborum.',GETDATE())

SELECT * FROM RecentWorks

INSERT INTO Plans(PlanType,Price,UserCount,Capacity,[Source],Support,Addition,CreateAt) VALUES
('Free Plan','$0','5 Users',2,'Community Forums','Email Support',null,GETDATE()),
('Standart Plan','$120/Year','25 to 99 Users',10,' Source Files ','Live Chat',null,GETDATE()),
('Enterprise','$840/Year','100 users or more',80,'Full Access Sources ','Live Chat','Customizations',GETDATE())
SELECT * FROM Plans