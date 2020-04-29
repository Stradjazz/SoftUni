function maxNumber(numbers) {
    let topIntegers = [];
    let isTopInt = false;
    let currentNumber = 0;
    let comparissonNum = 0;
    for (let i = 0; i < numbers.length - 1; i++) {
        currentNumber = numbers[i];
        for (let j = i+1; j < numbers.length; j++) {
            comparissonNum = numbers[j];
            if (currentNumber > comparissonNum) {
                isTopInt = true;
            } else {
                isTopInt = false;
                break;
            }
        }
        if (isTopInt) {
            topIntegers.push(currentNumber);
        }     
    }
    topIntegers.push(numbers[numbers.length - 1]);
    console.log(topIntegers.join(' '));
}