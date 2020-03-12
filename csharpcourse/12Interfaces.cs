Interface = Contrat

Cest comme une classe abstraite pour laquelle TOUTES les méthodes sont public abstract 
  PAS de override dans la classe implémentant l interface
_______________________________________________________________
  
Une interface ne contient QUE des méthodes  (et des GET SET)
  
  > ex: int MaVariable { get; set; }
________________________________________________________________  
une interface peut hériter d une autre interface 

//ex:

public interface IVehicule
{
  string Name {get; set;}
  void Tourner();	
}
  
public interface IVoiture : IVehicule
public interface IBateau : IVehicule

public class Bateau:IBateau

public class Voiture:Ivoiture	// pas besoin de réimplémenter IVehicule
____________________________________________________________________
l'interface est un type,

PAS de bloc d instruction dans une interface
  
____________________________________________________________________
IVoiture voit = new Vehicule();
// !!!!!!!!!!!!!!!!!!!!!!!! c'est les paramètres de IVoiture qui font foi, et non ceux de Vehicule !!!!!!!!!!!!!!!!

// en gros on peut appliquer à tout ce qu'on veut une interface, on "gagne" un nouveau type à chaque fois qu'on l'implémente
> On crée une instance de Véhicule, mais on n'a accès qu'à ce que l'interface permet d'accéder.

// l'interface OVERRIDE le cas échéant.
_____________________________________________________________________  
  EXEMPLE : 

interface IVoiture 
{ 
  int Cylindree { get; set; }
}

---  
main()
{
  IVoiture voit = new Vehicule();
  //on crée une instance de véhicule
  // on n'a accès qu'à sa cylindrée
}