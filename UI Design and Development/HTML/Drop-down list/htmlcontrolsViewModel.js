HTML.Controls = {};
HTML.DayFormat = function (NameofDay) {
    var day = this;
    day.Name = ko.observable(NameofDay);
    return new { Day: day.Name() };
};
HTML.Controls.dropdown = function () {
    /** Variable Declaration ------- Starts */

    var self = this;
    self.WeekDays = ko.observableArray();

    /** Variable Declaration ------- Ends */

    var listdays = ["Sunday",
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday"];
    $.each(listdays, function (idx, day) {
        self.WeekDays.push(new MIDS.DayFormat(day));
    });
    


};