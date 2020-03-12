//= faire passer un objet comme un tableau

public class Class
{
  private Dictionary<string, Student> _Students = new Dictionary<string, Student>();
  
  public Student this[string name]		// => INDEXEUR
  {
   	get => this._Students[name];
    set => this._Student.Add(name,value);
  }
  //= propriété qui permet d'accéder ou de supprimer 
  
  public Student this[int id]	//this = instance courante 
  {
    get{
      Student std;
      int i =0;
      foreach (KeyValuePair<string, Student> item in this._Students)
      {
       	if (i == id)
        {
          std= item.value;
      	}
        i++
      }
      return std;
    }

}