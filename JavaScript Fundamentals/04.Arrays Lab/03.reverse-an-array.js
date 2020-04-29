//first version - with for loops
function reverseArray(num, inputArray) {
    const newArray = [];
    for (let i = 0; i < num; i++) {
        newArray.push(inputArray[i]);    
    }

    let output = '';
    for (let i = newArray.length - 1; i >= 0; i--) {
        output += `${newArray[i]} `;
    }
    console.log(output);    
} 

//second version - with array methods
function reverseArray(num, inputArray) {
    inputArray.length = num;
    console.log(inputArray.reverse().join(' '));
}
