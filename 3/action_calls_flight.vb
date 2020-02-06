WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "Paris"
WpfWindow("HPE MyFlight Sample Applicatio").WpfImage("WpfImage_3").Click 2,8
WpfWindow("HPE MyFlight Sample Applicatio").WpfCalendar("Su").SetDate "15-Sep-2019"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("numOfTickets").Select "3"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 3,4
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutuja"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("NEW SEARCH").Click
WpfWindow("HPE MyFlight Sample Applicatio").Close
