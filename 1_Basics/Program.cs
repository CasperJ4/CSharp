#region 
//The "#region" can be used to 'collapse' areas of code so you can focus on the key areas
//Comments can be done in a couple different ways, after // and multiline between /* comment */
/*
multi
line
comment
*/

//All of these functionalities is for the programmers, the compiler deletes them when creating the executable (.exe)
//Programmers can use them to document their code and help future programmers understand their thinking.
#endregion

#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion

#region Variables
Console.WriteLine("To start playing, press a key.");
Console.ReadLine();

BeginGame:
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("------------------------------------");
Console.WriteLine("You see before you a forest. Do you want to head in?");
Console.WriteLine("(Type \"yes\" or \"no\")");

string answer = Console.ReadLine();

bool EnterForest = false;
if(answer == "yes"){
    EnterForest = true;
}

if(EnterForest == false){
Console.WriteLine("------------------------------------");
Console.WriteLine("Since you don't wish to enter the forest, the game cannot begin. Shutting down...");
Console.ReadLine();
}

if(EnterForest == true){
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Upon entering, you find yourself on an old gravel path. Which direction do you head in?\n \nA: Right\nB: Left");
    }

    string answer2 = Console.ReadLine();

    //left = b | right = a
    bool Direction = false;
    if(answer2 == "a"){
        Direction = true;
    }
    if(answer2 == "b"){
        Direction = false;
    }

//Direction: right
if(Direction == true){
    CottageChoice:
    Console.WriteLine("------------------------------------");
    Console.WriteLine("The path leads you to a cottage built of wood and stone. You hear two voices coming from the inside.\n \nA: Sneak around the house and try to listen in on their conversation.\nB: Approach the door and knock.");
    
    string answerCottage = Console.ReadLine();
    if(answerCottage == "b"){
        Console.WriteLine("To be continued...");
        Console.ReadLine();
    }

    if(answerCottage == "a"){
        Console.WriteLine("------------------------------------");
        Console.WriteLine("As you circle around the house, you notice a round hole in the wooden wall. By pressing your ear up against it, you're able to overhear their conversation.");
        Console.ReadLine();
        Console.WriteLine("Their voices are subdued, the two men whispering to one another. \"The plan begins any moment now. Are you ready?\"");
        Console.WriteLine("\"I think so,\" the other responds.");
        Console.WriteLine("Just as he gives his answer, the wall gives in and you crash into the house, planks of wood joining you in your fall.");
        Console.WriteLine("A: Look up and check your surroundings.");
        Console.ReadLine();
        Console.WriteLine("Gazing up, you see one of the men. He's giving you a nasty grin, and this grin is the last thing you see: soon after, he pulls out a knife..."); 
        //Death
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("You have perished.");
        Console.WriteLine("If you wish to challenge your fate, type \"a\". If, however, you would prefer to stop playing, write something else.");
        string choiceDeath = Console.ReadLine();
    
        if(choiceDeath == "a"){
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            goto BeginGame; 
        }
        else{
            Console.Read();
        }
}

//Direction: left
if(Direction == false){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("------------------------------------");
    Console.WriteLine("As you walk down the path, you stumble and fall into a deep hole. Slowly, your vision degrades...");
    bool EndGame = true;

    //Runs when the player dies
    if(EndGame == true){
    Console.WriteLine(".");
    Thread.Sleep(1000);
    Console.WriteLine(".");
    Thread.Sleep(1000);
    Console.WriteLine(".");
    Thread.Sleep(1000);
    Console.WriteLine(".");
    Thread.Sleep(1000);
    Console.WriteLine("You have perished.");
    Console.WriteLine("If you wish to challenge your fate, type \"a\". If, however, you would prefer to stop playing, write something else.");
    string choiceDeath = Console.ReadLine();
    
    if(choiceDeath == "a"){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        goto BeginGame; 
    }
    else{
        Console.Read();
    }
}
}








#endregion