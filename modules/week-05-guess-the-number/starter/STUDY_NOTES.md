# Week 5: Guess the Number - Study Notes

**Name: Zane Herold**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: They are different because a do-while loop runs the code before checking any variables and is best used when you want to ensure the code runs at least once. while a while loop checks the variables before running the code and is best used when you want to check conditions first.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer:

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used a while loop to keep asking the user for guesses until they guess the correct number. This is because we don't know how many guesses it will take for the user to find the correct number, so a while loop allows us to continue looping until the condition (guess != secret) is no longer true.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used a for loop to repeat the game for each round. This is because we know the number of rounds in advance, so a for loop is ideal for iterating over a known range of values (1 to rounds).

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: I created a helper method for input validation

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer:

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: I made sure the number of rounds was between 1 and 3 by using a while loop that checks if the input is less than 1 or greater than 3. If the input is outside this range, I prompt the user to enter a valid number of rounds until they provide a valid input.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer:

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer:

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

Answer:

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer:

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.
2.
3.
4.
5.

**Which loop felt most natural to use and why?**

Answer:

## Time Spent

**Total time:** [X hours]

**Breakdown:**

- Planning the loops: [X hours]
- Input validation: [X hours]
- Guessing logic: [X hours]
- Testing and debugging: [X hours]
- Writing documentation: [X hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:

## Reflection

**What would you do differently next time?**

Answer:

**How did using three different loop types improve your understanding of repetition?**

Answer:
