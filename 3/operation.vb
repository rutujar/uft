WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").GetROProperty("text")
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7a14dbe20b57584280"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").Select "Paris"
b=WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").GetROProperty("value")
msgbox b
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "Frankfurt"
WpfWindow("HPE MyFlight Sample Applicatio").WpfImage("WpfImage").Click 10,9
WpfWindow("HPE MyFlight Sample Applicatio").WpfCalendar("datePicker").SetDate "21-Sep-2019"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("Class").Select "Business"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("numOfTickets").Select "2"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").RowCount
c=WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").GetCellData(0,0)
msgbox c
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutuja"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").Move 198,139
WpfWindow("HPE MyFlight Sample Applicatio").Close
