function magicSum(numbers, magicSum) {
    
    for (let i = 0; i < numbers.length - 1; i++) {
        let leftNum = numbers[i];
        for (let j = i + 1; j < numbers.length; j++) {
            rightNum = numbers[j];
            let sum = leftNum + rightNum; 
            if (sum === magicSum) {
                console.log(leftNum, rightNum);
             }   
        }    
    }    
}