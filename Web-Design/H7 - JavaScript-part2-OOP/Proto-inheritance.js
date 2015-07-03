// var animal = {
// 	toString: function () {
// 		return 'animal';
// 	}
// }

// //shim
// function createObject(objToCreate) {
// 	// some create ...
// 	function Constructor() { };
// 	Constructor.prototype = objToCreate;
// 	return new Constructor()
// }




// var dog = Object.defineProperties(animal, {
// 	name: {
// 		value: 'Pesho',
// 		writable: false
// 	},
// 	age: {
// 		value: 5,
// 	}
// });




// var dogPrototype = Object.getPrototypeOf(dog)
// console.log(dogPrototype)



var animal = (function () {
	var animal = {
		init: function (name, age) {
			this.name = name;
			this.age = age;
			return this;
		},
		get name() {
			return this._name;
		},
		set name(value) {
			if (value.length < 3) {
				throw new Error('Sorry incorect!');
			}

			this._name = value;
		},
		toString: function () {
			return this.name + ' ' + this.age;
		}
	}

	return animal;
}());

var cat = (function (parent) {
	var cat = Object.create(parent);

	Object.defineProperty(cat, 'init', {
		value: function (name, age, sleep) {
			parent.init.call(this, name, age);
			this.sleep = sleep;
			return this;
		}
	})
	/// <summary>
	/// Same like as above 'init'
	/// </summary>
	// cat.init = function (name, age, sleep) {
	// 	parent.init.call(this, name, age);
	// 	this.sleep = sleep;
	// 	return this;
	// }

	cat.toString = function () {
		var baseResult = parent.toString.call(this);
		return baseResult + " " + this.sleep;
	}
	
	return cat;
}(animal))




var someAnimal = Object.create(animal).init('Pesho', 5);
console.log(someAnimal);

someAnimal.name = 'Peshoaaa';
console.log(someAnimal);
console.log(someAnimal.toString());

var someCat = Object.create(cat).init('Mimi', 19, true);
console.log(someCat);
someCat.name = 'Pepi'
someCat.sleep = false;
console.log(someCat);
console.log(someCat.toString());
