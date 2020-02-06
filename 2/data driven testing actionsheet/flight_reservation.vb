WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "Portland"
WpfWindow("HPE MyFlight Sample Applicatio").WpfImage("WpfImage_3").Click 2,8
WpfWindow("HPE MyFlight Sample Applicatio").WpfCalendar("Su").SetDate "13-Sep-2019"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("numOfTickets").Select "2"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 3,4
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutu"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("NEW SEARCH").Click
WpfWindow("HPE MyFlight Sample Applicatio").Close
