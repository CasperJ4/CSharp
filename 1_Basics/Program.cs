Console.WriteLine("To start playing, press a key.");
Console.ReadLine();

BeginGame:
Console.ForegroundColor = ConsoleColor.White;
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
    Console.WriteLine("Upon entering, you find yourself on an old gravel path. Which direction do you head in?\n");
    List<string> choiceDir = new List<string>();
    choiceDir.Add("A: Right");
    choiceDir.Add("B: Left");

    choiceDir.ForEach(i => Console.Write("{0}\n", i));
    }
    
    string answer2 = Console.ReadLine();

    //left = b | right = a
    bool Direction = false;
    if(answer2 == "a" | answer2 == "A"){
        Direction = true;
    }
    if(answer2 == "b" | answer2 == "B"){
        Direction = false;
    }

//Direction: left
if(Direction == false){
    Console.WriteLine("Test");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("------------------------------------");
    Console.WriteLine("As you walk down the path, you stumble and fall into a deep hole. Slowly, your vision degrades...");
    Console.ReadLine();
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

//Direction: right
if(Direction == true){
    Console.WriteLine("------------------------------------");
    Console.WriteLine("The path leads you to a cottage built of wood and stone. You hear two voices coming from the inside.\n \nA: Sneak around the house and try to listen in on their conversation.\nB: Approach the door and knock.");

    string answerCottage = Console.ReadLine();

#region Option: head for the door
    if(answerCottage == "b"){
        Console.WriteLine("You knock on the door three times: first carefully, then with full force.");
        Console.WriteLine("On the third knock, the door opens and a man comes lunging out.");
        Console.WriteLine("In his hand, you spot a knife. He's heading straight for you.");
        Console.ReadLine();
        Console.WriteLine("If you're quick, you might be able to dodge his attack. Pick a direction to jump in:");
        Console.WriteLine("----D-----");
        Console.WriteLine("1 - 2 - 3");
        Console.WriteLine("4 - O - 5");
        Console.WriteLine("6 - 7 - 8");
        
        int DodgeChoice = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine(DodgeChoice);

        Console.WriteLine("You wait for the right time to dodge...");
        List<int> numbers = new List<int>();
        int counter = 0;
        while(counter < 6){
            Console.WriteLine(counter);
            Thread.Sleep(700);
            numbers.Add(counter);
            counter++;
        }
        Console.WriteLine("NOW!");
        Console.ReadLine();

        
        if(DodgeChoice == 4 || DodgeChoice == 5 || DodgeChoice == 6 || DodgeChoice == 8){
            Console.WriteLine("------------------------------------");
            Console.WriteLine("You successfully dodge his attack and manage to escape.\nHeading back down the trail and out the forest, you feel a sense of relief.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You have beaten the game. Congratulations!");
            Console.ReadKey();
        }
        else if(DodgeChoice == 2 || DodgeChoice == 1 || DodgeChoice == 3){
            Console.WriteLine("------------------------------------");
            Console.WriteLine("As you propel yourself forward, you crash right into the man.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Soon, you fall down on the ground along with him. You register a stinging\npain \u2014 a pain caused by the knife now embedded in your stomach.");
            Console.ReadKey();
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
        }}
        else{
            Console.WriteLine("------------------------------------");
            Console.WriteLine("You manage to dodge his grasp but stumble to the ground.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You're just about to get up when you feel the knife pierce your skin...");
            Console.ReadKey();
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
}
#endregion
        
#region Option: Circle around the house
    if(answerCottage == "a"){
        Console.WriteLine("------------------------------------");
        Console.WriteLine("As you circle around the house, you notice a round hole in the wooden wall. By pressing your ear up against it, \nyou're able to overhear their conversation.");
        Console.ReadLine();
        Console.WriteLine("Their voices are subdued, the two men whispering to one another. \"The plan begins any moment now. Are you ready?\"");
        Console.WriteLine("\"I think so,\" the other responds.\n");
        Console.WriteLine("Just as he gives his answer, the wall gives in and you crash into the house, planks of wood joining you in your fall.");
        Console.WriteLine("A: Look up and check your surroundings.");
        Console.ReadLine();
        Console.WriteLine("------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Gazing up, you see one of the men. He's giving you a nasty grin, and this grin is the last thing you see.");
        Console.WriteLine("Soon after, he pulls out a knife...");
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
}}
#endregion