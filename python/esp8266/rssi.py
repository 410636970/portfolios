import network
from machine import Timer

wlan = network.WLAN(network.STA_IF) 

def connectAP(ssid, pwd):
	if not wlan.isconnected():
		wlan.active(True)
		wlan.connect(ssid, pwd)        
		while not wlan.isconnected():
			pass 

connectAP("minminphone", "87878787")
print('network config:', wlan.ifconfig())

print('學號:410636970,姓名:張珈維')

tim = Timer(-1)
tim.init(period=2000, mode=Timer.PERIODIC,callback=lambda t:print('RSSI:', wlan.status('rssi')))
 
try:
	while True:
		pass
except:
	tim.deinit()
	print('bye!')
