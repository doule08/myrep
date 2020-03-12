niveaux d'accessibilité : public < internal < protected internal < protected < private.....
->dans une classe, par défaut, on est private
->dans un namespace, par défaut, on est internal
  
seule la classe qui déclare qqch a le droit de le modifier (=propriétés private)
  
  -attribut : private _var;

  -propriété : public Var get             // = méthode
  				{   return _var ;} 
					set{ _var= xxx; } 
				}					  	

=> l'intérêt est d'avoir plus de contrôle sur les attributs.

------------------------------------------------------------------------------------
  
//auto propriétés = "simple"
public string Name {get ; set}		// -> affectation "simple"

//propfull = on peut mettre ce qu'on veut comme condition pour avoir accès aux attributs
private string _name;

public string Name
{
	get { return _name;}
    set { _name = value!= null ? value : _name; }
}
un getter/setter ne peut prendre aucun paramètre d'entrée
-----------------------------------------
exemple modif : 

public string Name
{
	get { return _name.ToUpper(); }
    set { _name = value; }

-------------------------------------------------
// si on veut lire sans pouvoir modifier une liste (lecture seule, sans .Add [qui ne nécessite pas de setter])
private List<Cours> courses = new List<Cours>;		//crée liste privée

public Cours[] Courses		//crée un tableau
{ get courses.ToArray(); }	// getter renvoie une copie de la liste, avec une taille non modifiable
// {pas de set; }			// et on protège donc la liste de base

------------------------------------------------
