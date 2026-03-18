# Week 10: Habit Tracker (File I/O) — Study Notes

**Name: Zane Herold**

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: The File.ReadAllLines method returns an array of strings, where each string represents a line from the file. I used it to read all the lines from the CSV file and then processed each line to create the Habit objects.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: If you try to split an empty string on ',', you would get an array with a single empty string element. This could lead to errors when trying to access specific indices of the array, as there would be no actual data to work with. Skipping blank lines prevents these kinds of errors.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: The File.WriteAllLines writes all the lines to a file at once. It takes two arguments: the first is the path to the file where the lines should be written, and the second is an array of strings that represents the lines to be written in the file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: select(...).ToArray() in saveHabits is used to transform the list of Habit objects into an array of strings that can be written to the file. The Select method is used to project each Habit object into a string representation and then ToArray() converts the resulting in a string array that can be passed to File.WriteAllLines.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: FileNotFoundException is an exception that occurs when an attempt is made to access a file that does not exist at the specified path. This can happen when trying to read from a file that has been moved.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: we catch FileNotFoundException specifically because it allows us to handle that particular error case in a more targeted way. If we were to catch all exceptions using catch (Exception), we might inadvertently catch other types of exceptions that we did not intend to handle.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. I learned how to read from and write to files using File.ReadAllLines and File.WriteAllLines.
2. I learned how to handle exceptions, specifically FileNotFoundException, when working with file I/O operations.
3. I worked with LINQ methods to analyze and summarize data in a list.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: The trickiest part of this assignment was implementing the AddHabit and UpdateHabit methods. I had to make sure that when adding a new habit, it was correctly added to the list of habits without overwriting existing ones. For updating habits, I had to ensure that the correct habit was identified and updated without losing any of the existing data.

## Time Spent

**Total time:** 4.25 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 0.5 hours
- Implementing LoadHabits: 0.5 hours
- Implementing PrintHabits / PrintSummary: 1 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1.5 hours
- Testing and debugging: 0.25 hours
- Writing study notes: 0.5 hours

**Most time-consuming part:**

Answer: The most time consuming part was implementing the AddHabit and UpdateHabit methods, as I had to make sure that the new habits were correctly added to the list and that the existing habits were updated without losing anything.
