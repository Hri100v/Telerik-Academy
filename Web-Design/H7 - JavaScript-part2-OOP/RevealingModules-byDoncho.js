var db = (function () {
	var lastId = 0,
		objects = [];

	function getNextId () {
		return ++lastId;
	}

	function addObject (obj) {
		obj.id = getNextId();
		objects.push(obj)
	}

	function listObject () {
		return objects.map(function (member) {
			return {
				name: member.name,
				id: member.id
			};
		}).slice();
	}

	return {
		add: addObject,
		list: listObject,
		getNextId: getNextId
	}
} ());

db.add({name: 'John'});
db.add({name: 'Hohn'});
console.log(db.list());

//prevent from Evil hacker
var objs = db.list();
// objs.push({name: 'Hacked u'})
objs[0].age = -1;
console.log(db.list());

console.log('db.getNextId() -> ' + db.getNextId())