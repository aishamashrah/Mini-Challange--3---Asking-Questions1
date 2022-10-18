//aisha mashrah 
//10/18/22
//asking the user to ask two questions and replay if they want to.
bool playAgain = true;
while(playAgain){

    


    Console.WriteLine("WHAT IS UR NAME? ");
    string name = Console.ReadLine();

    Console.WriteLine("WHAT TIME DID U WAKE UP? ");
    string time = Console.ReadLine();

    Console.WriteLine("YOUR NAME IS " + name + " & YOU WOKE UP AT " + time);

    Console.WriteLine(" ");
        Console.WriteLine("Would you like to play again? Yes or No");
        string rePlay = Console.ReadLine();
        if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
            playAgain = true;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
        } 
        if(rePlay == "NO" || rePlay == "no"){
            playAgain = false;
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
      } 
}

