A simple coding challenge I challenged myself with. 

Task 1
Create a function which counts the number of occurrences of a given letter in a string.

Example:

Input:

'e' and "I have some cheese"
Output:
5
Task 2
Create a function which decides if a string is a palindrome.

Examples:

Input:

I have some cheese
Output:
False
Input:

God saved Eva’s dog
Output:
True
Task 3
Part A)
Create a function which counts the number of occurrences of words from a "censored words list" in a text.

Example:

Input:

{"dog", "cat", "large"} and "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse."
Output:
cat: 1, dog: 2, large: 1, total: 4
Part B)
Create a way to censor words featured in the "censored words list" that appear in the text.

Example:

Input:

{"meow", "woof"} and "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse."
Output:
"I have a cat named M$$w and a dog name W$$f. I love the dog a lot. He is larger than a small horse."
Part C)
Create a way to censor a single word palindrome in a text.

Example:

Input:

"Anna went to vote in the election to fulfil her civic duty"
Output:
"A$$a went to vote in the election to fulfil her c$$$c duty"
Part D - BONUS)
Come up with at least 3 different ways to provide the "censored words list" to the application. This task does not require coding, please send us 3 bullet points on how you would do this.


Answer to question 3D:

1. One way to supply the app with a list is to load it from local or remote database;
2. Another way is to get the list from a post/get request via user interaction.
3. One could also store the list in a file. 
