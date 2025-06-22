Time Limit: 2 sec / Memory Limit: 1024 MiB

Score : 
100 points

Problem Statement
Takahashi wants to set his password for a certain website to a string 
P consisting of lowercase English letters.
The password for that website must be a string of length at least 
L.

Determine whether 
P satisfies the length condition, that is, whether it is a string of length at least 
L.

Constraints
P is a string consisting of lowercase English letters with length between 
1 and 
100, inclusive.
1≤L≤100
L is an integer.
Input
The input is given from Standard Input in the following format:

P
L
Output
If 
P satisfies the length condition, print Yes; otherwise, print No.

Sample Input 1
Copy
chokudai
5
Sample Output 1
Copy
Yes
The length of chokudai is 
8, which is at least 
5, so it satisfies the length condition.
Thus, print Yes.

Sample Input 2
Copy
ac
3
Sample Output 2
Copy
No
The length of ac is 
2, which is less than 
3, so it does not satisfy the length condition.
Thus, print No.

Sample Input 3
Copy
atcoder
7
Sample Output 3
Copy
Yes
The length of atcoder is 
7, which is at least 
7, so it satisfies the length condition.
Thus, print Yes.