# lab2_DesignPatterns
Metodele utilizate:

*Singleton
Metoda Singleton este utilizată pentru a ne asigura că există o singură instanță a clasei GymManager, indiferent de câte ori încercăm să creăm o instanță. Astfel, ne asigurăm că accesul la managerul de sală de sport este realizat în mod coerent, indiferent de locul din cod în care se face apel la acesta.

*Factory Protothype
Metoda Prototype este utilizată pentru a clona un obiect fără a fi nevoie să îl construim din nou. În exemplul nostru, am creat un prototip pentru echipamentul de sală de sport și am clonat obiectul pentru a ne asigura că putem crea obiecte noi la nevoie, fără a construi din nou prototipul.

*Builder
Metoda Builder este utilizată pentru a crea obiecte complexe în mai multe etape. În exemplul nostru, am creat un builder de sală de sport, care ne permite să adăugăm echipament și să angajăm antrenori într-un mod organizat și coerent. Astfel, putem crea o sală de sport complet echipată, chiar dacă avem nevoie de mai multe etape pentru a realiza acest lucru.

În acest exemplu, am creat un sistem de gestionare a unei săli de sport folosind trei design patterns: Singleton, Prototype și Builder.

Clasa GymManager este implementată folosind Singleton pattern. Am definit un constructor privat pentru a nu permite crearea de instanțe ale acestei clase din afara clasei. Am definit o proprietate statică Instance care returnează o singură instanță a clasei, pe care o creăm doar dacă nu există deja o instanță.

Clasa EquipmentPrototype este o clasă abstractă care definește proprietăți comune pentru toate echipamentele de sală de sport și o metodă abstractă Clone(). Clasa Equipment extinde clasa EquipmentPrototype și implementează metoda Clone() prin apelarea metodei MemberwiseClone().

Clasa Coach este o clasă simplă care definește un antrenor de sală de sport și are o proprietate Name.

Clasa Gym este o clasă care definește o sală de sport și conține două proprietăți: Equipment, o listă de echipamente de sală de sport și Coaches, o listă de antrenori.

Clasa GymBuilder este implementată folosind Builder pattern. Am definit o clasă care ne permite să construim obiecte complexe (săli de sport) în mai multe etape. Clasa conține câteva metode de construire care ne permit să adăugăm echipament și să angajăm antrenori într-un mod organizat și coerent. Metoda Build() returnează obiectul final construit.

În metoda Main(), am creat un obiect GymBuilder și am adăugat echipament și am angajat un antrenor. Apoi, am apelat metoda Build() pentru a crea obiectul final, pe care l-am atribuit variabilei gym. Am afișat numărul de echipamente și numărul de antrenori din sala de sport construită.
