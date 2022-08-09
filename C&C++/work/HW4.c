//±iÏÉºû 410636970 
#include <stdio.h>

void sort(int a,int b){
	int k=0;
	if(a>=b){
		k=a;
		a=b;
		b=k;
		
	}
	printf("%d %d\n",a,b);
}

int main() {
	int a,b;
	puts("please enter two number:");
	scanf("%d %d",&a,&b);
	while(a!=b){
 		sort(a,b);
 		puts("please enter two number:");
		scanf("%d %d",&a,&b);
	} 
	if(a==b)
		printf("%d %d",a,b);
}
