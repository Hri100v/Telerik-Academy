// n		Third digit 7?
// 5		false
// 701		true
// 1732		true
// 9703		true
// 877		false
// 777877	false
// 9999799	true

var n = [5, 701, 1732, 9703, 877, 777877, 9999799];
// ----------------- variation 2
for (var i = 0; i < n.length; i++) {
	var result = (n[i] / 100) % 10;
		result = Math.floor(result) === 7;
	console.log(n[i] + '\t-> ' + result);
};



// ----------------- variation 1
// function toStrFun (someNum) {
// 	var digToStr = ("   " + someNum).slice(-4);
// 	return digToStr.toString();
// }

// function isSev3Dig (a) {
// 	var len = a.length
// 	var thirdDigit = len - 3;
// 	var isSeven = a[thirdDigit] == 7;
// 	return isSeven;
// }

// var temp = '';
// for (var i = 0; i < n.length; i++) {
// 	temp = toStrFun(n[i])
// 	console.log(isSev3Dig(temp) + '\t[' + n[i] + ']');
// };


