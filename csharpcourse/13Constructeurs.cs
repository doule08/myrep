public Hero(string pseudo, int hpMax)
            : base(hpMax)   //sélectionne le constructeur parent contenant l'argument hpMax
        {
            Pseudo = pseudo;
            BagSize = 20;
            StuffLoad = 0;
            Bag = new Stuff[BagSize];
        }

//on donne des valeurs aux propriétés qu'on veut.
// certaines valeurs sont entrées en paramètre lors de l'instanciation
// si la classe a un parent, il faut que son constructeur soit compatible avec un constructeur du parent
// et donc elle doit envoyer au parent les paramètres voulus (ici hpMax)

> écriture : 

public NomClasse(type args enfant)
  	: base(args parent)
{
     /* .... */
}

-----------------------------------------
 ordre d'instanciation :
 le constructeur va remonter jusqu'au parent le plus haut puis reconstruire tout jusqu'au constructeur appelé.
 De même, si un constructeur appelle un constructeur "this", il va d'abord utiliser le "this" avant de s'appeler lui-même.