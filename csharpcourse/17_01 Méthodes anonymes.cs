> les delegate peuvent aussi déclarer des méthodes anonymes (méthodes sans nom)

> C est une VARIABLE de la forme d une méthode
> utilisée dans un bloc de code, appartient à la classe.
> Souvent remplacées par les expression lambda (sans ref ou out)

1) Déclaration dans namespace :
	delegate void DelAnonyme(); // prototype du délégué

2) Appel dans main :
	DelAnonyme nomDel = delegate() // entête
    {
      // corps
    }

-------------------------------------------------
ex :
  delegate bool TryParseDelegate(string s, out int x);	// prototype, retour : bool ; params : string et out int

  main(){
    
    TryParseDelegate TryParse = delegate(string s, out int x){ //  entête, reprend les arguments du proto
      //corps :
      x = default(int);
      try
      {
        x = int.Parse(s);
        return true;
      }
      catch(Exception)
      { 
        return false
      }
    };    
  }
