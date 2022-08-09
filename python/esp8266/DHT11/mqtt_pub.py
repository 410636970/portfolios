"""
   學號：410636970  姓名：張珈維
"""
import network
import machine
import ubinascii
import time
from machine import Pin
from umqtt.simple import MQTTClient

wlan = network.WLAN(network.STA_IF)

def connectAP(ssid, pwd):
    if not wlan.isconnected():
        wlan.active(True)
        wlan.connect(ssid, pwd)
        
        while not wlan.isconnected():
            pass

connectAP("minminphone", "87878787")
print('network config:', wlan.ifconfig())

config = {
    'broker':'mqtt.thingspeak.com',
    'user':'s1063697',
    'key':'64EBL1N9Y8EDQT4K',
    'id' : 'alphasuki/',
    'topic' : b'channels/793150/publish/FBJEW3HCKTJMLA6L'
}

client = MQTTClient(client_id=config['id'],
                    server=config['broker'],
                    user=config['user'],
                    password=config['key'])


data = 'field1=27&field2=40'

client.connect()
client.publish(config['topic'], data.encode())
time.sleep(10)
client.disconnect()