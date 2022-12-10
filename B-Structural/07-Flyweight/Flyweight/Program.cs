using Flyweight;
// The intent of this pattern is to use sharing to support large number of 
//fine-grained objects efficiently.It does that by sharing parts of the state 
//between these objects instead of keeping all that state in all of the objects.
Console.Title = "Flyweight";

var aBunchOfCharacters = "abba";

var characterFactory = new CharacterFactory();

var characterObject = characterFactory.GetCharacter(aBunchOfCharacters[0]);

characterObject?.Draw("Arial", 12);
characterObject = characterFactory.GetCharacter(aBunchOfCharacters[1]);

characterObject?.Draw("Terbuchet MS", 14);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[2]);

characterObject?.Draw("Time New Roman", 16);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[3]);

characterObject?.Draw("Comic Sans", 18);

Console.ReadKey();
