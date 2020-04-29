function equalArrays(arr1, arr2) {
    for (let i = 0; i < arr1.length; i++) {
        arr1[i] = parseInt(arr1[i])    
    }
    for (let i = 0; i < arr2.length; i++) {
        arr2[i] = parseInt(arr2[i])    
    }

    let sum = 0;
    let index = 0;
    let areEqual = true;

    for (let i = 0; i < arr1.length; i++) {
        if (arr1[i] !== arr2[i]) {
            index = i;
            console.log(`Arrays are not identical. Found difference at ${index} index`); 
            areEqual = false;
            break;  
        } else {
            sum += arr1[i];
        }   
    }

    if (areEqual) {
        console.log(`Arrays are identical. Sum: ${sum}`);
    }
    
} 