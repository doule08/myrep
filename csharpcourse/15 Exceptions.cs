1) Intro :

> Par défaut, lorsqu une erreur survient, elle va remonter niveau par niveau jusqu à atteindre le point d entrée de l application.
> Il faut donc la capturer avant pour ne pas que le programme crash.
> Une telle erreur est appelée "Exception"
> TOUTES les exceptions différentes HERITENT de la classe "Exception"

-------------------------------------
2) Try Catch Finally :

> Si une exception est levée dans le bloc try, celui-ci s interrompt et envoie l erreur au bloc catch.
> Le bloc finally (optionnel) s exécute ensuite et est le plus souvent utilisé pour nettoyer les ressources.

> Plusieurs blocs catch peuvent être utilisés, chacun gérant un type d exception différent
> L exception va passer de catch en catch jusqu a trouver un compatible.
> Ainsi, il faudra mettre l exception de type Exception en dernier.
  
ex :  
try{
  int y = 10 / 0;
}
catch(DividedByZero dbzex){
  Console.WriteLine(ex.GetType()); // System.DivideByZeroException
  Console.WriteLine(ex.Message); // "Tentative de division par zéro."
}
catch(Exception ex){
  Console.WriteLine("Exception par defaut, pas une division par zero");
}
finally{
  Console.ReadLine();
}

---------------------------------------
3) throw :

> throw sert à signaler la présence d une exception :
	ex :
 		(p110)

> throw peut aussi renvoyer une exception qui pourra être réutilisée par la suite (ici d une méthode à une autre) :

main(){
  try{
    MaMethode();
  }
  catch (Exception ex){
    Console.WriteLine(ex.GetType);
  }
  
maMethode(){
  try{
    int j = 5 / 0;
  }
  catch(Exception xxx){
    throw xxx; // va renvoyer l'exception xxx dans main, qui va la renvoyer dans le catch sous le nom "ex"
  }  