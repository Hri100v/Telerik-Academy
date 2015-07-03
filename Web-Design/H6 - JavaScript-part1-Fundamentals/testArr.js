function Person (fname, lname, age, gender) {
		this.firstName = fname,
		this.lastName = lname,
		this.age = age,
		this.gender = gender//(!!gender ? 'female' : 'male');
	};

var people1 = [
			new Person('Strahil', 'Strandjev', 32, false),
			new Person('Nikodim', 'Popdimitrov', 69, false),
			new Person('Gosho', 'Petrov', 32, false),
			new Person('Bay', 'Ivan', 84, false),
			new Person('Bay', 'Petrov', 81, false)
		],
	people2 = [
			new Person('Maria', 'Blagoeva', 19, true),
			new Person('Petyr', 'Georgiev', 17, false),
			new Person('Ivan', 'Dimitrov', 15, false),
			new Person('Lidia', 'Lilova', 22, true),
			new Person('Dimana', 'Dimitrova', 24, true)

	]

// function checkGreater (arrayPersons) {
// 	// body... (with age 18 or greater)
// 	var check = arrayPersons.every(function (member) {
// 		return member.age >= 18;
// 	})
// 	return check;
// }

// console.log(people1)
// console.log(checkGreater(people1))
// console.log('\n')
// console.log(people2)
// console.log(checkGreater(people2))

// prints all underaged persons of an array of person
// Use Array#filter and Array#forEach

// function underaged (array) {
// 	// body...
// 	var underAge = 69;
// 	var arrange = array.filter(function (mem) {
// 		return (mem.age <= underAge);
// 	});
// 	// console.log(arrange)
// 	console.log('first name |' + ' last name |' + ' age')
// 	console.log('......................................')
// 	arrange.forEach(function represent (person) {
// 		// body...
// 		console.log(person.firstName + ' | ' + person.lastName + ' | ' + person.age)
// 	})
// }

// underaged(people1)
// console.log()
// underaged(people2)


// Write a function that calculates the average age of all females, extracted from an array of persons
// 	- Use Array#filter
// 	- Use only array methods and no regular loops (for, while)

// console.log(people2)

// function avrAgeOnlyFemale (peopleArr) {
// 	var avrAge = 0,
// 		count = 0,
// 		arrFemale = peopleArr.filter(function castFemale(f) {
// 			return f.gender;
// 		});

// 	arrFemale.forEach(function calc (female) {
// 		count++;
// 		avrAge += female.age;
// 	})
// 	avrAge = (avrAge / count).toFixed(2)
// 	return 'Average ' + avrAge + ' years';

// }

// var result = avrAgeOnlyFemale(people2);
// console.log(result)



// console.log(findYoungest(people2))

if (!Array.prototype.find) {
	Array.prototype.find = function(callback) {
		var i,
			len;
		for(i = 0, len = this.length; i < len; i += 1) {
			if (callback(this[i], i, this)) {
				return this[i];
			}
		}
		return undefined;
	}
} 
// console.log(people2)

// var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// console.log(numbers.find(function(item) {
//   return !!(item % 2) && item > 5;
// }));            

// var test = people2.sort(function (first, second) {
// 	// body...
// 	return first.age - second.age;
// })
// // console.log(test)
// // console.log(people2)


// function findYoungest (array, years) {
// 	var years = years || 0 //years || 200;
// 	var res;
// 	res = array.find(function(p) {
// 		return p.age > years;
// 	})
// 	console.log('Youngest person (after %s)', years)
// 	return res;
// };

// console.log(findYoungest(test,16))
// console.log(people1.forEach(function(mem) {
// 	return mem.firstName;
// }));

// var tr = people1.reduce(function(n, item) {
// 	// body...
// 	return n = {item.firstName[0] : [item]}
// });
// console.log(tr);

// var r = [1, 2, 3, 4].reduce(function(sum, item) {
// 	// body...
// 	return sum = sum + { item:'some' }
// }, {});
// console.log();
// console.log(r);
// console.log(typeof r);


// var groups = people1.reduce(function (gr, person) {
//     var letter = person.firstName[0];

//     if (gr[letter]) {
//         gr[letter].push(person);
//     } else {
//         gr[letter] = [person];
//     }

//     return gr;
// }, {});

// console.log(groups);

// var u['som'];
// console.log(u);

// function grouped (arr) {
// 	var result;

// 	result = arr.reduce(function(group, member) {
		
