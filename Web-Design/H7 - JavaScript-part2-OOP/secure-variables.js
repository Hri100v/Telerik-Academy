var datebase = (function () {
	var items = [],
		db = {
			add: function (item) {
				items.push(item);
				return db;
			},
			list: function () {
				return items.slice();
			}
		};

	return {
		get: function () {
			return db;
		}
	}
} ());

var db = datebase.get();

var add = db.add;
console.log(
	add('John')
		.add('Hohn')
		.list()
	);