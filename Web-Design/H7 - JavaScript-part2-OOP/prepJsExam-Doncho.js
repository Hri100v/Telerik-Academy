// wiht little changes
function solve () {
	function isStringValid (str, minLength, maxLength) {
		return (typeof str === 'string') &&
			minLength <= str.length && 
			str.length <= maxLength;
	};

	var player = function () {
		function byNameThenById (pl1, pl2) {
			if (pl1.name === pl2.name) {
				return pl1.id - pl2.id;
			}
			return pl1.name.localCompare(pl2.name);
		};

		var lastId = 0,
			player = {
				init: function (name) {
					this.id = lastId += 1;
					this.name = name;
					this.playlists = [];

					return this;
				},
				get name() {
					return this._name;
				},
				set name(currentName) {
					if (!isStringValid(currentName, 3, 25)) {
						throw {
							name: 'InvalidPlayerNameError',
							message: 'InvalidPlayerNameError'
						}
					}

					this._name = currentName;
				},
				addPlaylist: function (playlist) {
					if (playlist.id === 'undefined' ||
						!playlist.name) {
						throw {
							name: 'InvalidPlayerError',
							message: 'InvalidPlayerError'
						}
					}
					this.playlists.push(playlist);
					return this;
				},
				getPlaylistById: function (id) {
					var i,
						len;
					for (i = 0, len = this.playlists.length; i < len; i += 1) {
						if(this.playlists[i].id === id) {
							return this.playlists[i];
						}
					}

					return null;
				},
				removePlaylist: function (idOrPlayable) {
					var id = +idOrPlayable;
					if (typeof id === 'undefined') {
						throw {
							name: 'InvalidIdError',
							message: 'InvalidIdError'
						}
					}

					if (typeof(idOrPlayable) !== 'number') {
						// in this case we take ID from PLAYABLE
						id = idOrPlayable.id;
					}

					var removeIndex = this.playlists.findIndex(function (playlist) {
						return playlist.id === id;
					});

					if (removeIndex < 0) {
						throw {
							name: 'IdSearchError',
							message: 'IdSearchError'
						};
					}

					this.playlists.splice(removeIndex, 1);
					return this;
				},
				listPlaylists: function (page, size) {
					/*
						page*size > COUNT_OF_PLAYABLE_IN_PLAYLIST
						page < 0
						size <= 0
						page*size , (page + 1) * size
						(0, 10)
						0 1 2 3 4 5 6 7 8 9
					*/
					if (typeof(page) === 'undefined' ||
						typeof(size) === 'undefined' ||
						page < 0 ||
						size <= 0) {
						throw {
							name: 'InvalidPageSizeError',
							message: 'InvalidPageSizeError'
						};
					}
					this.playlists.sort(byNameThenById);
					return this.playlists.slice(page * size, (page + 1) * size);
				},
				contains: function (playable, playlist) {
					// This is new. That is added after the presentation about prep exam
				},
				search: function (pattern) {
					pattern = pattern.toLowerCase();
					return this.playlists.filter(function (playlist) {
						return playlist.getAllPlayable()
							.some(function (playable) {
								return playable.title
									.toLowerCase()
									.indexOf(pattern) >= 0;
							});
					});
				}
		};

		return player;
	} ();

	var playlist = function () {
		var lastId = 0,
			playlist = {
				init: function (name) {
					this.id = lastId += 1;
					this.name = name;
					this.playables = [];

					return this;
				},
				get name() {
					return this._name;
				},
				set name(currentName) {
					if (!isStringValid(currentName, 3, 25)) {
						throw {
							name: 'InvalidPlaylistNameError',
							message: 'InvalidPlaylistNameError'
						}
					}

					this._name = currentName;
				},
				getAllPlayable: function () {
					return this.playables.slice();
				},
				addPlayable: function (playable) {
					if (playable.id === 'undefined' ||
						!playable.title) {
						throw {
							name: 'InvalidPlayableError',
							message: 'InvalidPlayableError'
						}
					}
					this.playables.push(playable);
					return this;
				},
				getPlayableById: function (id) {
					var i,
						len;
					for (i = 0, len = this.playables.length; i < len; i += 1) {
						if(this.playables[i].id === id) {
							return this.playables[i];
						}
					}

					return null;
				},
				removePlayable: function (idOrPlayable) {
					var id = idOrPlayable;
					if (typeof id === 'undefined') {
						throw {
							name: 'InvalidIdError',
							message: 'InvalidIdError'
						}
					}

					if (typeof(idOrPlayable) !== 'number') {
						// in this case we take ID from PLAYABLE
						id = idOrPlayable.id;
					}

					var removeIndex = this.playables.findIndex(function (playable) {
						return playable.id === id;
					});

					if (removeIndex < 0) {
						throw {
							name: 'IdSearchError',
							message: 'IdSearchError'
						};
					}

					this.playables.splice(removeIndex, 1);
					return this;
				},
				listPlaylables: function (page, size) {
					/*
						page*size > COUNT_OF_PLAYABLE_IN_PLAYLIST
						page < 0
						size <= 0
						page*size , (page + 1) * size
						(0, 10)
						0 1 2 3 4 5 6 7 8 9
					*/
					if (typeof(page) === 'undefined' ||
						typeof(size) === 'undefined' ||
						page < 0 ||
						size <= 0) {
						throw {
							name: 'InvalidPageSizeError',
							message: 'InvalidPageSizeError'
						};
					}

					return this.playables.slice(page * size, (page + 1) * size);
				}
		};

		return playlist;
	} ();

	var playable = function () {
		var lastId = 0,
			playable = {
				init: function (title, author) {
					this.id = lastId += 1;
					this.title = title;
					this.author = author;
					return this;
				},
				get title() {
					return this._title;
				},
				set title(currentTitle) {
					if(!isStringValid(currentTitle, 3, 25)) {
						throw {
							name: 'InvalidTitleError',
							message: 'InvalidTitleError'
						};
					}

					this._title = currentTitle;
				},
				get author() {
					return this._author;
				},
				set author(currentAuthor) {
					if(!isStringValid(currentAuthor, 3, 25)) {
						throw {
							name: 'InvalidAuthorError',
							message: 'InvalidAuthorError'
						};
					}
					
					this._author = currentAuthor;
				},
				play: function () {
					// [id]. [title] - [author]
					var stringResult = '[' + this.id + ']. [' + this.title + '] - [' + this.author + ']';
					return stringResult;
				}
			}

		return playable;
	} ();

	var audio = function (parent) {
		var audio = Object.create(parent);

		audio.init = function (title, author, length) {
			parent.init.call(this, title, author)
			this.length = length;
			return this;
		};

		audio.play = function () {
			return parent.play.call(this) + ' - ' + '[' + this.length + ']';
		};

		Object.defineProperty(audio, 'length', {
			get: function () {
				return this._length;
			},
			set: function (currentLength) {
				if (typeof currentLength !== 'number' ||
					currentLength <= 0) {
					throw {
						name: 'InvalidLengthError',
						message: 'InvalidLengthError'
					};
				}
				this._length = currentLength;
			}
		});

		return audio;
	} (playable);

	var video = function (parent) {
		var video = Object.create(parent);

		video.init = function (title, author, imdbRating) {
			parent.init.call(this, title, author, imdbRating);
			this.imdbRating = imdbRating;
		};

		video.play = function () {
			parent.play.call(this) + ' - ' + '[' + this.imdbRating + ']';
		};
		
		Object.defineProperty(video, 'imdbRating', {
			get: function () {
				return this._imdbRating;
			},
			set: function (currentImdbRating) {
				if (typeof currentImdbRating !== 'number' ||
					currentImdbRating < 1 || 
					currentImdbRating > 5) {
					throw {
						name: 'InvalidImdbRatingError',
						message: 'InvalidImdbRatingError'
					};
				}
				this._imdbRating = currentImdbRating;
			}
		});

		return video;
	} (playable);

	var module = {
	    getPlayer: function (name){
	        return Object.create(player).init(name);
	    },
	    getPlaylist: function(name){
	        return Object.create(playlist)
                .init(name);
	    },
	    getAudio: function(title, author, length){
	        //returns a new audio instance with the provided title, author and length
	        return Object.create(audio)
	        	.init(title, author, length);
	    },
	    getVideo: function(title, author, imdbRating){
	        //returns a new video instance with the provided title, author and imdbRating
	        return Object.create(audio)
	        	.init(title, author, imdbRating);
	    }
	};

	return module;
};


module.exports = solve;


var module = solve();
// console.log(module)
var player = module.getPlayer('John\'s Player');
var playlist = module.getPlaylist('The BG');
// console.log(typeof playlist)
// console.log(Object.getOwnPropertyNames(playlist))
// playlist.addPlayable(module.getAudio('Te sa zeleni', 'Keranov', 3.37));

playlist.addPlayable(module.getAudio('Te sa zeleni', 'Keranov', 3.37))
    .addPlayable(module.getAudio('Te sa cherni', 'Chernio', 45));
player.addPlaylist(playlist);

var playlist2 = module.getPlaylist('GOsho\' Playlist');
playlist2.addPlayable(module.getAudio('Te sa zeleni', 'Keranov', 3.37));
player.addPlaylist(playlist2);
// console.log(player.listPlaylists(0, 100));

console.log(player.search('cherni'));
console.log('***********');
console.log(player.search('te sa'));

console.log('===========');
playlist.removePlaylist(1);
console.log(player.search('te sa'));
