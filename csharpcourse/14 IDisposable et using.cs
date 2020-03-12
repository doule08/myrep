1) IDisposable et Dispose() :

> Chaque objet consomme de la mémoire, pour forcer la destruction d un objet, on peut utiliser l interface IDisposable, qui nous imposera l utilisation de Dispose() et d implémenter le code de libération de ressource.
 
> Lorsque nous n’utilisons plus l’objet, il nous suffit d’appeler cette méthode afin de rendre cet objet ‘ collectable ’ par le « garbage collector ».
  
> A n utiliser seulement sur les objets "non managés" (ex: fichiers et flux ouverts)
  
----------------------------------------
2) using :

> Afin d utiliser Dispose() de manière automatique, on peut écrire le code dans un bloc "using", ce qui nous permet de déclarer une variable de type IDisposable, qui ne sera accéssible que dans ledit bloc. 

> Une fois le bloc terminé, la méthode Dispose() est appelée automatiquement.
  
> ex :
using (TextWriter tw = File.CreateText("Exemple.txt"))
{
  tw.WriteLine("Ca marche");
}