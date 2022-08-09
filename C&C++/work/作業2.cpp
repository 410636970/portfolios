//410637219  ¿àªy¦Ä 
#include <stdio.h>
#include<stdlib.h>
#include<time.h> 
int main()
{
	int num = 14;
	int size=0;
	size = sizeof(num);   // the size of num is 4 bytes
	
//	printf("%d %d", num, size );
	
	int numarray[3] = {90, 80, 60, };  
	
	//printf("%d %d %d \n", numarray[0], numarray[1], numarray[2]) ;
	//printf("%x %x %x \n", &numarray[0], &numarray[1], &numarray[2]) ;
	
	//printf("%d \n", sizeof(numarray));
	
	int total = 0;
	//total = numarray[0] + numarray[1] + numarray[2];
	

//	total = total + numarray[0];  // = assign
	
	
//	total = total + numarray[1]; 
	
//	total = total + numarray[2];
	
//	int total  =  0;
	
	
	int index=0;

	while(index < sizeof(numarray)/sizeof(int) ) {
     
	  total = total + numarray[index]; 		
     
	  index=index+1;
	}

	//printf("%d \n", total);
	
	srand(time(NULL));
	int randnum[4];
	randnum[0]=rand()%49+1;
	randnum[1]=rand()%49+1;
	randnum[2]=rand()%49+1;
	randnum[3]=rand()%49+1;
	printf("%d %d %d %d \n",rand(),rand(),rand(),rand());
	
	int total2 = 0;
	int index2[0];
	int size2=sizeof(randnum)/sizeof(index);
	int i=0;
	while(i<size){
		total2+=randnum[i];
		i++;
	}
	//for(int i=0;i<3;i++){
	//	total2=total2+randnum[i];
	//	i++;}
	printf("%d \n",total2);
	//printf("%d \n",index);
	
}
