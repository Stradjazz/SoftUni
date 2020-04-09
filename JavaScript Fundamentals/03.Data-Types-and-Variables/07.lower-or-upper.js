function lowerOrUpper (input) {
    var char = input.charCodeAt(0);
    if (char >= 65 && char <= 90) {
        console.log(`upper-case`);
    } else {
        console.log(`lower-case`);    
    }
    
} 
