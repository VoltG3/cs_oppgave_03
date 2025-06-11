## cs_oppgave_03
___
#### Pseudocode
```sh
// ToDo :
//      1. Recursively process the array until array.Length == 1
//      2. Find the 'first operator' with the 'highest priority'
//      3. Store the 'position' of this 'highest priority operator' 
//      4. Expression: P[i-1] P[i] P[i+1] = P[Number Calc Number]
//      5. Remove elements at P[i] and P[i+1], shrink the array by 2
//      5. Replace P[i-1] with expression result
//      6. Repeat from step 1 with the updated array
```

#### Cycle example
```sha
//      Step 1 : 10 + 10 + 10 + 10 + 10 + 10 + 10 + 10 + 10 
//      Step 2 : 20 + 10 + 10 + 10 + 10 + 10 + 10 + 10 
//      Step 3 : 30 + 10 + 10 + 10 + 10 + 10 + 10 
//      Step 4 : 40 + 10 + 10 + 10 + 10 + 10 
//      Step 5 : 50 + 10 + 10 + 10 + 10 
//      Step 6 : 60 + 10 + 10 + 10 
//      Step 7 : 70 + 10 + 10 
//      Step 8 : 80 + 10
//      Step 9 : 100  
```

<img src="https://github.com/VoltG3/cs_oppgave_03/blob/master/screenshot_01.png" alt="screenshot_01.png" width="100%">
<img src="https://github.com/VoltG3/cs_oppgave_03/blob/master/screenshot_02.png" alt="screenshot_02.png" width="100%">
<img src="https://github.com/VoltG3/cs_oppgave_03/blob/master/screenshot_02.png" alt="screenshot_02.png" width="100%">


