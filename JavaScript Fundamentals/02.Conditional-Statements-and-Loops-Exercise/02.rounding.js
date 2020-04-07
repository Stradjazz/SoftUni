function rounding (number, index) {
    if (index > 15) {
        index = 15;
    }
    console.log(parseFloat(number.toFixed(index)));
}