//410636970 �i�ɺ� 
#include <stdio.h>
int main() {

  char name[255]="�i�ɺ�";
  char sid[] = "410636970";
  printf("my name is %s my id=%s \n", name, sid);
  
  float h;
  float w; 
  puts("please input your height<cm> and weight<kg>:");
  fflush(stdin);
  scanf("%f",&h);
  while(h<100 || h>250){
  	printf("������J���`");
  	break;
  }
  scanf("%f",&w);
  while(w<0 || w>300){
  	printf("�魫��J���`");
  	break;
  }
  
  h=h/100;
  float BMI=w/(h*h);
  printf("BMI is %f\n",BMI);
  
  if(BMI<18.5)
  	printf("�魫�L��");
  else if(BMI>=18.5 && BMI<24)
  	printf("���`�d��");
  else if(BMI>=24 && BMI<27)
  	printf("�L��"); 
  else if(BMI>=27 && BMI<30)
  	printf("���תέD"); 
  else if(BMI>=30 && BMI<35)
  	printf("���תέD"); 
  else if(BMI>=35)
  	printf("���תέD"); 
}
