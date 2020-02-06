SystemUtil.Run "C:\Program Files (x86)\HPE\Unified Functional Testing\samples\Flights Application\FlightsGUI.exe"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set"john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure"5d78c2e180ae3ff13999"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").Select "London"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "Sydney"
WpfWindow("HPE MyFlight Sample Applicatio").WpfCalendar("datePicker").SetDate "24/sep/2019"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("Class").Select "First"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("numOfTickets").Select "7"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 5,4
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutuja"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
