function login (input) {
    let currentUser = input.shift();
    let currentPassword = input.shift();
    let stringArray = currentUser.split("");
    let reversedArray = stringArray.reverse();
    let correctPassword = reversedArray.join("");
    let counterLogins = 1;

    while (currentPassword !== correctPassword && counterLogins < 4) {
        currentPassword = input.shift();
        counterLogins++;
        console.log(`Incorrect password. Try again.`);    
    }

    if (counterLogins <= 4 && currentPassword == correctPassword) {
        console.log(`User ${currentUser} logged in.`);    
    } else {
        
        console.log(`User ${currentUser} blocked!`);
    }   
}
// login (["sunny", "rainy", "cloudy", "sunny", "not sunny"]);

