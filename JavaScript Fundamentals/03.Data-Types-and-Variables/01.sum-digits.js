function sumDigits (input) {
    let inputArray = input.toString();
    
    let sum = 0; 
    for (let i = 0; i < inputArray.length; i++) {
        let currentNumber = parseInt(inputArray[i]);
        sum += currentNumber;
    }
    console.log(sum);
    
}