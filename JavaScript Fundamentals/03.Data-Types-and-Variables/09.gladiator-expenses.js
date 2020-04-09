function expenses (fightCount, helmet, sword, shield, armour) {
    let expenses = 0.0;
    let shieldCount = 0;
    let helmetCount = 0;
    let swordCount = 0; 
    let armorCount = 0;

    for (let i = 1; i <= fightCount; i++) {
       if (i % 12 == 0) {
            armorCount++;
            shieldCount ++;
            swordCount++;
            helmetCount++;
        } else if (i % 6 == 0) {
            shieldCount ++;
            swordCount++;
            helmetCount++;
        } else if (i % 3 == 0) {
            swordCount++;
        } else if (i % 2 == 0) {
            helmetCount++;
        }
    }
    expenses = (armorCount * armour) + (shieldCount * shield) + (swordCount * sword) + (helmetCount * helmet);
    console.log(`Gladiator expenses: ${expenses.toFixed(2)} aureus`);
    
}

// As a gladiator, Peter has to repair his broken equipment when he loses a fight. His equipment consists of helmet,
// sword, shield and armour. You will receive the Peter`s lost fights count.
//  Every second lost game, his helmet is broken.
//  Every third lost game, his sword is broken.
//  When both his sword and helmet are broken in the same lost fight, his shield also brakes.
//  Every second time, when his shield brakes, his armour also needs to be repaired.
// You will receive the price of each item in his equipment. Calculate his expenses for the year for renewing his
// equipment.
// Input / Constraints
// You will receive 5 parameters to your function:
//  First parameter – lost fights count – integer in the range [0, 1000].
//  Second parameter – helmet price - floating point number in range [0, 1000].
//  Third parameter – sword price - floating point number in range [0, 1000].
//  Fourth parameter – shield price - floating point number in range [0, 1000].
//  Fifth parameter – armor price - floating point number in range [0, 1000].
// Output
//  As output you must print Peter`s total expenses for new equipment: &quot;Gladiator expenses:
// {expenses} aureus&quot;
//  Allowed working time / memory: 100ms / 16MB.

