// n	Divided by 7 and 5?
// 3	false
// 0	true
// 5	false
// 7	false
// 35	true
// 140	true 

var n = [3, 0, 5, 7, 35, 140];
var x = 7;
var y = 5;
var xy = x * y;
var canDiv;
// console.log(n[2]);
console.log('Divided by 7 and 5?')
for (var i = 0; i < n.length; i++) {
	canDiv = (n[i] % xy) === 0;
	console.log('%s\t%s', ("   " + n[i]).slice(-4), canDiv);
};
