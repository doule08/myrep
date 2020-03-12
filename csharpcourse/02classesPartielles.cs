//fichier1
namespace Namespace
{
  public partial class Personne
  {
    public string Name {get; set;}
    public int Age {get; set;}
    ___________________
//fichier 2
    
namespace Namespace	//meme namespace
{
   public partial class Personne
   {
     public void sayHello()
     {
       CW("Hello world");
     }
     ____________________________
//main
Personne p = new Personne();	// l'objet Personne possède le contenu des 2 partial class
p.Name;
p.Age;
p.sayHello();
     
     // ça sert à METTRE A JOUR les classes via un autre fichier sans avoir à tout refaire 