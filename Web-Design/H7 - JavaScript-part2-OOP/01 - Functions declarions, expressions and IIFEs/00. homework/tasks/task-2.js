/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
	if (typeof(from) === 'undefined' || typeof(to) === 'undefined') {
		throw new Error();
	}

	from = +from;
	to = +to;
	
	var i, divisor, MaxDivisor, isPrime,
		prime = [];

	for (i = from; i <= to; i+=1) {
		maxDivisor = Math.sqrt(i)
		isPrime = true;
		for (divisor = 2; divisor <= maxDivisor; divisor+=1) {
			if (!(i % divisor)) {
				isPrime = false;
				break;
			}
		}

		if (isPrime && i > 1) {
			prime.push(i)
		}
	}

	return prime;
}

module.exports = findPrimes;


function solve () { 
    return function findPrimes(from, to) {
				if (typeof(from) === 'undefined' || typeof(to) === 'undefined') {
					throw new Error();
				}

				from = +from;
				to = +to;
				
				var i, divisor, MaxDivisor, isPrime,
					prime = [];

				for (i = from; i <= to; i+=1) {
					maxDivisor = Math.sqrt(i)
					isPrime = true;
					for (divisor = 2; divisor <= maxDivisor; divisor+=1) {
						if (!(i % divisor)) {
							isPrime = false;
							break;
						}
					}

					if (isPrime && i > 1) {
						prime.push(i)
					}
				}

				return prime;
			} 
}