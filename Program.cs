using System;

namespace ExquisiteCorpse
{
  class Program
  {
    // Genereates new corpse with random combinations of body parts.
    static void Main(string[] args)
    {
      Console.WriteLine("\nHello! Welcome to Exquisite Corpse builder! Would you like to assemble a random corpse, or build a custom one? Type RANDOM or CUSTOM:\n");
      string modeChoice = Console.ReadLine();
      modeChoice = modeChoice.ToUpper();

      if (modeChoice == "RANDOM")
      {
        Console.WriteLine("\nHere's your random corpse!\n");
        RandomMode();
      }
      else if (modeChoice == "CUSTOM")
      {
        Console.WriteLine("\nSelect custom head. Type GHOST, MONSTER, or BUG:\n");
        string head = Console.ReadLine();
        head = head.ToUpper();
        Console.WriteLine("\nExcellent! Now select custom body. Type GHOST, MONSTER, or BUG:\n");
        string body = Console.ReadLine();
        body = body.ToUpper();
        Console.WriteLine("\nGreat! Finally, select custom feet. Type GHOST, MONSTER, or BUG:\n");
        string feet = Console.ReadLine();
        feet = feet.ToUpper();

        Console.WriteLine($"\nYour selection...\nhead: {head}\nbody: {body}\nfeet: {feet}\nAnd here's your creature!\n");

        BuildACreature(head, body, feet);
      }
      else
      {
        Console.WriteLine("\nInvalid input! Check your spelling.");
      }
    }

    //Creates random corpse based on random numbers 1-3.
    static void RandomMode()
    {
      Random randomNumber = new Random();
      BuildACreature(SwitchForType(randomNumber.Next(1, 4)), SwitchForType(randomNumber.Next(1, 4)), SwitchForType(randomNumber.Next(1, 4)));
    }

    // Switches random integer for a the type of creature.
    static string SwitchForType(int number)
    {
      switch (number)
      {
        case 1:
          return "ghost";
        case 2:
          return "monster";
        case 3:
          return "bug";
        default:
          return "ghost";
      }
    }
    // Assembles a corpse based on provided arguments.
    static void BuildACreature(string head, string body, string feet)
    {
      head = head.ToLower();
      switch (head)
      {
        case "ghost":
          GhostHead();
          break;
        case "bug":
          BugHead();
          break;
        case "monster":
          MonsterHead();
          break;
        default:
          Console.WriteLine("\nInvalid 'head' input!");
          break;
      }

      body = body.ToLower();
      switch (body)
      {
        case "ghost":
          GhostBody();
          break;
        case "bug":
          BugBody();
          break;
        case "monster":
          MonsterBody();
          break;
        default:
          Console.WriteLine("\nInvalid 'body' input!");
          break;
      }

      feet = feet.ToLower();
      switch (feet)
      {
        case "ghost":
          GhostFeet();
          break;
        case "bug":
          BugFeet();
          break;
        case "monster":
          MonsterFeet();
          break;
        default:
          Console.WriteLine("\nInvalid 'feet' input!");
          break;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }
    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }
    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }
    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }
    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }
    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }
    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }
    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }
    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
