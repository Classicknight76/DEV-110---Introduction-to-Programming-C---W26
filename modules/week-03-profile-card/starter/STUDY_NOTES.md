# Week 3: Personal Profile Card - Study Notes

**Name: Zane Herold**

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer:int is used to store whole numbers, such as age and graduation year. double is used for decimal numbers, like GPA and height in inches. string is used for text data, such as name and major. bool is used for true/false values, like whether the student is full-time or part-time.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: GPA often uses decimals for numbers like 3.75, so using double allows for that precision, whereas int would only store whole numbers.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I used, answer.ToLower() == "yes", to convert the string input to a boolean value. This checks if the user entered "yes" (case-insensitive) and returns true, otherwise false.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I grouped personal information like name, age, and height together because they relate to the individual's identity. Academic information like major, GPA, and graduation year were grouped separately as they pertain to the student's educational background.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: I calculated birth year from age, years to graduation from graduation year, height in feet and inches from total height in inches, honor status from GPA, and age in months from age.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: Calculating birth year from age ensures consistency because if the user enters an incorrect birth year or age that doesn't match, the system will still be accurate. It also reduces redundant input by only asking for one piece of information (age) instead of both (age and birth year).

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: The hardest part was formatting the output to be well organizing

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I looked at what you had put at the beginning and end of the code as the style format and I tried to mimic it.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: The most confusin part was plugging in all the variables into the final output section.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: I used int.Parse() to convert string input to an integer and double.Parse() to convert string input to a double.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: I calculated feet by dividing the total inches by 12 using integer division, and the remaining inches using the modulus operator (%), which gives the remainder after division.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: I used a boolean comparison where gpa >= 3.5 evaluates to true if the GPA is 3.5 or higher, indicating an honor student.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer:The :F2 format specifier tells the computer to display a double value with exactly 2 decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer:I

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used section headers to separate personal and academic information, added borders using dashes for visual separation, and aligned the text neatly.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer:I could add time to birthday by calculating the difference between the current date and the user's next birthday.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer:Chosing the right data type is important because it ensures that the data is stored efficiently, maintains precision for calculations, and prevents errors by enforcing type safety.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: This profile card relates to real-world applications like social media profiles where users enter personal and academic details, job applications where applicants provide educational and professional background.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1.The importance of double checkign variable names
2.I became better at writting variable names
3.I realized usign lines to make boorders and boxes is cool
4.-
5.-

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: bool was the most challenging because converting user input from strings to boolean values requireS A DIFFENT LINE OF CODE TO DO EFFICENTLY.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Understanding data types helps me write better programs by ensuring that I use the most appropriate type for each piece of data, which reduces errors and improves code efficency.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: I tested with a variety of ages (18, 30), GPAs (2.5, 4.0), and heights (60 inches, 75 inches) to ensure calculations for birth year, honor status, and height conversion were accurate. and since they had a large enough gap between them to test for the far extreems.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: I had errors with defining the types and as i converted them from string to int and double. I fixed these by ensuring I used the correct Parse methods for each data type.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I validated the data types by testing various inputs and checking the output to ensure that calculations like GPA formatting, height conversion, and age calculations produced the expected results without errors.

## Time Spent

**Total time:** [3.3 hours]

**Breakdown:**

- Understanding data types and planning variables: [0.5 hours]
- Collecting user input with correct types: [0.3 hours]
- Implementing calculations: [0.3 hours]
- Formatting output: [0.2 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:  testing and debugging took the longest because I had to ensure all calculations were accurate and that the output was formatted correctly, which required multiple iterations.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: I would learn better ways to make compact code like perhapps combining questions or using functions so multiple accoutns can be created atonce.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Proper data managing makes programs easier to maintain by improving readability, and ensuring consistent data representation, and reducing the likelihood chance of errors through appropriate type usage.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: I would like to make a comblex game character or a shopping cart system next.
