****Application requise :******

-oracle 10g express 
-ODT with ODAC : que vous pouvez le telechargé depuis cette adresse
http://download.oracle.com/otn/other/ole-oo4o/ODTwithODAC1120320_32bit.zip?AuthParam=1351889239_4beaed970d70e8c2fabf17e6190e0071
-netframework 4.0.319 ou +

******istallation*****


1)veuillez ajouter ce contenu au fichier tnsnames.ora  qui se trouve par default dans ce chemin
C:\app\%user%\product\11.2.0\client_1\Network\Admin\Sample
mais vous devez le placer dans hors ce dossier de cette facon
C:\app\%user%\product\11.2.0\client_1\Network\Admin\tnsnames.ora 

puis ajouter ce contenu a le fichier 

OraclePlt =
  (DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = xe)
    )
  )

  



2)executer le fichier autoconfiguration.bat qui se trouve dans le dossier 
note : si le fichier fonctionne correctement c bn si non
tu doit manuellement creer un compte user de nom "dooms" et de mot de passe"14021989" avec votre compte systeme bien sur 
puis selon ordre chargerles fichier scripts  .sql et les executes .

tables.sql
pk_f_p_s_t.sql
view.sql
remplissage.sql

3)execute l'application videotheque
