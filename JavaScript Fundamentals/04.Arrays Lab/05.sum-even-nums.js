function sumEvenNumbers(numbers) {
    let sum = 0;
    for (let i = 0; i < numbers.length; i++) {
        numbers[i] = parseInt(numbers[i]);
        if (numbers[i] % 2 === 0) {
            sum += numbers[i];
        }
    }
    console.log(sum);
} 