#include <SoftwareSerial.h>
#include <string.h>

const int RMs = 5; //右輪速度
const int LMs = 6; //左輪速度
const int RMd = 7; //右輪方向
const int LMd = 8; //左輪方向

//sensor接角
const int D1 = A0;
const int D2 = A1;
const int D3 = A2;
const int D4 = A3;
const int D5 = A4;

int sum;//sensor總值

int val; // 儲存接收資料的變數
String recStr; // 儲存接收資料的變數
int recStrLen;

void setup(){
  Serial.begin(9600);
  pinMode(RMd,OUTPUT);
  pinMode(RMs,OUTPUT);
  pinMode(LMs,OUTPUT);
  pinMode(LMd,OUTPUT); 
  
  pinMode(D1,INPUT_PULLUP);
  pinMode(D2,INPUT_PULLUP);
  pinMode(D3,INPUT_PULLUP);
  pinMode(D4,INPUT_PULLUP);
  pinMode(D5,INPUT_PULLUP);
}

void loop(){
  /*val = analogRead(D1);
  Serial.print(val);
  Serial.print(" ");
  val = analogRead(D2);
  Serial.print(val);
  Serial.print(" ");
  val = analogRead(D3);
  Serial.print(val);
  Serial.print(" ");
  val = analogRead(D4);
  Serial.print(val);
  Serial.print(" ");
  val = analogRead(D5);
  Serial.print(val);
  Serial.println(" ");*/
  
  /*if(analogRead(D1)<700)
  Serial.println("black");
  if(analogRead(D1)>700)
  Serial.println("white");*/
  
  if(analogRead(D1)>700 && analogRead(D2)>700 && analogRead(D3)<700 && analogRead(D4)>700 && analogRead(D5)>700){
    Forward();
    Serial.println("Fw");
  }
  else if(analogRead(D1)>700 && analogRead(D2)>700 && analogRead(D4)<700){
    sRight();
    Serial.println("sR");
  }
  else if(analogRead(D1)>700 && analogRead(D2)>700 && analogRead(D5)<700){
    bRight();
    Serial.println("bR");
  }
  else if(analogRead(D2)<700 && analogRead(D4)>700 && analogRead(D5)>700){
    sLeft();
    Serial.println("sL");
  }
  else if(analogRead(D1)<700 && analogRead(D4)>700 && analogRead(D5)>700){
    bLeft();
    Serial.println("bL");
  }
  else
    Serial.println("error");
  /*
  digitalWrite(RMd,1);
  analogWrite(RMs,0);
  digitalWrite(LMd,1);
  analogWrite(LMs,0);
  */
}

void Forward(){
  digitalWrite(RMd,1);
  analogWrite(RMs,190);
  digitalWrite(LMd,1);
  analogWrite(LMs,190);
}

void sRight(){
  digitalWrite(RMd,0);
  analogWrite(RMs,0);
  digitalWrite(LMd,1);
  analogWrite(LMs,180);
}

void bRight(){
  digitalWrite(RMd,0);
  analogWrite(RMs,0);
  digitalWrite(LMd,1);
  analogWrite(LMs,160);
}

void sLeft(){
  digitalWrite(RMd,1);
  analogWrite(RMs,180);
  digitalWrite(LMd,0);
  analogWrite(LMs,0);
}

void bLeft(){
  digitalWrite(RMd,1);
  analogWrite(RMs,160);
  digitalWrite(LMd,0);
  analogWrite(LMs,0);
}
/*
small
digitalWrite(RM_direction,1);
analogWrite(RM_speed,0);
analogWrite(LM_speed,255);
digitalWrite(LM_direction,0);
big
digitalWrite(RM_direction,0);
analogWrite(RM_speed,100);
analogWrite(LM_speed,100);
digitalWrite(LM_direction,1);
*/
