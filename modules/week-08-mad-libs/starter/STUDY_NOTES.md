# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Zane Herold

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer:  I created the ReadNonEmptyString method which prompts the user for input and ensures that it is not empty. I also created the CollectWords method which collects the words from the user based on the prompts in the StoryTemplate. Finally, I created the GenerateStory method which takes the collected words and generates the final story using the template.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: It is helpful to move code out of Main and into helper methods because it makes the code more organized and easier to read. It also allows us to reuse code and reduces the chances of making mistakes in the logic.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: The StoryTemplate class is used to store the template for the story, which includes the text with placeholders for the words that will be filled in by the user. It allows us to separate the story structure from the section thats collecting the words.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Using a templete made it easier to support two different stories because we can simply create two different StoryTemplates with different text and prompts. The same logic for collecting words and generating the story can be reused for both templates.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer:In Impliment collet works after the user has input all the words and before the story is printed.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: It helped me find bugs because I was able to see exactly when the code lost a certain section like printing the story or where it was not working as expected.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: A bug I encountered was that the story was not printing after collecting the words. I fixed it by chekcign the seciton to see that I put in the wrong variable name for the stor template method.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. I learned how to break a program into smaller methods to make it more organized and easier to read.
2. I learned that break points are usefull for debugging quicker then guessing where the bug is.
3. I learned the use of using a template to separatge the story from other logic.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: Breaking into methods helped me understand program structure the most because it allowed me to see how different parts of the code work together and how they can be reused in the future.

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

- Planning structure (methods/classes): [2.5 hours]
- Input validation: [1 hours]
- Story templates + formatting: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: THe planning structure took the longest because I had to think about how to break the code into smaller methods and how to structure the StoryTemplate class along with the fact that i struggled to quickly understand eahc part of the program.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: I would allow some to make their own story template and have the program read it in and use it to generate a story.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: Breaking the program into smaller parts made debugging much easier because each method had a specific purpose and could be tested independently. So I could set breakpoints until the bug is resolved.
