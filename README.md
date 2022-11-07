# Loops
# Еxercises with Loops & Conditional construction

With solving the problems, I show learned techniques and understanding of the language at a basic level.

ProblemOneHotel:
A hotel has three types of rooms: studio, double and master suite. The prices are different for the different months:

May and October:
Studio - 50 leva per night,
Double - 65 leva per night,
Suite - 75 leva per night.

June and September
Studio - 60 leva per night,
Double - 72 leva per night,
Suite - 82 leva per night.

July, August and December:
Studio - 68 leva per night,
Double - 77 leva per night,
Suite - 89 leva per night.

They have also the following discounts: 
 
 For studio and more than 7 nights in May and October: 5% discount.
 For double and more than 14 nights in June and September: 10% discount.
 For suite and more than 14 nights in July, August and December: 15% discount.
 For studio and more than 7 nights in September and October: one night is free.

 The input consists of exactly 2 lines:

 First line: Month – May, June, July, August, September, October or December.
 Second line: Nights Count – an integer between [0 ... 200].

 Print 3 lines on the console:
 
  On the first: “Studio: {price for the stay} lv.”
  On the second: “Double: {price for the stay} lv.”
  On the third: “Suite: {price for the stay} lv.”
Format the prices to the 2nd decimal place.



ProblemTwoPlural:

Write a program, which receives a noun and prints the noun in plural. You will receive one of the following cases: 
  A noun that ends in y – remove the y and add ies.
 	A noun that ends in o, ch, s, sh, x or z – add es at the end of the word.
 	In all other cases – just add s at the end.

Input:

You will receive a single word, which you have to pluralize.

Output:

Print only the word in plural.

ProblemThreeCake:

Write a baking program, which takes as an input ingredients and writes a message when the ingredient is in the system. For every given ingredient, you should write: “Adding ingredient {name of the ingredient}.”. When you receive the command “Bake!” from the console you should stop the program and write “Preparing cake with {number of given ingredients} ingredients.”.

Input:

You will receive ingredients until the command “Bake!” is given.

Output:

For every given ingredient write on a new line the message: “Adding ingredient {name of the ingredient}.”. At the end print the message: “Preparing cake with {number of given ingredients} ingredients.”.


ProblemFourTestNumbers:

Write a program, which finds all the possible combinations between two numbers – N and M.
The first digit decreases from N to 1, and the second digit increases from 1 to M. The two digits form a number. Multiply the two digits, then multiply their product by 3. Add the result to the total sum. 
You will also be given a third number, which will be the maximum boundary of the sum. If the sum is equal or greater than this number you should stop the program. See the examples for further information. 

Input:

The input is read from the console and consists of three lines: 

 First line – N – integer in the interval [1…100],

 Second line – M – integer in the interval [1…100],

 Third line – maximum sum boundary – integer in the interval [1…1000000].

Output:

The output depends on the result:

 If the sum is equal or greater than the maximum sum:

	 "{count of combinations} combinations",

    "Sum: {sum from the combinations} >= {maximum sum}"


If the sum is less than the maximum sum:

    "{count of combinations} combinations",

    "Sum: {sum from the combinations}"
















