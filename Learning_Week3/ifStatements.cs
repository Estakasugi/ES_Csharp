Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total_roll = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total_roll}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    Console.WriteLine("You doubles");
    total_roll += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) {
    Console.WriteLine("triple");
    total_roll += 6;
}

if (total_roll >= 15) {
    Console.WriteLine("You win!");
}

if (total_roll < 15) {
    Console.WriteLine("You lose!");
}

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine("" + result);

// if (message.Contains("dog")) {
//     Console.WriteLine("WWhat does the fox say?");
//}

