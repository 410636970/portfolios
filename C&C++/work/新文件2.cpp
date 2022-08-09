//410636970 ±iÏÉºû 
#include <stdio.h>
#include<stdlib.h>
#include<time.h> 
int main(int argc, char* argv[]){
	if(argc > 1) {
	     puts(argv[0]); 
	     puts(argv[1]);    
	}
	int x=-5;
	printf("%x \n",x); 
	printf("these things are %d, %s, %f, %c", x, "joey hsieh", 3.14, 'A');
	srand(time(NULL));
	printf("%d %d %d %d",rand(),rand(),rand(),rand());
	
	return 0;
}

