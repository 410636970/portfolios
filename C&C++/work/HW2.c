//410636970 張珈維 
#include <stdio.h>
int main() {

  char name[255]="張珈維";
  char sid[] = "410636970";
  printf("my name is %s my id=%s \n", name, sid);
  
  float h;
  float w; 
  puts("please input your height<cm> and weight<kg>:");
  fflush(stdin);
  scanf("%f",&h);
  while(h<100 || h>250){
  	printf("身高輸入異常");
  	break;
  }
  scanf("%f",&w);
  while(w<0 || w>300){
  	printf("體重輸入異常");
  	break;
  }
  
  h=h/100;
  float BMI=w/(h*h);
  printf("BMI is %f\n",BMI);
  
  if(BMI<18.5)
  	printf("體重過輕");
  else if(BMI>=18.5 && BMI<24)
  	printf("正常範圍");
  else if(BMI>=24 && BMI<27)
  	printf("過重"); 
  else if(BMI>=27 && BMI<30)
  	printf("輕度肥胖"); 
  else if(BMI>=30 && BMI<35)
  	printf("中度肥胖"); 
  else if(BMI>=35)
  	printf("重度肥胖"); 
}
