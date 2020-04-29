function evenAndOddSubtraction(numbers) {
    let sumEven = 0;
    let sumOdd = 0;
    
    for (let i = 0; i < numbers.length; i++) {
        numbers[i] = parseInt(numbers[i]);
        if (numbers[i] % 2 === 0) {
            sumEven += numbers[i];
        } else {
            sumOdd += numbers[i];
        }
    }
    let result = sumEven - sumOdd;
    console.log(result);
} 