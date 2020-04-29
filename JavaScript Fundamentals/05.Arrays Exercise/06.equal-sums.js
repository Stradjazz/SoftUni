function equalSums(numbers) {
    let indexOutput = 0;
    let isEqual = false;
    
    for (let i = 0; i < numbers.length; i++) {
        let leftSum = 0;
        let rightSum = 0;
        for (let j = 0; j < i; j++) {
            leftSum += numbers[j];    
        }
        for (let k = i + 1; k < numbers.length; k++) {
            rightSum += numbers[k];
            
        }

        if (leftSum === rightSum) {
            indexOutput = i;
            isEqual = true;
            break;
        }    
    }
    if (isEqual) {
        console.log(indexOutput);     
    } else {
        console.log('no');
        
    }
}