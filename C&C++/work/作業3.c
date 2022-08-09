//410636970 ±iÏÉºû 
#include <stdio.h>
int main() {

  //char ch;
  //int y;
  //float ff;
  char name[255]="±iÏÉºû";
  char sid[] = "410636970";
  //int age=19;
  float h;
  float w;
  
  float a,b,c;
  
  
  printf("my name is %s my id=%s \n", name, sid);
  
  
  puts("please input your weight<kg> and height<m>:");
  fflush(stdin);
  scanf("%f %f",&w,&h);
  fflush(stdin);
  scanf("%f %f %f",&a,&b,&c);
  
  float BMI=w/(h*h);
  float d=(a+b+c)/3;
  
  //printf("the things are =%d %f %c",y, ff, ch);
  printf("weight=%f hight=%f BMI=%f\n",w,h,BMI);
  printf("my score is=%f %f %f\naverage score=%f",a,b,c,d);

}
