WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7b1ecbecbd61307870"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 4,0
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutu"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("Order 116 completed").Click 58,21
