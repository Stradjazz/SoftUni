function arrayRotation(numbers, rotations) {
    let currentNum = 0;
    for (let i = 0; i < rotations; i++) {
        currentNum = numbers.shift();
        numbers.push(currentNum);
    }
    console.log(numbers.join(' '));
    
}