//��u�@A �i�ɺ� 410636970 �������ءGA B C E // 
#include "my_410636970.h"


void show(Person);

int main(int argc,char *argv[]) {
	//srand(time(NULL));
	count=0;
	while(1){
		//system("CLS");
		display();
		scanf("%c",&choice);
		if(choice=='A'){
			//name
			strcpy(psl.name,"XXX");
			if(argv[1]!=NULL)
				strcpy(psl.name,argv[1]);
			printf("name is %s .\n",psl.name);
			
 			A();
 			count++;
		}
		else if(choice=='B'){
			if(count!=0)
				B();
			else{
				puts("�Х���J�ӤH��ơA��0��^MENU");
				int nt;
				scanf("%d",&nt);
				system("CLS");
				fflush(stdin);
			}
		}
		else if(choice=='C'){
			C();	
		}
		/*else if(choice=='D'){
			printf("�ͤ�=%d/%d/%d , bmi=%f,cprogram=%c",birthday[0],birthday[1],birthday[2],bmi,grade);
			break;
		}*/
		else if(choice=='E')
			return 0;
		else{
			puts("��J���~�A�п�JA-E");
		}
			
	}
}

