var width1 = 3;
var height1 = 4;
var width2 = 2.5;
var height2 = 3;
var width3 = 5;
var height3 = 5;

var area;

function rectArea (width, height) {
	area = (width * height);
	console.log('width = %d height = %d -> area =', width, height, area);
};

rectArea(width1, height1);
rectArea(width2, height2);
rectArea(width3, height3);
