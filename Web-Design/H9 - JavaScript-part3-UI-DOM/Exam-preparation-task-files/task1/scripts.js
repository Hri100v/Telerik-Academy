function createCalendar(selector, events) {
	var container = document.querySelector(selector);
	var dayBox = document.createElement('div');
	var dayBoxTitle = document.createElement('strong');
	var dayBoxContent = document.createElement('div');
	dayBoxContent.innerHTML = '&nbsp;';

	var daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
	var DAYS_IN_MONTH_COUNT = 30;
	var selectedBox = null;

	// ------- styles -------
	container.style.width = (120 * 7.5) + 'px';

	dayBox.style.margin = '0';
	dayBox.style.padding = '0';
	dayBox.style.border = '1px solid gray';
	dayBox.style.width = '120px';
	dayBox.style.height = '120px';
	dayBox.style.display = 'inline-block';

	dayBoxTitle.style.display = 'block';
	dayBoxTitle.style.background = 'darkgray';
	dayBoxTitle.style.textAlign = 'center';
	dayBoxTitle.style.borderBottom = '1px solid gray';

	dayBoxTitle.className = 'title-event';
	dayBoxContent.className = 'day-content';
	
	dayBox.appendChild(dayBoxTitle);
	dayBox.appendChild(dayBoxContent);

	function createMonthBoxes() {
		var dayBoxes = [];
		for (var i = 0; i < DAYS_IN_MONTH_COUNT; i++) {
			var dayOfWeek = daysOfWeek[i % daysOfWeek.length];
			dayBoxTitle.innerHTML = dayOfWeek + ' ' + 
									(i + 1) + ' ' +
									'Jun 2014';
			dayBoxes.push(dayBox.cloneNode(true));
		}

		return dayBoxes;
	}

	function addCalendarEvents(boxes, events) {
		for (var i = 0; i < events.length; i+=1) {
			var event = events[i];
			var content = boxes[event.date - 1].querySelector('.day-content');
			content.innerHTML = event.hour + ' ' + event.title;
		}
	}

	function onBoxMouseover(ev) {
		if (selectedBox !== this) {
			this.style.background = 'gold';
		}
	}

	function onBoxMouseout(ev) {
		if (selectedBox !== this) {
			this.style.background = '';
		}
	}

	function onBoxClick(ev) {
		if (selectedBox) {
			selectedBox.style.background = '';
		}

		if (selectedBox && selectedBox === this) {
			selectedBox = null;
		} else {
			this.style.background = 'yellowgreen';
			selectedBox = this;
		}
	}

	var boxes = createMonthBoxes();
	addCalendarEvents(boxes, events);

	var docFragment = document.createDocumentFragment();

	for (var i = 0; i < boxes.length; i += 1) {
		docFragment.appendChild(boxes[i]);
		boxes[i].addEventListener('click', onBoxClick);
		boxes[i].addEventListener('mouseover', onBoxMouseover);
		boxes[i].addEventListener('mouseout', onBoxMouseout);
	}

	container.appendChild(docFragment);
}