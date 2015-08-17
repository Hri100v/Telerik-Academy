function solve() {
    $.fn.datepicker = function () {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };

        var $this = this;
        var now = new Date();
        var currentDate = new Date();
        var wrapper = $('<div />').addClass('datepicker-wrapper');
        $this.addClass('datepicker').wrap(wrapper);
        wrapper = $this.parent();
        //var testDate = new Date(2011, 0, 13);
        //console.log(testDate.toLocaleDateString('it'));
        var picker = $('<div />');
        picker.addClass('picker');
        //var nowDay = now.getDayName();
        //var nowMonth = now.getMonthName();


        //function getDateInObject(currentDate) {
        //    var day = currentDate.getDate();
        //    var month = currentDate.getMonth() + 1; // (currentDate.getMonth().length) === 1 ? (currentDate.getMonth() + 1) : '0' + (currentDate.getMonth() + 1);
        //    var year = currentDate.getFullYear();
        //    //var result = day + '/' + month + '/' + year;
        //    var result = {
        //        day: day,
        //        month: month,
        //        year: year
        //    };
        //    return result;
        //}

        //var currentDate = getDateInObject(now);
        //function formattingDate(currentDate) {
        //    var result = currentDate.day + '/' + currentDate.month + '/' + currentDate.year;

        //    return result;
        //}

        //var testDateFormat = formattingDate(currentDate);
        //console.log(testDateFormat);


        //var month = 0; // January
        //var d = new Date(2008, month + 2, 1);
        //console.log(d); // last day in January
        //var outerDiv = $('<div />');
        //outerDiv.addClass('outer-div');
        //var innerDiv = $('<div />');
        //innerDiv.addClass('inner-div');
        //innerDiv.text('something');
        //innerDiv.wrap(outerDiv);
        //outerDiv = innerDiv.parent();
        //wrapper.append(outerDiv);

        var controls = $('<div />');
        controls.addClass('controls').appendTo(picker);

        var buttonLeft = $('<button />').addClass('btn').text('<').appendTo(controls);
        var innerMonth = $('<div />').addClass('current-month').text(currentDate.getMonthName()).appendTo(controls);
        var buttonRight = $('<button />').addClass('btn').text('>').appendTo(controls);
        
        var calendar = buildCalendar().appendTo(picker);

        var currentDateDiv = $('<div />').addClass('current-date').appendTo(picker);
        $('<a />')
            .attr('href', '#')
            .addClass('current-date-link')
            .text(currentDate.getDate() + ' ' + currentDate.getMonthName() + ' ' + currentDate.getFullYear())
            .appendTo(currentDateDiv)
            .on('click', function () {
                setValue(now);
                togglePickerVisibility();
            });

        $this.on('click', function () {
            togglePickerVisibility();
        });

        // create calendar ----->
        function buildCalendar(date) {
            var CALENDAR_ROWS = 6;
            date = date || new Date();
            var year = year || date.getFullYear();
            var month = month || date.getMonth();
            var calendar = $('<table />').addClass('calendar');
            var headerRow = $('<tr />').appendTo(calendar);
            for (var i = 0, len = WEEK_DAY_NAMES.length; i < len; i += 1) {
                $('<th />').text(WEEK_DAY_NAMES[i]).appendTo(headerRow);
            }

            var firstDayOfMonth = new Date(year, month, 1);
            var firstDayOfMonthWeekDay = firstDayOfMonth.getDay();
            var lastDayOfMonth = new Date(firstDayOfMonth.setMonth(month + 1) - 1).getDate();

            var previousMonthRendered = false;
            var inNextMonth = false;
            var startNext = 0;
            var currentDayRendered = 1;

            for (var i = 0; i < CALENDAR_ROWS; i += 1) {
                var row = $('<tr />').appendTo(calendar);
                // Previous month numbers
                if (!previousMonthRendered) {
                    var previousMonthDays = firstDayOfMonthWeekDay;
                    var previousFirstDayOfMonth = new Date(year, month - 1, 1);
                    var previousMonthLastDay = new Date(previousFirstDayOfMonth.setMonth(month) - 1).getDate();
                    var startIndex = previousMonthLastDay - previousMonthDays + 1;
                    if (startIndex > previousMonthLastDay) {
                        startIndex -= 7;
                    }

                    for (var j = startIndex, len = previousMonthLastDay; j < len; j += 1) {
                        $('<td />').addClass('another-month').text(j).appendTo(row);
                        startNext += 1;
                    }
                    previousMonthRendered = true;
                }

                // Current month numbers
                for (var j = startNext; j < 7; j+=1) {
                    var cell = $('<td />').text(currentDayRendered).appendTo(row);
                    if (!inNextMonth) {
                        cell.addClass('current-month');
                    } else {
                        // Next month numbers
                        cell.addClass('another-month');
                    }

                    currentDayRendered += 1;
                    if (currentDayRendered > lastDayOfMonth) {
                        currentDayRendered = 1;
                        inNextMonth = true;
                    }

                    startNext += 1;
                }

                startNext = 0;
            }
            
            return calendar;
        }

        controls.on('click', 'button', function () {
            var operation = parseInt($(this).date('operation'));
            var date = new Date(currentDate.setMonth(currentDate.getMonth() + operation));
            buildCalendar(date).replaceAll('.calendar');
            setInnerMonth(date);
        });

        wrapper.on('click', 'td.current-month', function () {
            var $this = $(this);
            setValue(new Date(currentDate.setDate($this.text())));
            togglePickerVisibility();
        });

        $(document).click(function (ev) {
            if (!$(ev.target).parents('.datepicker-wrapper').length) {
                if (picker.hasClass('picker-visible')) {
                    togglePickerVisibility();
                }
            }
        });

        function setInnerMonth(date) {
            innerMonth.text(date.getMonthName() + ' ' + date.getFullYear());
        }

        function setValue(date) {
            $this.val(date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear());
        }

        function togglePickerVisibility() {
            picker.toggleClass('picker-visible');
        }

        wrapper.append(picker);
        //console.log($this);
        return $this;
        //// you are welcome :)
        //var date = new Date();
        //console.log(date.getDayName());
        //console.log(date.getMonthName());
    };
};

module.exports = solve;