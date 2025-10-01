﻿// See https://aka.ms/new-console-template for more information
string secret="hydrochlorid";

Console.WriteLine(secret);


// --helper 
bool[] guesses = new bool['z'-'a']; // false -> has not been guessed

// helpers

int char2int (char c) {
  return c-'a';
}

char int2char (int i) {
  return (char)(((int)'a')+i);
}

void print_status () {
  // guesses
  Console.Write("Guesses: ");
  for (int i=0 ; i<guesses.Length ; i++) {
    if (guesses[i]) {
      Console.Write(int2char(i));
    }
  }
  Console.WriteLine("");
}






while (true) {
  print_status();
  Console.WriteLine("Give us a guess: ");
  string? input = Console.ReadLine();
  if (input==null || input.Length!=1) {
    Console.WriteLine("Error: Input should be 1 long");
    continue;
  }
  char c = Char.ToLower(input[0]);
  Console.WriteLine(c);
  guesses[char2int(c)]=true;

}
