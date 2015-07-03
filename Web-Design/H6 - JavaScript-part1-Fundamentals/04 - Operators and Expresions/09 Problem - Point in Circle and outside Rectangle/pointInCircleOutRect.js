// Problem 9. Point in Circle and outside Rectangle

// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).
// Examples:

// x	y		inside K & outside of R
// 1	2		yes
// 2.5	2		no
// 0	1		no
// 2.5	1		no
// 2	0		no
// 4	0		no
// 2.5	1.5		no
// 2	1.5		yes
// 1	2.5		yes
// -100	-100	no

// test 
var x = [1, 2.5, 0, 2.5, 2, 4, 2.5, 2, 1, -100], 
	y = [2, 2, 1, 1, 0, 0, 1.5, 1.5, 2.5, -100];

function inKoutR (x, y) {
	// body...

	// def circle
	var okX = 1;
	var okY = 1;
	var kR = 3;

	// def rectangle
	var top=1, 
		left=-1, 
		width=6, 
		height=2;

	var inCircleK = (x - okX) * (x - okX) + (y - okY) * (y - okY) <= kR * kR;
	// console.log(inCircleK);

	var buttom = top - height;
	var right = left + width;
	var outRectR = 
		(top < y || y < buttom) || 
		(x <= left || right <= x)

	// console.log(outRectR);
	if (inCircleK && outRectR) {
		return('yes');
	}
	else {
		return('no');
	}
}

for (var i = 0; i < x.length; i++) {
	var testX = x[i];
	var testY = y[i];
	console.log(testX + ' ' + testY + ' ' + inKoutR(testX, testY));
};

// var test = inKoutR(1, 2);
// console.log(test);

