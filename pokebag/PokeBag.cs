// Create a PokeBag class that can store multiple pokemons from different types. Create a function that adds a new pokemon by its type to the PokeBag.
// There are 3 kind of pomenons:
// - Pikachu, who sais “Pika-pika” and has 12 HP (health point)
// - Bubasaur, who sais “Bulba-saur” and has 10 HP
// - Charmander, who sais “Char-char” and has 10 HP
// Every pokemon has a random strength between 1 and 10.
// Pokemons can say their sound (see above) when their Speak method is called. The Speak method should return the pokemon’s sound.
// Add 5 pokemons to your PokeBag.
// Create a function that returns the pokemon with the highest strength. In case of equal strengths, it’s your choice which one to return.
// 
// Example:
// pokeBag.Add(“pikachu”);
// pokeBag.Add(“pikachu”);
// pokeBag.Add(“pikachu”);
// pokeBag.Add(“bulbasaur”);
// pokeBag.Add(“charmander”);
// 
// Console.WriteLine(pokeBag[0].Speak());
// This should print Pika-pika
// 
// var stongestPokemon = pokeBag.GetStrongest();
// Should return the pokemon with the highest strength value