
//Bootstrap Custom Calendar Initialization
$('#calendar').datepicker({

    // If true, manually-entered dates with two-digit years, such as “5/1/15”, will be parsed as “2015”, not “15”. 
    // If the year is less than 10 years in advance, the picker will use the current century, otherwise, it will use the previous one. 
    // For example “5/1/15” would parse to May 1st, 2015, but “5/1/97” would be May 1st, 1997.
    assumeNearbyYear: false,

    // Auto close the datepicker immediately when a date is selected
    autoclose: false,

    // Callback functions
    beforeShowDay: $.noop,
    beforeShowMonth: $.noop,
    beforeShowYear: $.noop,
    beforeShowDecade: $.noop,
    beforeShowCentury: $.noop,

    // Show week numbers to the left of week rows
    calendarWeeks: false,

    // Show a “Clear” button at the bottom of the datepicker to clear the input value
    clearBtn: false,

    // Selecting the currently active date in the datepicker will unset the respective date
    toggleActive: false,

    // Days of the week that should be disabled
    daysOfWeekDisabled: [],

    // Days of the week that should be highlighted
    daysOfWeekHighlighted: [],

    // Array of date strings or a single date string formatted in the given date format
    datesDisabled: [],

    // The latest date that may be selected; all later dates will be disabled
    endDate: Infinity,

    // Force parsing of the input value when the picker is closed
    forceParse: true,

    // Date format
    format: 'dd/mm/yyyy',

    // Only effective in a range picker. 
    // If true, the selected value does not get propagated to other, currently empty, pickers in the range.
    keepEmptyValues: false,

    // Enable keyboard navigation
    keyboardNavigation: true,

    // Default language
    language: 'es',

    // Set a minimum limit for the view mode. 
    // Accepts: 0 or “days” or “month”, 1 or “months” or “year”, 2 or “years” or “decade”, 3 or “decades” or “century”, and 4 or “centuries” or “millenium”. 
    // Gives the ability to pick only a month, a year or a decade. 
    // The day is set to the 1st for “months”, and the month is set to January for “years”, the year is set to the first year from the decade for “decades”, and the year is set to the first from the millennium for “centuries”.
    minViewMode: 0,

    // Set a maximum limit for the view mode. 
    // Accepts: 0 or “days” or “month”, 1 or “months” or “year”, 2 or “years” or “decade”, 3 or “decades” or “century”, and 4 or “centuries” or “millenium”. 
    // Gives the ability to pick only a day, a month, a year or a decade. 
    // The day is set to the 1st for “months”, the month is set to January for “years”, the year is set to the first year from the decade for “decades”, and the year is set to the first from the millennium for “centuries”.
    maxViewMode: 4,

    // Enable multidate picking. 
    // Each date in month view acts as a toggle button, keeping track of which dates the user has selected in order.
    multidate: false,

    // The string that will appear between dates when generating the input’s value.
    multidateSeparator: ',',

    // A space-separated string consisting of one or two of “left” or “right”, “top” or “bottom”, and “auto” (may be omitted)
    orientation: "auto",

    // Enable RTL
    rtl: false,

    // The earliest date that may be selected; all earlier dates will be disabled.
    startDate: -Infinity,

    // The view that the datepicker should show when it is opened. 
    // Accepts: 0 or “days” or “month”, 1 or “months” or “year”, 2 or “years” or “decade”, 3 or “decades” or “century”, and 4 or “centuries” or “millenium”. 
    // Useful for date-of-birth datepickers.
    startView: 0,

    // If true or “linked”, displays a “Today” button at the bottom of the datepicker to select the current date. 
    // If true, the “Today” button will only move the current date into view; if “linked”, the current date will also be selected.
    todayBtn: false,

    // Highlight the current date.
    todayHighlight: false,

    // If false viewDate is set according to value on initialization and updated * if a day in last oder next month is selected or * if dates are changed by setDate, setDates, setUTCDate and setUTCDates methods. 
    // If multidate option is true the last selected date or the last date in array passed to setDates or setUTCDates is used.
    updateViewDate: true,

    // Day of the week start. 0 (Sunday) to 6 (Saturday)
    weekStart: 0,

    // If true, no keyboard will show on mobile devices
    disableTouchKeyboard: false,

    // If false the datepicker will not show on a readonly datepicker field
    enableOnReadonly: true,

    // If false, the datepicker will be prevented from showing when the input field associated with it receives focus.
    showOnFocus: true,

    // The CSS z-index of the open datepicker is the maximum z-index of the input and all of its DOM ancestors plus the zIndexOffset.
    zIndexOffset: 10,

    // Appends the date picker <a href="https://www.jqueryscript.net/tags.php?/popup/">popup</a> to a specific element; eg: container: ‘#picker-container’
    container: 'body',

    // If true, selecting a year or month in the datepicker will update the input value immediately. 
    // Otherwise, only selecting a day of the month will update the input value immediately.
    immediateUpdates: false,

    // The string that will appear on top of the datepicker. If empty the title will be hidden.
    title: '',

    // The templates used to generate some parts of the picker. 
    // Each property must be a string with only text, or valid html. 
    // You can use this property to use custom icons libs. 
    templates: {
        leftArrow: '&#x00AB;',
        rightArrow: '&#x00BB;'
    },

    // If false, the datepicker will not append the names of the weekdays to its view. 
    showWeekDays: true

});