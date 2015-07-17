(function() {
// using __proto__
	var obj = {};
	Object.defineProperty(obj, 'key1', {
		__proto__: null,

		value: 'static1'
		// not enumerable
		// not configurable
		// not writable
		// as default
	});

// being explicit
	Object.defineProperty(obj, 'key2', {
		enumerable: true,
		configurable: false,
		writable: false,
		value: 'static2'
		// as default
	});

	console.info(obj.key1);

// recycling same object
	function withValue (value) {
		var d = withValue.d || (
				withValue.d = {
					enumerable: true,
					configurable: true,
					writable: false,
					value: null
				}
			);
		d.value = value;
		return d;
	};

	function describeProperties (object, property) {
		return Object.getOwnPropertyDescriptor(object, property);
	};

	// console.info(withValue('to'));

	Object.defineProperty(obj, 'key3', withValue('static3'));
	Object.defineProperty(obj, 'key4', withValue('static4'));

	// console.info(describeProperties(obj, 'key2'));
	console.log(obj);
	obj.key3 = 'some else';
	console.log(obj);
	// obj.key3 = {
	// 	writable: true,
	// 	enumerable: false,
	// 	value: 'another-else'
	// }
	console.log('-------------------');
	// console.log(obj);
	// console.log(Object.keys(obj));
	// console.log(JSON.stringify(obj));

	var specialKey = {
		id: 5,
		descr: 'special key 5'
	};
	Object.defineProperty(obj, 'key5', {
		enumerable: false,
		value: specialKey
	});

	console.log(JSON.stringify(obj));
	console.log(obj.key5);
	console.log(Object.keys(obj)); // hide some keys
	console.log(Object.getOwnPropertyNames(obj)); // show all keys
	console.log(Object.getOwnPropertyDescriptor(obj, 'key5'));
	Object.defineProperty(obj, 'key3', {
		configurable: true,
		writable: true,
		// value: 'some another-else'
	});
	obj.key3 = 'some another-else';
	console.log(obj);
	console.log('========================');
	console.log(obj.hasOwnProperty('key7'));
	var valueOfObj = obj.valueOf();
	console.log(valueOfObj + ' this is the final result');
} ());