// 		if (group[member.firstName[0]]) { // has person with same first latter push to array
// 			group[member.firstName[0]].push(member);
// 		} else { //hasn`t that person
// 			group[member.firstName[0]] = [member];
// 		}
// 		return group;
// 	}, {})

// 	return result;
// }

// console.log(grouped(people1))

// var input = 'sample';

// function reverses (inline) {
// 	// body...
// 	console.log(inline);
// 	console.log('-= reverse to =-');
// 	var i,
// 	len = inline.length,
// 	output = [];
// 	for (i = len - 1; i >= 0; i -= 1) {
// 		output[i] = inline[((len - 1) - i)]
// 		// console.log(i + ' -> ' + ((len - 1) - i))
// 	};
// 	console.log(output.join(''));
// }

// reverses(input);


// Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

// var correct = '((a+b)/5-d)',
// 	incorrect = ')(a+b))';

// function checkBrackets (expr) {
// 	var index,
// 		countB = 0, 
// 		check = true;
// 	for(index of expr) {
// 		if (index === '(') {countB++};
// 		if (index === ')') {countB--};
// 		if (countB < 0) {check = false};
// 	}
// 	return check;
// }

// console.log(checkBrackets(correct))
// console.log(checkBrackets(incorrect))

// The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

// var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
// 	key = 'in';

// function countSubCountain (text, sub) {
// 	// // body...
// 	// console.log('text: \n' + text);
// 	// console.log('sub-string: ' + sub);
// 	// console.log(text.length - 1);
// 	var counter = 0,
// 		currPos = 0;
// 	for (var i = 0; i < text.length; i++) {
// 		currPos = text.indexOf(sub, i)
// 		if (currPos !== -1) {
// 			counter++;
// 			i = currPos;
// 		} else {
// 			return ('The result is: ' + counter);
// 		}
// 	};
// 	// var counter = text.indexOf(sub) <= text.length - 1 ? +1 : -1
// 	// return counter;
// }

// console.log(text.indexOf('in'));
// console.log(text[34] + '-' + text[35]);
// console.log(text.indexOf('in', 35));
// console.log(text.indexOf('in', 190));

// countSubCountain(text, key)
// console.log(countSubCountain(text, key))



// /// 	Task 4									  38
// var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>AnyThing</lowcase> else.";
// 			//0123456789012
// var trSome = '<upcase>text</upcase> to uppercase.';
// // console.log(trSome);
// // console.log(trSome.indexOf('</upcase>'));
// // console.log(trSome.indexOf('>', 8));
// // console.log(trSome[9]);
// // console.log(trSome.substr(12, 9));
// // console.log(trSome.substring(8, 12).toUpperCase());

// var mixCLen = '<mixcase>'.length
// 	upCLen = '<upcase>'.length,
// 	lowCLen = '<lowcase>'.length,
// 	stMix = '<mixcase>',
// 	endMix = '</mixcase>',
// 	stUp = '<upcase>',
// 	endUp = '</upcase>',
// 	stLow = '<lowcase>',
// 	endLow = '</lowcase>';

// console.log(mixCLen + upCLen + lowCLen);
// var temp = trSome.indexOf('<',12) - trSome.indexOf('>')
// console.log(trSome.indexOf('<',12))
// console.log(trSome.indexOf('>'))

// console.log(temp);
// console.log(trSome.substring(8,12));
// console.log(trSome.replace('<upcase>', ''))

// var i = 0;
// text = new String(text);
// while(text.indexOf('</mixcase>') > 0 && i < 200) {
// 	text.replace('<', '');
// 	console.log(text);
// 	text[i] = '';
// 	console.log(i);
// 	i+=1;
// }


// function textChange (text) {
// 	var word = '',
// 		startIndex = 0,
// 		endIndex = 0,
// 		forTrim = '',
// 		renewTXT = text;
// 	function changeUpcase (txt) {
// 		startIndex = txt.indexOf(stUp);
// 		endIndex = txt.indexOf(endUp);
// 		word = txt.substring(startIndex + upCLen, endIndex).toUpperCase();	//start & end
// 		forTrim = txt.substr(startIndex, (endIndex + upCLen + 1) - startIndex);
// 		renewTXT = txt.replace(forTrim, word);
// 	}
// 	function changeLowcase (txt) {
// 		startIndex = txt.indexOf(stLow);
// 		endIndex = txt.indexOf(endLow);
// 		word = txt.substring(startIndex + lowCLen, endIndex).toLowerCase();
// 		forTrim = txt.substr(startIndex, (endIndex + lowCLen + 1) - startIndex);
// 		renewTXT = txt.replace(forTrim, word);
// 	}

