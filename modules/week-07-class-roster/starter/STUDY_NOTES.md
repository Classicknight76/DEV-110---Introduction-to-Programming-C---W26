# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:Zane Herold**

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: the parallel arrays are two separate arrays that are used together to store related information. In this assignment, I used one array called rosterNames to store the names of the students and another array called rosterCredits to store the number of credits each student is taking. The index of each student's name in rosterNames corresponds to the same index in rosterCredits, so if a student is at index 0 in rosterNames, their credits will be at index 0 in rosterCredits.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: The purpose of the count variable is to keep track of how many students have been added to the roster. It tells us how many slots in the parallel arrays are currently being used to store student information. When we add a student, we store their name and credits at the index specified by count, and then we increment count. This way, count always reflects the number of students in the roster, and we can use it to loop through only the occupied array.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: I used count to make sure i knew if the roster had any students in it and I also use it to make sure i do not exceed class capacity when adding names and scores.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: I printed the class roster using a for loop to build an array of roster lines where each line contains the student's name and credits. Then I used a foreach loop to shift through the array of roster lines and print each line to the console.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: I was able to sort the roster by copying only the used portion of the original arrays into new arrays, and then using array.sort on the new arrays. This ensures that the names and credits stay aligned because they are in parallel arrays.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. I learned the benefits of parallel arrays when storing lots of differentiating data.
2. I learned how to use a count variable to track how many elements are in use in an array.
3. I learned how to build and print arrays of strings.
4. -
5. -

**Which loop felt most natural to use and why?**

Answer: I felt most comfortable using the for loop because I am used to using it for iterating through arrays and it allows me to easily access elements by index. The foreach loop was a bit less intuitive for me, especially when I had to build an array of roster lines, but I can see how it is useful.

## Time Spent

**Total time:** [5.5 hours]

**Breakdown:**

- Planning the arrays/menu: [1 hours]
- Input validation: [1 hours]
- Add + print roster features: [1.5 hours]
- Sorting feature: [1 hours]
- Testing and debugging: [0.5 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: makign the print roster feature took the longest because I had to figure out how to build an array of strings that contained both the name and credits for each student, and then I had to use a foreach loop to print each line of the roster. I still am not too good with foreach loops.

## Reflection

**What would you do differently next time?**

Answer: Next time, I would try to implement the sorting feature earlier in the process, so that I could test it more thoroughly as I build the rest of the features. I also would like to practice using foreach loops more, as I found them a bit tricky to use in this assignment.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: Using for and foreach loops helped me understand how to iterate through arrays in different ways. The for loop allowed me to access array elements by index, which was useful for building the roster lines and copying the used portion of the arrays.
