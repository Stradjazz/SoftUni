function maxSequence(numbers) {
    
    let longestSequence = [];
    let leftMostIndex = 0;
 
 
    for (let i = 0; i < numbers.length; i++) {
        currentElement = Number(numbers[i]);
        let currentSequence = [currentElement];
 
 
        for (let j = i + 1; j < numbers.length; j++) {
            let nextElement = Number(numbers[j]);
 
            if (nextElement === currentElement) {
                currentSequence.push(nextElement)
            } else {
                break;
            }
 
        }
 
        if (currentSequence.length > longestSequence.length) {
            longestSequence = [];
            for (let j = 0; j < currentSequence.length; j++) {
                longestSequence.push(currentSequence[j]);
            }
        } else if (currentSequence.length === longestSequence.length) {
            if (i < leftMostIndex) {
                leftmostIndex = i;
            }
        }
    }
    console.log(longestSequence.join(' '));
}