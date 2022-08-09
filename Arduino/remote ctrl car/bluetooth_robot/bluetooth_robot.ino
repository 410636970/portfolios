#include <SoftwareSerial.h>
#include <string.h>

/*int RM_speed=5; //右輪速度
int LM_speed=6; //左輪速度
int RM_direction=7; //右輪方向
int LM_direction=8; //左輪方向*/

const int leftMotorIn1 = 5;
const int leftMotorIn2 = 6;
const int rightMotorIn3 = 7;
const int rightMotorIn4 = 8;

SoftwareSerial BT(2,3); // 接收, 傳送
const byte ledPin = 13;
char val; // 儲存接收資料的變數
String recStr; // 儲存接收資料的變數
int recStrLen;

void setup(){
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
  pinMode(rightMotorIn3,OUTPUT);
  pinMode(leftMotorIn1,OUTPUT);
  pinMode(leftMotorIn2,OUTPUT);
  pinMode(rightMotorIn4,OUTPUT);
}

void loop(){
  if (Serial.available() ){
    val = Serial.read();
    
    switch(val){
      case '8':
        forward();
        break;
       case '2':
        backward();
        break;
       case '4':
        left();
        break;
       case '6':
        right();
        break;
       case '5':
        motorstop();
        break;
    }
  }
  
  
} 

void motorstop(){//停止
  digitalWrite(leftMotorIn1, LOW);
  digitalWrite(leftMotorIn2, LOW);
  digitalWrite(rightMotorIn3, LOW);
  digitalWrite(rightMotorIn4, LOW);
}

void forward(){//前進
  digitalWrite(leftMotorIn1, HIGH);
  digitalWrite(leftMotorIn2, LOW);
  digitalWrite(rightMotorIn3, HIGH);
  digitalWrite(rightMotorIn4, LOW);
}

void backward(){//後退
  digitalWrite(leftMotorIn1, LOW);
  digitalWrite(leftMotorIn2, HIGH);
  digitalWrite(rightMotorIn3, LOW);
  digitalWrite(rightMotorIn4, HIGH);
}

void right(){//右轉
    digitalWrite(leftMotorIn1, HIGH);
    digitalWrite(leftMotorIn2, LOW);
    digitalWrite(rightMotorIn3, LOW);
    digitalWrite(rightMotorIn4, LOW);
}

void left(){//左轉
    digitalWrite(leftMotorIn1, LOW);
    digitalWrite(leftMotorIn2, LOW);
    digitalWrite(rightMotorIn3, HIGH);
    digitalWrite(rightMotorIn4, LOW);
}
