int LM_direction=8; //左輪方向
int LM_speed=6; //左輪速度
int RM_speed=5; //右輪速度
int RM_direction=7; //右輪方向
void setup(){
Serial.begin(9600);
pinMode(RM_direction,OUTPUT);
pinMode(RM_speed,OUTPUT);
pinMode(LM_speed,OUTPUT);
pinMode(LM_direction,OUTPUT);
}
void loop(){
digitalWrite(RM_direction,1);
analogWrite(RM_speed,255);
analogWrite(LM_speed,255);
digitalWrite(LM_direction,1);
} 
