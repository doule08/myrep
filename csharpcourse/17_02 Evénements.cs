> Signale à son environnement que quelque chose s est produit
> Un événement est typé par un délégué

> SEULE LA CLASSE qui a déclaré l event  peut le déclencher (même pas les enfants)
> Mot clé event pour déclarer.
 
1) prototype du type de délégué dans namespace :
	delegate void ValueChangedEventHandler(object sender, int value);

2) déclaration de l événement dans la class :
class MaClasse
{
  public event ValueChangedEventHandler ValueChanged = null ; // déclaration de l'event avec valeur null
  private int _X;
  
  public int X
  {
    get { return _X; }
    set
    {
      if (_X != value)
      {
        _X = value;
        ValueChanged(this, value); //  déclenchement de l'event avec les paramètres
      }
    }
  }
}

----------------------------------------
Evenements et héritage :
	> SEULE la classe qui déclare l event peut le déclencher, et ce même s il est public !!!
  	> Pour utiliser un event chez un enfant, il faut créer une méthode protected chez le parent déclarant l event.
    > Il suffira  d appeler cette méthode chez l enfant pour déclencher l evenement.
      
Ex :
	namespace cours
    {
      delegate void Hitted(int damage); // prototype délégué event
      
      class Character
      {
      	public event Hitted hit = null; // déclaration de l'event dans la classe parent.
        
        protected void GetHit(int damage) // déclaration méthode protected qui déclenche l'event
        {
          hitted(damage); // déclenchement event
        }
      }
      
      class Pokemon : Character
      {
      	private void Attack(Character opponent)
        {        	        	
        	if(opponent is Pokemon)
            {
            	Pokemon pkmn = (Pokemon)opponent;
            	int damage = 4;
                pkmn.GetHit(damage); // appel méthode parent qui va déclencher l'évènement.
            }       		
		}
      }
	}