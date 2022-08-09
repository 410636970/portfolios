// 定義腳位
#define PIN_0 10
#define PIN_g 8
#define PIN_c 4
#define PIN_h 9
#define PIN_d 5
#define PIN_e 6
#define PIN_b 3
#define PIN_1 11
#define PIN_2 12
#define PIN_f 7
#define PIN_a 2
#define PIN_3 13
#define SW A2

#define POS_NUM 4    // 共有4個七段顯示器，分別由針腳PIN_0、PIN_1、PIN_2、PIN_3控制
#define SEG_NUM 8    // 七段顯示器裡有8個LED（包含小數點）
const byte pos_pins[POS_NUM] = {PIN_0, PIN_1, PIN_2, PIN_3};
const byte seg_pins[SEG_NUM] = {PIN_a, PIN_b, PIN_c, PIN_d, PIN_e, PIN_f, PIN_g, PIN_h};

// 底下定義由七段顯示器顯示數字時所需要的資料
#define t true
#define f false
const boolean data[10][SEG_NUM] = {
  {t, t, t, t, t, t, f, f}, // 0
  {f, t, t, f, f, f, f, f}, // 1
  {t, t, f, t, t, f, t, f}, // 2
  {t, t, t, t, f, f, t, f}, // 3
  {f, t, t, f, f, t, t, f}, // 4
  {t, f, t, t, f, t, t, f}, // 5
  {t, f, t, t, t, t, t, f}, // 6
  {t, t, t, f, f, f, f, f}, // 7
  {t, t, t, t, t, t, t, f}, // 8
  {t, t, t, t, f, t, t, f}, // 9
};

// 一支方便的函式，以格式字串輸出到序列埠
void pf(const char *fmt, ... ){
    char tmp[128]; // max is 128 chars
    va_list args;
    va_start (args, fmt );
    vsnprintf(tmp, 128, fmt, args);
    va_end (args);
    Serial.print(tmp);
}

// 設定某個七段顯示器所顯示的數字，
// 參數pos為0~3，指出想要更新哪一個七段顯示器，
// 參數n為0~9，顯示數字
void setDigit(int pos, int n){
  if(pos < 0 || 3 < pos){
    pf("error pos=%d\n", pos);
    return;
  }
  // 控制想要更新哪一個七段顯示器，將其腳位設為LOW
  // 其他腳位則設為HIGH，代表不更新。 
  for(int p = 0; p <POS_NUM; p++){
    if(p == pos)
      digitalWrite(pos_pins[p], LOW);
    else
      digitalWrite(pos_pins[p], HIGH);
  }
  
  // 寫入數字 
  if(0 <= n && n <= 9){
    for(int i = 0; i < SEG_NUM; i++){
      digitalWrite(seg_pins[i], data[n][i] == t ? HIGH : LOW);
    }
  }
  else{
    for(int i = 0; i < SEG_NUM; i++){
      digitalWrite(seg_pins[i], LOW);
    }
    digitalWrite(PIN_h, HIGH);
    pf("error pos=%d, n=%d\n", pos, n);
  }
}

// 設定整個四合一型七段顯示器想要顯示的數字
void setNumber(int timesum,boolean state)
{
  int n0,n1,n2,n3;
  if(state==true){
    n1 = ((timesum%3600L)%60L)/10L;
    n0=((timesum%3600L)%60L)%10L;

    setDigit(0, n0); delay(5);
    setDigit(1, n1); delay(5);
  }
  if(state==false){
    n3 = (timesum / 3600L)/10L;
    n2 = (timesum /3600L)%10L;
    n1 = ((timesum%3600L)/60L)/10L;
    n0=((timesum%3600L)/60L)%10L;
    
    setDigit(0, n0); delay(5);
    setDigit(1, n1); delay(5);
    setDigit(2, n2); delay(5);
    setDigit(3, n3); delay(5);
  } 
}

unsigned long time_previous;
boolean state= false;
boolean buttonUp = true;
//藍芽連線
#include <SoftwareSerial.h>
#include <string.h>
SoftwareSerial BT(A1,A0);// 接收,發送
void setup() {
  Serial.begin(9600);
  BT.begin(9600);
  for(int i = 0; i < POS_NUM; i++){
    pinMode(pos_pins[i], OUTPUT);
    digitalWrite(pos_pins[i], HIGH);
  }
  for(int i = 0; i < SEG_NUM; i++){
    pinMode(seg_pins[i], OUTPUT);
    digitalWrite(seg_pins[i], LOW);
  }
  Serial.println("BT is ready!");
  pinMode(SW, INPUT);
  digitalWrite(SW,HIGH);
  time_previous=millis();
}

String timenumber;
String Stringsplit[3];
int H,M,S;
long timesum;

void strsplit(String timenumber){
  int count=0;                
  for(int i=0;i<timenumber.length();i++){
          
    if(timenumber[i]-48>=0 && timenumber[i]-48<=9){
      Stringsplit[count]=Stringsplit[count]+timenumber[i];
    }
    else if(timenumber[i]==':'){
       count++;
    }
  }
  
}

void loop() {
  if (BT.available() ){
    while (BT.available() ){
      timenumber=BT.readString();
      strsplit(timenumber);
      H=Stringsplit[0].toInt();
      M=Stringsplit[1].toInt();
      S=Stringsplit[2].toInt();
      timesum=(H*3600L)+(M*60L)+S*1L;
    }
  }
  unsigned long time_now=millis();
  if(time_now-time_previous>1000){
    timesum=timesum+1L;
    time_previous+=1000;
  }
  if(timesum>=86400L){
    timesum=0;
  }   
  setNumber(timesum,state);
  if(digitalRead(A2)!=HIGH && buttonUp ==true){
    state = !state;
    buttonUp =false;
  }
  else if(digitalRead(A2) == HIGH && buttonUp !=true){
    buttonUp = true;
  }
}
