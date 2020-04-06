function sumOddNums(num) {
    let sum = 0;
    let counter = 1;
    for (let index = 1; index <= 100; index++) {
        if (index % 2 != 0 && counter <= num) {
            console.log(index);
            sum += index;
            counter++;
        }    
    }
    console.log(`Sum: ${sum}`);
    
}