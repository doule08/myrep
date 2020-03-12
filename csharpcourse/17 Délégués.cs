A)Présentation :

    > C'est une VARIABLE de type Pointeur de fonctions
    > Héritent tous de la classe Delegate 
	> internal par défaut.

    1) Déclaration du PROTOTYPE (dans namespace) :
        delegate void MonDelegate();

    2) Affectation d une valeur (dans main) :
        MonDelegate del = MaMethode; // pas de () !!!

    3) Ecriture de MaMethode() :
        static void MaMethode() {	}

--------------------------------------------
B) Utilisation  

    > Sert à utiliser une fonction comme une variable
    > Un délégué peut contenir plusieurs méthodes
    > Pour ajouter une méthode : +=
    > Pour retirer une méthode : -=

    ex :
    MonDelegate del = MaMethode;
    del += MaMethode;
    del += MaMethode2;
    del -= Mamethode ; // suppression d'une des 2 MaMethode

    del(); // Exécute le contenu du délégué càd les 2 méthodes 

    static void MaMethode(){ Console.WriteLine("Appel de MaMethode");
    static void MaMethode2(){ Console.WriteLine("Appel de MamMethode2");

--------------------------------------------
C) Invoke :
                             
	> Pour déclencher un délégué,  il suffit d appeler la méthode Invoke ou d utiliser les ()
    > Le cas échéant on passe les paramètres entre ()
    > Ces derniers sont spécifiés par le prototype du délégué.
    
    > On vérifie que le delegate est non null avant de l exécuter :
		if (del != null) del();
    
	> raccourci :
		del?.Invoke();

--------------------------------------------
D) Appeler des privées :

	> Un délégué peut appeler une méthode privée d une autre classe,
    > Ssi c est cette dernière qui lui fournit l adresse de sa méthode.
    > On dit dans ce cas que la classe délègue le déclenchement de sa méthode à une variable.
    (exemple p 122)