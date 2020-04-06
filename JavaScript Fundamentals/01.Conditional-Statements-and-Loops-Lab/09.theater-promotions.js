function theaterPromotions (day, age) {
    let price = 0;
    // age group 0 - 18
    if (age >= 0 && age <= 18) {
        switch (day) {
            case 'Weekday':
                price = 12;
                break;
            case 'Weekend':
                price = 15;
                break;
            case 'Holiday':
                price = 5;
                break;
        }
        console.log(`${price}$`);
    }
    //age group 19 - 64
    else if (age > 18 && age <= 64) {
        switch (day) {
            case 'Weekday':
                price = 18;
                break;
            case 'Weekend':
                price = 20;
                break;
            case 'Holiday':
                price = 12;
                break;
        }
        console.log(`${price}$`);
    }
    //age group 65 - 122
    else if (age > 64 && age <= 122) {
        switch (day) {
            case 'Weekday':
                price = 12;
                break;
            case 'Weekend':
                price = 15;
                break;
            case 'Holiday':
                price = 10;
                break;
        }
        console.log(`${price}$`);
    } else {
        console.log(`Error!`);
        
    }

}