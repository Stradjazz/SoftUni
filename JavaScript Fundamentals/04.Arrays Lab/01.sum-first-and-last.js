//first version - with arr[i]
function sum(numbers) {
    let first = Number(numbers[0]);
    let last = Number(numbers[numbers.length - 1]);
    console.log(first + last);
    
} 
//second version - with methods

function sum(numbers) {
    let first = Number(numbers.shift());
    let last = Number(numbers.pop());
    console.log(first + last);
    
} 