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
        var currentMonth = new Date();

        var divCalHeader = $('<div>');
        var leftArrHeader = $('<a>').addClass('btn').text(' < ');
        var rightArrHeader = $('<a>').addClass('btn').text(' > ');
        var spanHeader = $('<span>').text(MONTH_NAMES[currentMonth.getMonth()]);
        divCalHeader.append(leftArrHeader).append(spanHeader).append(rightArrHeader);

        var $input = $(this);
        var $container = $input.parent();
        var $datepickerWrapper = $('<div/>').addClass('datepicker-wrapper');
        // create calendar
        var $calendar = $('<div/>').addClass('calendar');
        var calRows = 6;
        var calCols = WEEK_DAY_NAMES.length;
        var $calendarTable = $('<table border="1"/>');
        var $calendarThead = $('<thead/>');
        var $calendarTbody = $('<tbody/>');
        var $calendarTr = $('<tr/>');
        var $calendarTh = $('<th/>');
        var $calendarTd = $('<td/>');

        var trThead = $calendarTr.clone(true)
        for (var i = 0; i < calCols; i+=1) {
            trThead.append($calendarTh.clone(true).text(WEEK_DAY_NAMES[i]));
        }
        $calendarThead.append(trThead);

        var row, col
        for (row = 0; row < calRows; row += 1) {
            var currentTR = $calendarTr.clone(true);
            for (col = 0; col < calCols; col += 1) {
                currentTR.append($calendarTd.clone(true).text(col + row));
            }
            $calendarTbody.append(currentTR);
        }
        

        $calendarTable.append($calendarThead);
        $calendarTable.append($calendarTbody);

        $calendar.append($calendarTable);




        $datepickerWrapper.append($input);
        $datepickerWrapper.append(divCalHeader);
        $datepickerWrapper.append($calendar);
        $container.append($datepickerWrapper);

        return this;
        // you are welcome :)
        var date = new Date();
        console.log(date.getDayName());
        console.log(date.getMonthName());
    };
}

module.exports = solve;