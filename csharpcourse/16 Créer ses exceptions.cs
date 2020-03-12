> UNE seule règle : l exception (class) créée doit hériter de la classe Exception
 ex:

main(){
  //1) on teste le code
  try{
    throw new MonException("MaVariable"); // lance une nouvelle exception de type MonException contenant "MaVariable" comme param
  }
  //2) on écrit le code en cas d'erreur
  catch(Exception ex){
    Console.WriteLine(ex.GetType()); // MonNameSpace.MonException
    Console.WriteLine(ex.Message); // Exemple de MonException
  }
}

public class MonException : Exception{
  public string MaVariable { get; set; }
  
  public MonException (string MaVariable) : this(MaVariable, "Exemple de MonException"){ // ctor appelé, il appelle le 2eme ctor (this)
  }
  
  public MonException (string MaVariable, string Message) : base(Message){ // ctor appelé par le 1er, il appelle le ctor de Exception
    this.MaVariable = MaVariable;
  }
}