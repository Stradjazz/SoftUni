function condenseArray(numbers) {
    while (numbers.length > 1) {
        let condensed = new Array(numbers.length - 1);
        for (let i = 0; i < condensed.length; i++) {
            condensed[i] = numbers[i] + numbers[i + 1];
        }
        numbers = condensed;
    }
    console.log(numbers[0]);
    
}
