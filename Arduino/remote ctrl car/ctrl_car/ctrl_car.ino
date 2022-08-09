#include <SoftwareSerial.h>
SoftwareSerial BT(0,1); // 接收, 傳送
#include <string.h>
int LM_direction=8; //左輪方向
int LM_speed=6; //左輪速度
int RM_speed=5; //右輪速度
int RM_direction=7; //右輪方向
int fspeed=0;
boolean cardirection=1;

const byte trigPin = 2;// 觸發信號
const byte echoPin = 3; // 回應接收

void setup() {
  // put your setup code here, to run once:
  pinMode(trigPin, OUTPUT);//觸發腳
  pinMode(echoPin, INPUT); //接收腳
  Serial.begin(9600);
  BT.begin(9600);
  pinMode(RM_direction,OUTPUT);
  pinMode(RM_speed,OUTPUT);
  pinMode(LM_speed,OUTPUT);
  pinMode(LM_direction,OUTPUT); 
}

void loop() {
char direct;
if(BT.available()){
direct=BT.read();
Serial.println(direct);//return val;
}

if(direct=='8'){
digitalWrite(RM_direction,1);
analogWrite(RM_speed,190);
analogWrite(LM_speed,190);
digitalWrite(LM_direction,1);  
}

else if(direct=='2'){
digitalWrite(RM_direction,0);
analogWrite(RM_speed,200);
analogWrite(LM_speed,200);
digitalWrite(LM_direction,0);  
}

else if(direct=='6'){
digitalWrite(RM_direction,0);
analogWrite(RM_speed,0);
analogWrite(LM_speed,180);
digitalWrite(LM_direction,1);  
}

else if(direct=='4'){
digitalWrite(RM_direction,1);
analogWrite(RM_speed,180);
analogWrite(LM_speed,0);
digitalWrite(LM_direction,0);  
}

else if(direct=='5'){
digitalWrite(RM_direction,0);
analogWrite(RM_speed,0);
analogWrite(LM_speed,0);
digitalWrite(LM_direction,0);
}

}

char ReadNum_bluetooth(){
char val;
if(BT.available()){
val=BT.read();
Serial.println(val);
return val;
}
}
