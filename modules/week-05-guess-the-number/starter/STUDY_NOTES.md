# Week 5: Guess the Number - Study Notes

**Name: Zane Herold**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: They are different because a do-while loop runs the code before checking any variables and is best used when you want to ensure the code runs at least once. while a while loop checks the variables before running the code and is best used when you want to check conditions first.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: The use of a do-while loop is in the input validation for the max value and rounds. This is because we want the user to be given the prompt at least once and until they enter a valid input..

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used a while loop to keep asking the user for guesses until they guess the correct number. This is because we don't know how many guesses it will take for the user to find the correct number, so a while loop allows us to continue looping until the condition (guess != secret) is no longer true.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used a for loop to repeat the game for each round. This is because we know the number of rounds in advance, so a for loop is ideal for iterating over a known range of values (1 to rounds).

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: I created a helper method for input validation so I could reuse it instead of repeating code to verify certain inputs.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: To make sure the max value was between 10 and 100, I used a do-while loop that checks if the input is less than 10 or greater than 100. If the input is outside this range, I prompt the user to enter a valid max value until they provide a valid input.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: I made sure the number of rounds was between 1 and 3 by using a while loop that checks if the input is less than 1 or greater than 3. If the input is outside this range, I prompt the user to enter a valid number of rounds until they provide a valid input.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: I handled invalid input by using int.TryParse, which attempts to convert the input string to an integer. If the conversion fails (e.g., if the user enters a non-number), TryParse returns false, and I can prompt the user to enter a valid number again.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: To compare the guess to the secret number, I used an if/else statement. If the guess is less than the secret number, I print "Too low! Try again." If the guess is greater than the secret number, I print "Too high! Try again." If the guess is equal to the secret number, I print "Correct! You got it in X guesses."

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: Imade a guesscount variable that I set to 0 before starting the main part of the loop. Then, each time the user makes a guess, I up the guesscount variable by 1.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: I made the secret number usin  int secret = random.Next(1, maxValue + 1); This uses the Random class to generate a number between 1 and its max value. The Next method takes a minimum value and a maximum value so by adding 1 to the max value, we ensure that the max value is included in the outcomes.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: Random.Next generates a random number that is greater than or equal to the minimum value and less than the maximum value. By adding 1 to the max value,we make sure that the max value is included in the range since computers count form 0 so 1 is 0 and max is max-1, so we need to add 1 to include the max value in the possible outcomes.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I put in a max value of 20 and rounds of 2. Then after round 1, I put in a low guess and it said guess was too low, then a very high guess and it said too high, then I narrowed it down and when I got the correct one it said correct and how many guesses it took.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: I encountered where the user was not prompted to enetr a vlaid number if they entered an invlaid one. I fixed this by noticign the do while i was intended to add to the bottem of the method and i had never conmpleted it.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. I learned how to apply for and while loops to make a multi-round guessing game
2. I learned how to use helper methods and how they appear differently in C# than other languages I have used.
3. I learned how to use the Random class to generate random numbers in a specific range in C#.
4. -
5. -

**Which loop felt most natural to use and why?**

Answer: The while loop felt the most natural because it was straight forward to use it was as this happens do this until this condition is met or lost.

## Time Spent

**Total time:** [4.5 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [0.5 hours]
- Guessing logic: [2 hours]
- Testing and debugging: [0.5 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Settign up the guessing logic took the longest because I had to make sure all the conditions were correct and that the user was prompted correctly for each guess. I was worried that i had done soemthign wrong and only 1 round would trigger.

## Reflection

**What would you do differently next time?**

Answer: I woud like to make a helper function for setup and the forloop so then i can addapt it and maybe in the future make new modes like limited guess mode.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using the 3 loops helped me understand when to use each one and how they can be used together in a program. It also helped me see the benefits some loops show over others in certain situations.
