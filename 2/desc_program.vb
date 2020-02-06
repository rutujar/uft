WpfWindow("devname:=HPE MyFlight Sample Application").WpfEdit("devname:=agentName").Set "john"
WpfWindow("devname:=HPE MyFlight Sample Application").WpfEdit("devname:=password").SetSecure"5d78c2e180ae3ff13999"
WpfWindow("devname:=HPE MyFlight Sample Application").WpfButton("devname:=okButton").Click
WpfWindow("devname:=HPE MyFlight Sample Application").WpfComboBox("devname:=fromCity").Select "London"
WpfWindow("devname:=HPE MyFlight Sample Application").WpfComboBox("devname:=toCity").Select "Sydney"
WpfWindow("devname:=HPE MyFlight Sample Application").WpfComboBox("selection:=Economy").Select "First"
WpfWindow("devname:=HPE MyFlight Sample Application").WpfButton("devname:=FIND FLIGHTS").Click
WpfWindow("devname:=HPE MyFlight Sample Application").WpfTable("devnamepath:=flightsDataGrid;;").SelectCell 1,3
WpfWindow("devname:=HPE MyFlight Sample Application").WpfButton("devname:=selectFlightBtn").Click
WpfWindow("devname:=HPE MyFlight Sample Application").WpfEdit("devname:=passengerName").Set "rutuja"
WpfWindow("devname:=HPE MyFlight Sample Application").WpfButton("devname:=orderBtn").Click
WpfWindow("devname:=HPE MyFlight Sample Application").Close
