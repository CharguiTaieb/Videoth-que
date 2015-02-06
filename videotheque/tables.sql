/*==============================================================*/
/* Nom de SGBD :  ORACLE Version 10g                            */
/* Date de création :  25/12/2012 16:35:49                      */
/*==============================================================*/


alter table ACTER
   drop constraint FK_ACTER_REFERENCE_ACTEUR;

alter table ACTER
   drop constraint FK_ACTER_REFERENCE_FILM;

alter table EMPREINTE
   drop constraint FK_EMPREINT_REFERENCE_CLIENT;

alter table EMPREINTE
   drop constraint FK_EMPREINT_REFERENCE_EXEMPLAI;

alter table EXEMPLAIRE
   drop constraint FK_EXEMPLAI_REFERENCE_FILM;

alter table FILM
   drop constraint FK_FILM_REFERENCE_REALISAT;

alter table PICFILM
   drop constraint FK_PICFILM_REFERENCE_FILM;

drop table ACTER cascade constraints;

drop table ACTEUR cascade constraints;

drop table CLIENT cascade constraints;

drop table EMPREINTE cascade constraints;

drop table EXEMPLAIRE cascade constraints;

drop table FILM cascade constraints;

drop table PICFILM cascade constraints;

drop table REALISATEUR cascade constraints;

/*==============================================================*/
/* Table : ACTER                                                */
/*==============================================================*/
create table ACTER  (
   IDACTER              NUMBER                          not null,
   IDFILM               NUMBER,
   NUMACTEUR            NUMBER,
   constraint ACTER_PK primary key (IDACTER)
         ENABLE
);

/*==============================================================*/
/* Table : ACTEUR                                               */
/*==============================================================*/
create table ACTEUR  (
   NUMACTEUR            NUMBER                          not null,
   NOM_PRENOM           VARCHAR2(200),
   PAYS                 VARCHAR2(100),
   DATENAISSANCE        DATE,
   constraint ACTEUR_PK primary key (NUMACTEUR)
         ENABLE
);

/*==============================================================*/
/* Table : CLIENT                                               */
/*==============================================================*/
create table CLIENT  (
   IDCLIENT             NUMBER                          not null,
   CIN                  NUMBER,
   NOM_PRENOM           VARCHAR2(500),
   DATENAISSANCE        DATE,
   ADRESSE              VARCHAR2(4000),
   constraint CLIENT_PK primary key (IDCLIENT)
         ENABLE
);

/*==============================================================*/
/* Table : EMPREINTE                                            */
/*==============================================================*/
create table EMPREINTE  (
   IDPREINTE            NUMBER                          not null,
   IDCLIENT             NUMBER,
   IDXEMPLAIRE          NUMBER,
   DATEEMPREINTE        DATE,
   DATERETOUR           DATE,
   constraint EMPREINTE_PK primary key (IDPREINTE)
         ENABLE
);

/*==============================================================*/
/* Table : EXEMPLAIRE                                           */
/*==============================================================*/
create table EXEMPLAIRE  (
   IDXEMPLAIRE          NUMBER                          not null,
   IDFILM               NUMBER,
   TYPESUPP             VARCHAR2(50),
   constraint EXEMPLAIRE_PK primary key (IDXEMPLAIRE)
         ENABLE
);

/*==============================================================*/
/* Table : FILM                                                 */
/*==============================================================*/
create table FILM  (
   IDFILM               NUMBER                          not null,
   TITRE                VARCHAR2(4000),
   ANNEREALIS           DATE,
   IDREALIS             NUMBER,
   GENRE                VARCHAR2(200),
   constraint FILM_PK primary key (IDFILM)
         ENABLE
);

/*==============================================================*/
/* Table : PICFILM                                              */
/*==============================================================*/
create table PICFILM  (
   IDPIC                NUMBER                          not null,
   PIC                  BLOB,
   IDFILM               NUMBER,
   constraint PICFILM_PK primary key (IDPIC)
         ENABLE
);

/*==============================================================*/
/* Table : REALISATEUR                                          */
/*==============================================================*/
create table REALISATEUR  (
   IDREALIS             NUMBER                          not null,
   NOM_PRENOM           VARCHAR2(200),
   PAYS                 VARCHAR2(200),
   DATENAISSANCE        VARCHAR2(200),
   constraint REALISATEUR_PK primary key (IDREALIS)
         ENABLE
);

alter table ACTER
   add constraint FK_ACTER_REFERENCE_ACTEUR foreign key (NUMACTEUR)
      references ACTEUR (NUMACTEUR);

alter table ACTER
   add constraint FK_ACTER_REFERENCE_FILM foreign key (IDFILM)
      references FILM (IDFILM);

alter table EMPREINTE
   add constraint FK_EMPREINT_REFERENCE_CLIENT foreign key (IDCLIENT)
      references CLIENT (IDCLIENT);

alter table EMPREINTE
   add constraint FK_EMPREINT_REFERENCE_EXEMPLAI foreign key (IDXEMPLAIRE)
      references EXEMPLAIRE (IDXEMPLAIRE);

alter table EXEMPLAIRE
   add constraint FK_EXEMPLAI_REFERENCE_FILM foreign key (IDFILM)
      references FILM (IDFILM);

alter table FILM
   add constraint FK_FILM_REFERENCE_REALISAT foreign key (IDREALIS)
      references REALISATEUR (IDREALIS);

alter table PICFILM
   add constraint FK_PICFILM_REFERENCE_FILM foreign key (IDFILM)
      references FILM (IDFILM);

