print 'Insertion des rangées dans le table Clients...'
set DATEFORMAT dmy;
GO
DECLARE @dateRef DATETIME;
SET @dateRef = '23/6/1990';

INSERT INTO Clients  VALUES 
(123005,'Ned','Triton',        '345 Rue Bolindigo',   '418-778-2835',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123006,'Wallace','Sefresti',       '123 Rue Beausite',   '514-764-0987',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123007,'Gromit','Sefresti',       '123 Rue Beausite',   '450-764-0987',       'TotoVille', @dateRef); 
INSERT INTO Clients  VALUES 
(123008,'Molton','Sefresti',       '123 Rue Beausite',   '514-764-0987',       'TotoVille', @dateRef); 
INSERT INTO Clients  VALUES 
(123009,'Achille','Talon',          '67 Rue de la virgule',   '514-876-0987',   'TataVille', @dateRef);
INSERT INTO Clients  VALUES 
(123010,'Obelix','Le Gaulois',       '78 Rue Cervoise',   '819-956-4753',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123011,'Hagar','L''horrible',       '23 Av. Brun',   '418-750-9678',       'Charlesbourg', @dateRef); 
INSERT INTO Clients  VALUES  
(123012,'Charlie','Brown',          '123 Rue Beausite',   '514-764-0987',       'TotoVille', @dateRef); 
INSERT INTO Clients  VALUES 
(123013,'Lucien','Tetebeche',       '55 rue principale',   '514-957-0945',       'TotoVille', @dateRef);  
INSERT INTO Clients  VALUES 
(123014,'Arthur','Laroche',         '456 Rue rock',   '450-756-7564',       'TataVille', @dateRef);  
INSERT INTO Clients  VALUES 
(123015,'Délima','Cailloux',       '454 Rue Rock',   '450-756-7984',       'TataVille', @dateRef); 
INSERT INTO Clients  VALUES 
(123016,'Bertha','Laroche',       '456 Rue Rock',   '514-756-7564',       'TataVille', @dateRef);
INSERT INTO Clients  VALUES 
(123017,'Poncho','Sanchez',       '123 av du moulin ',   '418-776-0685',       'Sainte-foy', @dateRef);
INSERT INTO Clients  VALUES 
(123018,'Gaston','Lagaffe',       '13  Rue du gag',   '450-857-0987',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123019,'Bianca','Castafiore',       '7586 Rue Voiclair',   '819-567-2030',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123020,'Capitaine','Hadock',       '12 Rue Moulinsar',   '819-786-0945',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123021,'Red','Ketchup',       '57 Rue Heintz',  '450-884-2299',       'TataVille', @dateRef);
INSERT INTO Clients  VALUES 
(123022,'Bart','Simpson',       '678 Rue Springfield',   '418-747-2293',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123023,'Homer','Simpson',       '678 Rue Springfield',   '747-2293',       'TotoVille', @dateRef);  
INSERT INTO Clients  VALUES 
(123024,'Fred','Cailloux',       '5 chemin du rock',   '514-987-4545',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123025,'Toto','Lebeau',       '123 Rue Beausite',   '418-764-0987',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123026,'Onesime','Lebeau',       '123 Rue Beausite',   '514-764-0987',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123027,'Titi','Lebeau',       '123 Rue Beausite',   '819-764-0987',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123028,'Retro','Vitiro',       '44 Rue imaginaire',   '450-776-7745',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123029,'Bodormir','Vitiro',       '44 Rue imaginaire',   '514-776-7745',       'TotoVille', @dateRef);
INSERT INTO Clients  VALUES 
(123999,'Extrèmeeeeeeeeeeeeee',   'Maximummmmmmmmm'   , '9876 avenue  des Plus Gros',   '999-999-9999',       
'Charlesbourg', @dateRef);