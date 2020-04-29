function dayOfWeek(num) {
    const days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
    if (num < 1 || num > 7) {
        console.log("Invalid day!");
    } else {
        for (let i = 0; i < days.length; i++) {
            if (i === num - 1) {
               console.log(days[i]);
            }
            
        }
    }
}