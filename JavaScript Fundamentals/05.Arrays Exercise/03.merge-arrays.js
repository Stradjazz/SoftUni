function mergeArrays(arr1, arr2) {
    let outputArray = [];
    
    for (let i = 0; i < arr1.length; i++) {
        if (i % 2 === 0) {
            outputArray.push(Number(arr1[i]) + Number(arr2[i]));
        } else {
            outputArray.push(arr1[i] + arr2[i]);
        }    
    }
    console.log(outputArray.join(' - '));
}