// 	function changeMixcase (txt) {
// 		startIndex = txt.indexOf(stMix);
// 		endIndex = txt.indexOf(endMix);
// 		word = txt.substring(startIndex + mixCLen, endIndex);
// 		// code for mixing >>>
// 		var tmp = '';
		
// 		for (var i = 0; i < word.length - 2; i++) {
			
// 			if(Math.random() < 0.5) {
// 				tmp += word[i].toUpperCase()
// 			} else {
// 				tmp += word[i].toLowerCase()
// 			}
// 		};

// 		forTrim = txt.substr(startIndex, (endIndex + mixCLen + 1) - startIndex);
// 		//return  >> question to who check this task how it is possible to use without return and what is difference
// 		renewTXT = txt.replace(forTrim, tmp);
// 		// return renewTXT;
// 	}

// 	for (var i = 0; i < text.length; i++) {
// 		if (renewTXT.indexOf(stUp) !== -1) {
// 			// console.log('has uper');
// 			i = renewTXT.indexOf(endUp);	//>>> for speedUP
// 			changeUpcase(renewTXT);
// 		} else if (renewTXT.indexOf(stLow) !== -1) {
// 			// console.log('has lower');
// 			changeLowcase(renewTXT);
// 		} else if (renewTXT.indexOf(stMix) !== -1) {
// 			i = renewTXT.indexOf(endMix);
// 			changeMixcase(renewTXT)
// 		}
// 	};

// 	return renewTXT;

// }

// console.log(text)
// var result = textChange(text);
// console.log(result)
// console.log(textChange(result))


// console.log(text.match('/upcase/g'))


// function problem5() {
//     var input = 'string5text \naand more ...   maybe one more.',
//         result = replaceWhiteSpace(input);
//     // document.getElementById('pr5answer').innerHTML = result;
//     console.log(input)
//     console.log('Problem 5: ' + result);
// }

// function replaceWhiteSpace(text) {
//     return (text.split(/\s/g).join('&nbsp;'));
// }

// problem5();

// function testNBSP () {
// 	// body...
// 	'use strict';

// 	var someText = '"Lorem ipsum..."   is one of the most common filler texts, popular with typesetters and graphic designers. "Li Europan lingues..." is another similar example.',
// 		result;

// 	result = someText.split(' ').join('&nbsp;');
// 	console.log(result);

// }

// testNBSP()

// var str = 'Text another ttextt and again 12 a text.',
// 	r;

// // r = str.match(/[A-z]{1,5}/g);
// r = str.match(/T.*?/gi);

// // console.log(r);
// // console.log(r.length);

// var mail = 'very.hot@mail.do.com',
// 	e;

// e = mail.match(/[A-z0-9._]{2,}@[A-z0-9]{2,}\.[A-z.]{2,}/g);

// // console.log(e);
// //"<upcase>(.*?)</upcase>"
// var trSome = '<upcase>text</upcase> to uppercase.',
// 	rgx;

// rgx = trSome.match("<upcase>(.*?)</upcase>");
// // console.log(rgx);
// // console.log(rgx[0]);
// // console.log(rgx[1]);
// // console.log(rgx['input']);


// var htmlInput = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
// var rslt = htmlInput.match(/<([a-zA-Z]+).*?>(.*?)<([a-zA-Z]+).*?>/g);		// <([a-zA-Z]+).*?>(.*?)</\\1>		//.match(/<(title)>(.+)<\/\1>/)  > take only between title
// console.log(htmlInput);
// console.log(rslt);
// var b = htmlInput.replace(/<[^>]*>/g, '');
// console.log(b)

// function extrTxtHtml (text) {
// 	// body...
// 	var output = [];
// 	for (var i = 0; i < text.length; i++) {
// 		if (text[i] === '<') {
// 			i = text.indexOf('>', i);
// 		} else {
// 			output.push(text[i]);
// 		}
		
// 	};
// 	return output.join('');
// }

// console.log(extrTxtHtml(htmlInput))

if (!Array.prototype.fill) {
  Array.prototype.fill = function(value) {

    // Steps 1-2.
    if (this == null) {
      throw new TypeError('this is null or not defined');
    }

    var O = Object(this);

    // Steps 3-5.
    var len = O.length >>> 0;

    // Steps 6-7.
    var start = arguments[1];
    var relativeStart = start >> 0;

    // Step 8.
    var k = relativeStart < 0 ?
      Math.max(len + relativeStart, 0) :
      Math.min(relativeStart, len);

    // Steps 9-10.
    var end = arguments[2];
    var relativeEnd = end === undefined ?
      len : end >> 0;

    // Step 11.
    var final = relativeEnd < 0 ?
      Math.max(len + relativeEnd, 0) :
      Math.min(relativeEnd, len);

    // Step 12.
    while (k < final) {
      O[k] = value;
      k++;
    }

    // Step 13.
    return O;
  };
}

