#include <SoftwareSerial.h>
#include <string.h>
SoftwareSerial BT(10, 9); // 接收, 傳送
const byte ledPin = 13;
char val; // 儲存接收資料的變數
String recStr; // 儲存接收資料的變數
int recStrLen;
void setup() {
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}
void loop() {
  if (Serial.available() ){
    val = Serial.read();
    switch (val) {
      case '0': // 若接收到0...
        digitalWrite(ledPin, LOW); // 關閉LED
        break;
      case '1': // 若接收到1...
        digitalWrite(ledPin, HIGH); // 點亮LED
        break;
    }
  }
}

