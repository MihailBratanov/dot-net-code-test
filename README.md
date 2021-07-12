A simple coding challenge I challenged myself with. 

---

### Task 1

Create a function which counts the number of occurrences of a given letter in a string.

Example:

Input: <pre>'e' and "I have some cheese"</pre>
Output: <pre>**5**</pre>

---

### Task 2

Create a function which decides if a string is a palindrome.

Examples:

Input: <pre>I have some cheese</pre>
Output: <pre>**False**</pre>

Input: <pre>God saved Eva’s dog</pre>
Output: <pre>**True**</pre>

---

### Task 3

#### Part A)

Create a function which counts the number of occurrences of words from a "censored words list" in a text.

Example:

Input: <pre>{"dog", "cat", "large"} and "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse."</pre>
Output: <pre>**cat: 1, dog: 2, large: 1, total: 4**</pre>

#### Part B)

Create a way to censor words featured in the "censored words list" that appear in the text.

Example:

Input: <pre>{"meow", "woof"} and "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse."</pre>
Output: <pre>**"I have a cat named M$$w and a dog name W$$f. I love the dog a lot. He is larger than a small horse."**</pre>

#### Part C)

Create a way to censor a single word palindrome in a text.

Example:

Input: <pre>"Anna went to vote in the election to fulfil her civic duty"</pre>
Output: <pre>**"A$$a went to vote in the election to fulfil her c$$$c duty"**</pre>

#### Part D - BONUS)

Come up with at least 3 different ways to provide the "censored words list" to the application. This task does not require coding, please send us  3 bullet points on how you would do this. 

---



Answer to question 3D:

1. One way to supply the app with a list is to load it from local or remote database;
2. Another way is to get the list from a post/get request via user interaction.
3. One could also store the list in a file. 
