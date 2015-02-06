@echo off
SET /p choix=veuillez saisir le mot de passe de voter compte systeme Oracle :
echo %choix%
set currentpath=%~dp0
@echo CREATE USER dooms IDENTIFIED BY "14021989" TEMPORARY TABLESPACE temp; | sqlplus system/%choix%

@echo GRANT all privilege to dooms with admin option;| sqlplus system/%choix%

@echo @%currentpath%tables.sql | sqlplus dooms/"14021989"

@echo @%currentpath%pk_f_p_s_t.sql | sqlplus dooms/"14021989"

@echo @%currentpath%view.sql | sqlplus dooms/"14021989"

@echo @%currentpath%remplissage.sql | sqlplus dooms/"14021989"

echo      ################################################################
echo      ##OK, all done WELL . u can execute my application & Enjoy  !!##
echo      ################################################################

pause
