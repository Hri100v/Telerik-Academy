/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/


function sum(array) {
				if (!array.length) {
					return null;//("This " + array + " is empty.")
				}


				array.forEach(function(num) {
					if (isNaN(num)) {
						throw new Error('numbers must be always of type Number');
					}
				});


				return array.reduce(function summary (a, b) {
					return a*1 + b*1;
				}, 0)
				
			};


module.exports = sum;






// function solve(array) {

// 	function sum (array) {
// 		// body...
// 	}
// 	if (!array.length) {
// 		throw new Error("This " + array + " is empty.")
// 	}

// 	array.forEach(function(num) {
// 		if (isNaN(num)) {
// 			throw new Error('numbers must be always of type Number');
// 		}
// 	});


// 	return array.reduce(function summary (a, b) {
// 		return a*1 + b*1;
// 	}, 0)
	
// 	return sum(array);
// }

// module.exports = solve;