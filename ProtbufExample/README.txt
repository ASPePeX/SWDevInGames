Beispiel f�r die Anwendung von Protobuf.net mit dem Precompiler.

Das Unterverzeichnis "Protobuf" enth�lt Dateien aus der Protobuf.net Distribution

Zun�chst das PRojekt "Student" bauen. Es enth�lt die Deklaration des Datenmodells. Objekte sollen in einer Datei speicherbar sein.

Dann die Datei "PrecompileStudent.bat" ausf�hren. Hier wird der Protobuf.net Precompiler aufgerufen, der die "StudSer.dll" erzeugt (in PrecompileOutput). Diese DLL enth�lt den StudentSerializer, mit dem Studenten-Daten gelesen und geschrieben werden k�nnen.

StudentDataReader und -Writer referenzieren die StudSer.dll und die KLasse StudentSerializer dann um Daten auf Platte zu lesen und zu schreiben. StudenteDataWriter legt die Datei "data.students" unter StudentDataWriter/bin/Debug an. Damit der StudentDataReader auf Daten zugreifen kan, m�ssen diese nach StudentDataReader/bin/Debug kopiert werden.