// var arr1 = [],
//     count1 = 6;
// arr1[count1 - 1] = undefined;
// arr1.fill(1);
// console.log(arr1);

// var arr = [],
// 	row = 0,
// 	col = 0,
//   count = 5;
// arr[count - 1] = undefined;

// arr.fill([1, 2, 3, 4, 5]);


// var matrix = [];
// row = 3;
// col = 5;
// matrix = Array(row);

// console.log(arr);

// for (var i = 0; i < row; i+=1) {
// 	for (var j = 1; j <= col; j+=1) {
// 		matrix.push(j)
// 	}
// }

// console.log(matrix)
// console.log('arrange new matrix from stackOverflow')


// var newArray = array[0].map(function(col, i) { 
//   return array.map(function(row) { 
//     return row[i] 
//   })
// });

// console.log(newArray)

// var url = 'http://telerikacademy.com/Courses/Courses/Details/239';
// var match = /(.*):\/\/(.*?)(\/.*)/.exec(url);
// console.log(match)
// URL															result
// http://telerikacademy.com/Courses/Courses/Details/239		{ protocol: http, 
// 																server: telerikacademy.com 
// 																resource: /Courses/Courses/Details/239
// console.log(url.match(/^[https]+/g));
// console.log(url.match(/^[https]+/g));

// var answer = url.split('//');
// console.log(answer);
// var r = url.substr(0, 4)
// console.log(r);
// answer.pesho = 123;
// var dobi = 333;
// answer.dobi = dobi;
// console.log(answer.dobi);

// function urlParse (url) {
// 	var stIndx,
// 		endIndx,
// 		protocol,
// 		server,
// 		resource,
// 		parseRes = {};
// //	01234567890123456789012345678901234567890123456789012
// //  http://telerikacademy.com/Courses/Courses/Details/239

// 	// find protocol
// 	endIndx = url.indexOf(':');
// 	protocol = url.substr(0, endIndx);
// 	// console.log(protocol)

// 	// find server
// 	stIndx = endIndx + 3;
// 	endIndx = url.indexOf('/', url.indexOf('.'));
// 	// console.log(endIndx);
// 	server = url.substring(stIndx, endIndx);
// 	// console.log(server)

// 	// find resource
// 	stIndx = endIndx + 1;
// 	endIndx = url.length;
// 	resource = url.substring(stIndx, endIndx);
// 	// console.log(resource);

// 	parseRes.protocol = protocol;
// 	parseRes.server = server;
// 	parseRes.resource = resource;

// 	return parseRes;
// }

// var answer = urlParse(url);
// console.log(answer);




// /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;

// var mixText = 'This is one example with e-mails like hot@mail.com, and need to be extracted from this text. One more e-mail: Tiffany-co.mail_info@mail.co.uk';
// var d = mixText.match(/[A-z.-]+@\w+\.\w+/g);
// console.log(d)

// function extractEmails (sometxt) {
// 	// body...
// 	var d = sometxt.match(/[A-z.-]+@\w+\.\w+/g);
// 	console.log(d)
// }

// extractEmails(mixText)




// function problem10() {
//     var input = document.getElementById('string10text').value,
//         result = findPalindromes(input);
//     document.getElementById('pr10answer').innerHTML = result;
//     console.log('Problem 10: ' + result);
// }



// console.log( findPalindromes( 'ABBA, lamal, exe'))

// function findPalindromes(text) {
//     var i,
//         result = [],
//         arrOfWords = text.split(' ').map(function(item) {
//             return item.trim('.,!?()"-');
//         });
//     len = arrOfWords.length;
//     for (i = 0; i < len; i += 1) {
//         if (arrOfWords[i].length > 1 &&
//             arrOfWords[i].toLowerCase() === reverseWord(arrOfWords[i].toLowerCase())) {
//             result.push(arrOfWords[i]);
//         }
//     }
//     return result;
// }

// function reverseWord(word) {
//     return word.split('').reverse().join('');
// }

// http://www.sitepoint.com/trimming-strings-in-javascript/

String.prototype.trimLeft = function(charlist) {
    if (charlist === undefined)
        charlist = "\s";

    return this.replace(new RegExp("^[" + charlist + "]+"), "");
};

