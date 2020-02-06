SystemUtil.Run "C:\Program Files (x86)\HPE\Unified Functional Testing\samples\Flights Application\FlightsGUI.exe"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7893e5bb38beee76d1"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 3,1
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click DataTable("select_flight", dtGlobalSheet)
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").set "rutuja"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").Close
