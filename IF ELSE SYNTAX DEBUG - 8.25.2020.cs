
// Problem : Debug CheckAlive() method to return true is health of player is above zero or false if below zero




public class Player
{
  private int health = 100;
  public int Health
  {
    get
    {
      return this.health;
    }
    set
    {
      health = value;
    }
  }
  
  public Player()
  {
    
  }
  

// ORIGINAL CODE
// FIXME: This method won't compile for some reason! :(
//   public bool CheckAlive()
//   {
//     if
//     this.Health < 0
//     {
//       return false
//     }
//     else if
//     this.Health > 0
//     {
//       return true
//     }
//   }


  public bool CheckAlive()
  {
    if(this.Health <= 0) 
    {
      return false;
    }
    else
    {
      return true;
    }
  }
}