String.prototype.trimRight = function(charlist) {
    if (charlist === undefined)
        charlist = "\s";

    return this.replace(new RegExp("[" + charlist + "]+$"), "");
};

String.prototype.trim = function(charlist) {
    return this.trimLeft(charlist).trimRight(charlist);
};



// var palindrTxt = 'Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".';

// function isPalindromes (word) {
// 	for (var i = 0; i < parseInt(word.length / 2, 10); i++) {
// 		if (word[i] !== word[word.length - i - 1]) {
// 			return false; 
// 		}
// 	}

// 	return true;
// }

// function extrWordP (txt) {
// 	// body...
// 	var allWords = txt.match(/\w+/g);
// 	var result = allWords.filter(function searchPalindr (word) {
// 		return word.length > 1 && isPalindromes(word);
// 	});

// 	return result;
// }

// console.log(extrWordP(palindrTxt))

// console.log(palindrTxt.match(/\w+/g))





// Write a function that formats a string using placeholders.
// The function should work with up to 30 placeholders and all types.
// Examples:

// var str = stringFormat('Hello {0}!', 'Peter'); 
// //str = 'Hello Peter!';

// var frmt = '{0}, {1}, {0} text {2}';
// var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
// //str = '1, Pesho, 1 text Gosho'

function stringFormat (argument) {
	// body...
	var frmt = argument[0],
		variable = [];

	console.log(frmt)

}

// var str = stringFormat('Hello {0}!', 'Peter'); 
// console.log(stringFormat)

// for(var i in stringFormat) {
// 	console.log(i + ' <> ' + stringFormat[i])
// }

// x = findMax(1, 123, 500, 115, 44, 88);

// function findMax() {
//     var i, max = 0;
//     for (i = 0; i < arguments.length; i++) {
//         if (arguments[i] > max) {
//             max = arguments[i];
//         }
//     }
//     return max;
// }

// console.log(x)


//     function format(str) {
//         var selfArguments = arguments
//         return str.replace(/\{(\d+)\}/g, function(match, p1) {
//             return selfArguments[+p1 + 1]
//         })
//     }
//     console.log(format('{0}, {1}! {2} {3}; and some numbers -> {4}', 'Hello', 'World', 'And some more', true, 123))




    // function generateList(people, template) {
    //     var result = '<ul>'
    //     people.forEach(function(human) {
    //         result += '<li>'
    //         result += template.replace(/-\{(.*?)\}-/g, function(match, p1) {
    //             return human[p1]
    //         })
    //         result += '</li>'
    //     })
    //     result += '</ul>'
    //     return result
    // }
    // var people = [{
    //         name: 'Pesho',
    //         age: 25
    //     }, {
    //         name: 'Gosho',
    //         age: 30
    //     }, {
    //         name: 'Vanko',
    //         age: 35
    //     }, {
    //         name: 'Doncho',
    //         age: 40
    //     }],

    //     template = document.getElementById('list-item')
    // template.outerHTML = generateList(people, template.innerHTML)
str = 'abc'
console.log(String.fromCharCode(120))
// console.log(str[0])
console.log(str.charCodeAt(0))


var a = [];

console.log(97 ^ 120)

var CONSTANTS = {
 ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
 } 

console.log(CONSTANTS.ALPHABET)
// console.log(String.fromCharCode(99))
// console.log(String.fromCharCode(102))
var offset = 3;
var cypher = '';
var startCphr, endCphr;
var alphLen = CONSTANTS.ALPHABET.length;
startCphr = CONSTANTS.ALPHABET.substring(alphLen - offset)
endCphr = CONSTANTS.ALPHABET.substr(0, alphLen - offset)

// console.log(startCphr)
// console.log(endCphr)
cypher = startCphr + endCphr;
console.log(cypher)

CONSTANTS['CYPHER'] = cypher;

console.log(CONSTANTS)

var str= 'aaaabbbccccaa';
var arrSeq = str.match(/([a-z])\1*/g)        // (/([a-zA-Z]).*?\1/).test(str)        
console.log(arrSeq);
var subSeqLen = 0;

var tempR = '';

function cultivate (arr) {
  return arr.length + arr[0];
}
// console.log(cultivate('aa'))


for (var i = 0; i < arrSeq.length; i++) {
  console.log(arrSeq[i].length);
  subSeqLen = arrSeq[i].length;
  if (subSeqLen > (cultivate(arrSeq[i]).length)) {
    tempR += cultivate(arrSeq[i]);
  } else {
    tempR += arrSeq[i];
  }

}


console.log(tempR)





