# Week 6: Text Menu App - Study Notes

**Name: Zane Herold**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A do-while loop is different from a while loop becaus eit runs a code block atleast once before checking the condition, making it superior for inpt validation where you want to do soemthign once and then check if it passed. A while loop checks the condition before running the code block.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: I used a do-while loop to validate the menu choice and numeric inputs because I wanted to ensure that the user is prompted at least once and continues to be prompted until they provide valid input. This way, I can handle cases where the user might enter invalid data (like non-numeric input or numbers outside the expected range) without crashing the program.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used a while loop for the main menu loop that keeps the program running until the user chooses to exit. This is because we want to continuously display the menu and allow the user to select different options until they decide to quit, which makes a while loop ideal for this purpose.

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer:I didn't use a for loop because I did not need to repeat the same thing ove rand over when the while loop runs it and because peoplemay go back to previous option again which for loops dont make as easy.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: I created a helper method so then I don't have to repeat the same validation logic for each input prompt.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I validated the menu choice by using a do-while loop that checks if the input is a valid integer and falls within the range of 1 to 6. If the input is invalid, I prompt the user to enter a valid menu choice until they provide one.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I handled invalid input by using int.TryParse and double.TryParse, which attempt to convert the input string to the desired numeric type. If the conversion fails the methods return false, allowing me to prompt the user to enter valid input again without crashing the program.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used the strign methods Trim, Tpupper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight. For case 1 T used Trim and to upper to make sure it formats correctly in the output. for case 2 I used Trim Toupper tolower to format the output into the required style. For case 3 I used trim, Tolower, Contains, Replace, Split, join. For case 5 I used toupper, padleft, padright. For case 6 I use equals, substring, endswith,indexof.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: I demostraited the Equals, the substring, The endswith, and the indexof methods. I used Equals with StringComparison to check if the input string is equal to "goodbye". I used Substring to get the first three characters of the input string. I used EndsWith to check if the input string ends with an exclamation mark. Finally, I used IndexOf to find the position of the first space character in the input string.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: The differance is that string concatenation uses the + operator to combine strings, while string interpolation allows you to embed expressions directly within a string using the $ symbol and curly braces. I used string concatenation in some cases where I was simply combining a few strings together, but I prefer string interpolation becasue it is easier to read and its parts can be interchangeable easier than concatenation.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. I continued to work with loops to get better at them and understand when to use each type.
2. I learned how to make inputs have less human error buy using methods like Tolower and upper.
3. I learned how to make consistant borders for outputs.
4. -
5. -

**Which loop felt most natural to use and why?**

Answer: the while loop felt the most naturtal because it is straight forward and is just a check a condition over and over again. Its just like a reacurring if statement which is what I am used to.

## Time Spent

**Total time:** [5.5 hours]

**Breakdown:**

- Planning the loops: [0.5 hours]
- Input validation: [1.5 hours]
- String formatting: [1 hour]
- Testing and debugging: [2 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The input validation because I kept of misstyping or forgetting small things but I am happy I finally finished it.

## Reflection

**What would you do differently next time?**

Answer: Next time I would do the rest of the code that is not dependent of the input validationj so i dont have to stop and figure it out as early as I did this time.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using three different loop types helped me understand that there are different ways to repeat code based on the senerio presented. The while loop is great for when you want to repeat something until a certain condition is met, the do-while loop is useful when you want to ensure that the code runs at least once, and the for loop is ideal for when you know how many times you want to repeat something.
