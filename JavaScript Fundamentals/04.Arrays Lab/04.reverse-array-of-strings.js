function reverseStrings(elements){
    for (let i = 0; i < elements.length / 2; i++) {
        swapElements(elements, i, elements.length - 1 - i);
        
    }
    console.log(elements.join(' '));

    function swapElements(elements, i, j) {  
        let temporary = elements[i];
        elements[i] = elements[j];
        elements[j] = temporary;
    }
    
} 