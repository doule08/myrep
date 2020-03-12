class MaClasse : ClasseParent

//MaClasse hérite de la classe parent, càd de tous ses membres
___________________________________________
override = on réécrit toute la méthode (surcharge)
_____________________________________________

REDEFINITION METHODE :

(dans parent) méthode virtual = les enfants PEUVENT réécrire la fonction
// on écrit du code dans le parent

(dans parent) méthode abstract = au moins les 1er enfants non abstraits DOIVENT redéfinir
  // on n'écrit pas de code dans le parent
  
(dans enfant) méthode override = méthode réécrivant une méthode abstract ou virtual
_____________________________________________

SURCHARGE :
// On peut override une méthode ssi la méthode parent est virtual, abstract OU override

(dans parent)
public virtual SePresenter()
{ /* ... */ }

(dans enfant) 
public override void SePresenter()
{
  base.SePresenter();	//aura accès aux variables privées du parent car la méthode de base a toujours accès à celles-ci
  /* surcharge */
}
  
______________________________________________

Type déclaré vs type hérité:

Personne p = new Student();	// p a accès à tout ce qui est commun à Personne et Student
//déclaré		 //hérité
_______________________________________________
// IS A  : hérite
// HAS A  : mêmes champs qu'une classe mais n'en hérite pas  
// (exemple un robot n'hériterait pas d'un humain même s'il a les "mêmes" carac)


_______________________________________________
TEMPLATE PATTERN :
// (quand on envoie une methode abstract dans une méthode non abstract)

public abstract decimal Prix { get; }	// le prix sera redéfini chez les enfants

public void AfficherPrix()
{
  cw("Prix : " + prix);
}
_______________________________________________
sealed : 
// mot-clé pour empêcher l'héritage :
public sealed MaClasse {	}

// utilisable aussi pour empêcher la surcharge de méthodes dans une classe enfant : 
public class Chien
{
    public virtual void Aboyer()
    {
        Console.WriteLine("Wouf");
    }
}

public class ChienMuet : Chien
{
    public sealed override void Aboyer()
    {
        Console.WriteLine("...");
    }
}