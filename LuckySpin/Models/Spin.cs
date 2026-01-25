using System;
using System.Linq;
using System.Security;
namespace LuckySpin.Models
{
    public class Spin
    {
        private Random random = new Random();
        private int[] numbers; //this is an instance variable to hold the spin numbers;

       //Constructor - notice how this assigns random values to the spin numbers
        public Spin()
        {
            numbers = new int[] { random.Next(10), random.Next(10), random.Next(10) };
        }

        //Spin Properties
        public int[] Numbers //Read only - the spin numbers are set in the constructor
        { 
            get { return numbers; }
        } 
     
        //Spin Method   
        public bool isWinning(Player player) //Read only - true if Player's Luck is one of the numbers
        {
            //NOTE: Talk with your partner to decipher the use of the ternary conditional operator in the code below
            //  https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            return (player == null) ?  false : numbers.Contains(player.Luck);
        }
    }

}
