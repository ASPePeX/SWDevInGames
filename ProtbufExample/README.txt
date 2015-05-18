Beispiel für die Anwendung von Protobuf.net mit dem Precompiler.

Das Unterverzeichnis "Protobuf" enthält Dateien aus der Protobuf.net Distribution

Zunächst das PRojekt "Student" bauen. Es enthält die Deklaration des Datenmodells. Objekte sollen in einer Datei speicherbar sein.

Dann die Datei "PrecompileStudent.bat" ausführen. Hier wird der Protobuf.net Precompiler aufgerufen, der die "StudSer.dll" erzeugt (in PrecompileOutput). Diese DLL enthält den StudentSerializer, mit dem Studenten-Daten gelesen und geschrieben werden können.

StudentDataReader und -Writer referenzieren die StudSer.dll und die KLasse StudentSerializer dann um Daten auf Platte zu lesen und zu schreiben. StudenteDataWriter legt die Datei "data.students" unter StudentDataWriter/bin/Debug an. Damit der StudentDataReader auf Daten zugreifen kan, müssen diese nach StudentDataReader/bin/Debug kopiert werden.

