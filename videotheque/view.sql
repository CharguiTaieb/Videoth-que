CREATE OR REPLACE FORCE VIEW  "V_ACTEUR"  AS   SELECT "NUMACTEUR","NOM_PRENOM","PAYS","DATENAISSANCE" FROM acteur
/
CREATE OR REPLACE FORCE VIEW  "V_CLIENT"  AS   SELECT "IDCLIENT","CIN","NOM_PRENOM","DATENAISSANCE","ADRESSE" from client
/
CREATE OR REPLACE FORCE VIEW  "V_FILM"  AS   SELECT "IDFILM","TITRE","ANNEREALIS","IDREALIS","GENRE" from film
/
CREATE OR REPLACE FORCE VIEW  "V_REALISATEUR"  AS   SELECT "IDREALIS","NOM_PRENOM","PAYS","DATENAISSANCE" FROM realisateur
/
CREATE OR REPLACE FORCE VIEW  "VIEW1" ("TITRE", "ANNEE_REALISATION", "GENRE", "REALISATEUR", "TYPESUPPORT") AS 
  select	 F.TITRE as TITRE,
	 F.ANNEREALIS as ANNEE_REALISATION,
	 F.GENRE as GENRE,
	 R.NOM_PRENOM as realisateur,
	 EX.TYPESUPP as TYPESUPPORT 
 from	 EMPREINTE EM,
	 REALISATEUR R,
	 EXEMPLAIRE EX,
	 FILM F 
 where   EX.IDFILM=F.IDFILM
 and	 F.IDREALIS=R.IDREALIS
 and	 EX.IDXEMPLAIRE=EM.IDXEMPLAIRE
/

