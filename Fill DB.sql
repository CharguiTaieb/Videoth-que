-- ============================================================
--    suppression des donnees
-- ============================================================

delete from ACTEUR ;
delete from FILM ;
delete from REALISATEUR ;

-- ============================================================
--    creation des donnees
-- ============================================================

-- REALISATEUR
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ('SAUTET CLAUDE','FRANCAISE','23-02-1924');
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ('PINOTEAU CLAUDE','FRANCAISE','25-05-1925') ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ('Arnold Schwarzenegger ','AMERICAINE','30-07-1947');
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'ZIDI CLAUDE'       , 'FRANCAISE'  ,'25-07-1934') ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'AUTAN-LARA CLAUDE'       , 'FRANCAISE' ,'05-08-1901'  ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'ROHMER ERIC'         , 'FRANCAISE' ,'21-03-1920' ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'MALLE LOUIS' , 'FRANCAISE' ,'30-10-1932' ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'BESSON LUC'          , 'FRANCAISE','18-03-1959'  ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'PREMINGER OTTO'         , 'FRANCAISE','05-09-1905' ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'BEINEIX JEAN-JACQUES' , 'FRANCAISE' ,'08-10-1946' ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'GERONIMI C.'           , 'AMERICAINE','12-07-1901' ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'LYNE ADRIAN'       , 'AMERICAINE' ,'04-03-1941') ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'TRUFFAUT FRANCOIS'     , 'FRANCAISE','06-02-1932 '  ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ('COCTEAU JEAN'         , 'FRANCAISE','05-07-1889 '  ) ;
insert into Realisateur (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'CACOYANNIS MICHAEL'      , 'GREC'  ,'11-06-1922'     ) ;


-- FILM

insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ('GARCON', '01-01-1983' , 1,'COMEDIE' ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ('CESAR ET ROSALIE'             , '02-04-1971'             ,  1 ,  'COMEDIE') ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ('LA FAC'                       , '24-02-1989'         ,  3 , 'SATYRIQUE'  ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LA PISCINE'                   , '13-05-1967'  ,  2 ,  'COMEDIE DRAMATIQUE') ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LA 7EME CIBLE'                , '01-01-1984'           ,  2,  'SUSPENSE'  ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'ASSOCIATION DE MALFAITEURS'   , '01-01-1987'           ,  4,  'COMEDIE'   ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LA JUMENT VERTE'              , '01-01-1959'             ,  5 ,   'COMEDIE') ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'AU REVOIR LES ENFANTS'        , '01-01-1987'               ,  7,  'DRAME' ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LE GRAND SCOGRIFFE'           , '01-01-1976'            ,  2 ,   'COMEDIE' ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LA FEMME DE L''AVIATEUR'      , '01-01-1979' ,  6 ,   'COMEDIE DRAMATIQUE' ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'L''ANIMAL'                    , '01-01-1977'            ,  4,   'COMEDIE'  ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( '9 SEMAINE 1/2'                , '01-01-1986'      , 12,  'DRAME EROTIQUE' ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LA SIRENE DU MISSIPI'         , '01-01-1969'  , 13 ,  'COMEDIE POLICIERE'  ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LA TRAVERSEE DE PARIS'        , '01-01-1956'  ,  5 ,   'COMEDIE DRAMATIQUE') ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'PAULINE A LA PLAGE'           , '01-01-1982'  ,  6 ,   'COMEDIE DE MOEURS' ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LE GRAND BLEU'                , '01-01-1987'  ,  8 ,   'COMEDIE DRAMATIQUE') ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'ALICE AU PAYS DES MERVEILLES' , '01-01-1951'        , 11 ,   'DESSIN ANIME') ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'EXODUS'                       , '01-01-1960'        ,  9,   'DRAME'        ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( '37 2 LE MATIN'                , '01-01-1991'           , 10 ,   'DRAME'    ) ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'LE RAYON VERT'                , '01-01-1986'  ,  6 ,   'COMEDIE DRAMATIQUE') ;
insert into FILM (TITRE,ANNEREALIS,IDREALIS,genre) values ( 'ZORBA LE GREC'                , '17-01-1964'             , 14 ,   'DRAME'  ) ;


-- ACTEUR

insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'MONTAND YVES', 'FRANCAISE', '13-09-1921' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'GARCIA NICOLE'      , 'FRANCAISE'    , '21-02-1957' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'VILLERET JACQUES'     , 'FRANCAISE'    , '06-02-1951' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'DUBOIS MARIE'       , 'FRANCAISE'    , '12-02-1937' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'SCHNEIDER ROMY'        , 'AUTRICHIENNE' , '01-04-1942' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'FREY SAMY'        , 'FRANCAISE'    , '24-05-1940' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'RICARDO BRUNOZZI'    , 'ITALIENNE'    , '08-04-1958' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'DUPRILLOT JOHEL'       , 'TCHEQUE'      , '24-04-1968' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'LESTRADOS DOMINIQUOS'  , 'MEXICAINE'    , '19-02-1969' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'DELON ALAIN'       , 'FRANCAISE'    , '04-09-1933' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'VENTURA LINO'        , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'MASSARI LEA'         , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'POIRET JEAN'        , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'CLUZET FRANCOIS'    , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'MALAVOY CHRISTOPHE'  , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'BOURVIL BOURVIL'     , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'ROBERT YVES'        , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'MANESSE GASPARD'     , 'ALLEMANDE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'BELLI AGOSTINA'    , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'BRASSEUR CLAUDE'      , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'MARLAUD PHILIPPE'    , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'BELMONDO JEAN-PAUL'   , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'ROURKE MICKEY'      , 'AMERICAINE'   , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'BASINGER KIM'         , 'AMERICAINE'   , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'DENEUVE CATHERINE'   , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'GABIN JEAN'        , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'DE FUNES LOUIS'       , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'LANGLET AMANDA'      , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'BARR JEAN-MARC'   , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'ARQUETTE ROSANNA'     , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'RENO JEAN'        , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values ( 'NEWMAN PAUL'        , 'AMERICAINE'   , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'DALLE BEATRICE'    , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'ANGLADE JEAN-HUGUES' , 'FRANCAISE'    , '01-01-1901' ) ;
insert into ACTEUR (NOM_PRENOM,PAYS,DATENAISSANCE) values (  'RIVIERE MARIE'       , 'FRANCAISE'    , '01-01-1901' ) ;


--exemplaire
insert into Exemplaire(IDFILM,TYPESUPP) values (2,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (2,'VCD');
insert into Exemplaire(IDFILM,TYPESUPP) values (2,'CD');
insert into Exemplaire(IDFILM,TYPESUPP) values (1,'BLU-RAY');
insert into Exemplaire(IDFILM,TYPESUPP) values (6,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (10,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (2,'CD');
insert into Exemplaire(IDFILM,TYPESUPP) values (2,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (12,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (7,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (5,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (8,'USB');
insert into Exemplaire(IDFILM,TYPESUPP) values (13,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (7,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (12,'DVD2couche');
insert into Exemplaire(IDFILM,TYPESUPP) values (3,'DVD');
insert into Exemplaire(IDFILM,TYPESUPP) values (4,'DVD');


--acter

insert into acter (IDFILM,NUMACTEUR) values (2,3);
insert into acter (IDFILM,NUMACTEUR) values (3,3);
insert into acter (IDFILM,NUMACTEUR) values (4,5);
insert into acter (IDFILM,NUMACTEUR) values (4,4);
insert into acter (IDFILM,NUMACTEUR) values (3,4);
insert into acter (IDFILM,NUMACTEUR) values (8,1);
insert into acter (IDFILM,NUMACTEUR) values (6,9);
insert into acter (IDFILM,NUMACTEUR) values (3,10);
insert into acter (IDFILM,NUMACTEUR) values (2,9);
insert into acter (IDFILM,NUMACTEUR) values (2,10);
insert into acter (IDFILM,NUMACTEUR) values (10,3);
insert into acter (IDFILM,NUMACTEUR) values (2,5);

--client
insert into client (CIN,NOM_PRENOM,DATENAISSANCE,ADRESSE)values(04814944,'chargui taieb','14/02/1989','rue raihan cité ezzouhour 1 n°5');

