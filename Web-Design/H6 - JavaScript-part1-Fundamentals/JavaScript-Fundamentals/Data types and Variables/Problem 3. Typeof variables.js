//Problem 3. Typeof variables

//Try typeof on all variables you created.

var copyArray = varInArray;

console.log("\nProblem 3: ");

console.log(copyArray);
for (var i = 0; i < copyArray.length; i++) {
    console.log('"' + copyArray[i] + '"' + ' \n\ttype is: ' + typeof (copyArray[i]));
};