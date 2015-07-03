var b = -1;
var n = [3, 2, -2, -1, 0, 1, 2, 3];
oddOrEven(n);
function oddOrEven (arg) {
	var isOdd;
	for (var i = 0; i < n.length; i++) {
		isOdd = ((n[i] % 2) !== 0);
		console.log('%d is odd -> %s', n[i], isOdd);
	};
		// console.log((b % 2) !== 0);
}
	