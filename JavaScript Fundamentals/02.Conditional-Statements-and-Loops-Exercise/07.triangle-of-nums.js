function triangleOfNumbers (multiplier) {
    
    for (let row = 1; row <= multiplier; row++) {
        let outputNums = "";
        for (let col = 1; col <= row; col++) {
            outputNums += `${row} `;     
        }
        console.log(outputNums);
        
    }
}