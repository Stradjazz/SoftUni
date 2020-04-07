function vacation(amount, type, day) {
    let price;
    switch (type) {
        case "Students":
            if (day == "Friday") {
                 price = 8.45 * amount;
            } else if (day == "Saturday") {
                price = 9.80 * amount;
            } else if (day == "Sunday") {
                price = 10.46 * amount;
            }
            if (amount >= 30) {
                price -= price * 0.15;
            }
            break;

        case "Business":
            if (day == "Friday") {
                price = 10.90;
           } else if (day == "Saturday") {
               price = 15.60;
           } else if (day == "Sunday") {
               price = 16;
           }

           if (amount >= 100) {
               price *= amount - 10;
           } else {
               price *= amount;
           }
           break;
    
        default:
            if (day == "Friday") {
                price = 15 * amount;
           } else if (day == "Saturday") {
               price = 20 * amount;
           } else if (day == "Sunday") {
               price = 22.50 * amount;
           }

           if (amount >= 10 && amount <= 20) {
            price -= price * 0.05;
           }
            break;
    }
    console.log(`Total price: ${price.toFixed(2)}`);
    
} 