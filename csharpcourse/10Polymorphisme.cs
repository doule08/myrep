Objet qui peut se comporter comme un autre
parent <=> enfant <=> parent

cast implicite => un student EST une personne
cast explicite => on précise que une personne est un student
____________________________________________________________________
> (ici, Professeur hérite de Personne)
  
POLYMORPHISME IMPLICITE :
>   Personne personne = prof;
	//parent = enfant;

POLYMORPHISME EXPLICITE : 
>   Professeur professeur = (Professeur)personne;
	//enfant = (enfant)parent;
____________________________________________________________________

Margherita pizza = new Hawai();
cw(pizza.GetType());	// Hawai

