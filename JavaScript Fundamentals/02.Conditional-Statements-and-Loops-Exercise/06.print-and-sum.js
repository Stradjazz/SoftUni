function printAndSum (start, end) {
    let sum = 0;
    let outputNums = "";
    for (let i = start; i <= end; i++) {
        outputNums += `${i} `;
        sum += i;
    }
    console.log(outputNums);
    
    console.log(`Sum: ${sum}`);
    
}