#include "my_410636970.h"


void display(void){ 	
	puts("(A)��J�ӤH���");
	puts("(B)��J���Z���");
	puts("(C)�p�⦨�Z���");
	puts("(D)�п�J���Z�ɦW");
	puts("(E)���}���{���C");
	puts("please select A-E.");
}


void A(void){
	srand(time(NULL));
	
	//class
	int c;
	printf("choose your class is:(1)��u�@A (2)��u�@B (3)��u�GA (4)��u�GB (5)��u�TA (6)��u�TB (7)��u�|A (8)��u�|B\n");
	puts("�п�J1~8");
	scanf("%d",&c);
	while(1){
		if(c==1){printf("class is ��u�@A\n");break;}
		else if(c==2){printf("class is ��u�@B\n");break;}
		else if(c==3){printf("class is ��u�GA\n");break;}
		else if(c==4){printf("class is ��u�GB\n");break;}
		else if(c==5){printf("class is ��u�TA\n");break;}
		else if(c==6){printf("class is ��u�TB\n");break;}
		else if(c==7){printf("class is ��u�|A\n");break;}
		else if(c==8){printf("class is ��u�|B\n");break;}
		else {
			puts("��J���~ �п�J���1~8\n");
			fflush(stdin);
			scanf("%d",&c);
		}
	}

	//stuID
	printf("stuID is 10%d%d%d%d%d%d\n",rand()%10,rand()%10,rand()%10,rand()%10,rand()%10,rand()%10);
	
	//�����魫
	puts("�п�J�����魫:");
 	scanf("%f %f",&psl.height,&psl.weight) ;
	printf("height is %f .\n",psl.height);
	printf("weight is %f .\n",psl.weight);
	 
	//cellphone number
	puts("�п�J�q�ܸ��X");
	scanf("%s",&psl.cellphone);
	printf("cellphone number is %s\n",psl.cellphone);
	
	//break�{�� 
	printf("\n");
	int menu;
	puts("�п�J�Ʀr0�H�^��MENU�C");
	scanf("%d",&menu);
	fflush(stdin);
	
	
}

void B(void){
	srand(time(NULL));
	
	//��ܽҵ{�W�� 
	puts("�п�ܽҵ{(1)C�y�� (2)Java�{�] (3)�p�� (4)�^��");
	puts("�п�J1~4");
	int c1;
	scanf("%d",&c1);
	
	//��J���Z 
	int score;
	if(c1==1){
		puts("�п�JC�y���������Z");
		fflush(stdin);
		scanf("%d",&score);
		clscore3=score;
		clscore1=rand()%100;
		clscore2=rand()%100;
		clscore=clscore1*0.3+clscore2*0.3+clscore3*0.4;
		printf("���ɦ��Z�G%d\n�������Z�G%d\n�������Z�G%d\n",clscore1,clscore2,clscore3);
		printf("�`���Z=%d",clscore);
	}
	else if(c1==2){
		puts("�п�JJava�y���������Z");
		fflush(stdin);
		scanf("%d",&score);
		jlscore3=score;
		jlscore1=rand()%100;
		jlscore2=rand()%100;
		jlscore=jlscore1*0.3+jlscore2*0.3+jlscore3*0.4;
		printf("���ɦ��Z�G%d\n�������Z�G%d\n�������Z�G%d\n",jlscore1,jlscore2,jlscore3);
		printf("�`���Z=%d",jlscore);
	}
	else if(c1==3){
		puts("�п�J�p���������Z");
		fflush(stdin);
		scanf("%d",&score);
		glscore3=score;
		glscore1=rand()%100;
		glscore2=rand()%100;
		glscore=glscore1*0.3+glscore2*0.3+glscore3*0.4;
		printf("���ɦ��Z�G%d\n�������Z�G%d\n�������Z�G%d\n",glscore1,glscore2,glscore3);
		printf("�`���Z=%d",glscore);
	}
	else if(c1==4){
		puts("�п�J�^��������Z");
		fflush(stdin);
		scanf("%d",&score);
		elscore3=score;
		elscore1=rand()%100;
		elscore2=rand()%100;
		elscore=elscore1*0.3+elscore2*0.3+elscore3*0.4;
		printf("���ɦ��Z�G%d\n�������Z�G%d\n�������Z�G%d\n",elscore1,elscore2,elscore3);
		printf("�`���Z=%d",elscore);
	}
	
	//break�{�� 
	printf("\n");
	int menu;
	puts("�п�J�Ʀr0�H�^��MENU�C");
	scanf("%d",&menu);
	fflush(stdin);
}

void C(void){
	//�`���Z�Ƨ�
	if(clscore<jlscore<glscore<elscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("C�y���G%d Java�G%d �p���G%d �^��G%d",clscore,jlscore,glscore,elscore);
	}
	else if(clscore<jlscore<elscore<glscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("C�y���G%d Java�G%d �^��G%d �p���G%d",clscore,jlscore,elscore,glscore);
	}
	else if(clscore<glscore<jlscore<elscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("C�y���G%d �p���G%d Java�G%d �^��G%d",clscore,glscore,jlscore,elscore);
	}
	else if(clscore<glscore<elscore<jlscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("C�y���G%d �p���G%d �^��G%d Java�G%d",clscore,glscore,elscore,jlscore);
	}
	else if(clscore<elscore<glscore<jlscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("C�y���G%d �^��G%d �p���G%d Java�G%d",clscore,elscore,glscore,jlscore);
	}
	else if(clscore<elscore<jlscore<glscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("C�y���G%d �^��G%d Java�G%d �p���G%d",clscore,elscore,jlscore,glscore);
	}
	
	else if(jlscore<clscore<elscore<glscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("Java�G%d C�y���G%d �^��G%d �p���G%d",jlscore,clscore,elscore,glscore);
	}
	else if(jlscore<clscore<glscore<elscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("Java�G%d C�y���G%d �p���G%d �^��G%d",jlscore,clscore,glscore,elscore);
	}
	else if(jlscore<elscore<clscore<glscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("Java�G%d �^��G%d C�y���G%d �p���G%d",jlscore,elscore,clscore,glscore);
	}
	else if(jlscore<elscore<glscore<clscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("Java�G%d �^��G%d �p���G%d C�y���G%d",jlscore,elscore,glscore,clscore);
	}
	else if(jlscore<glscore<elscore<clscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("Java�G%d �p���G%d �^��G%d C�y���G%d",jlscore,glscore,elscore,clscore);
	}
	else if(jlscore<glscore<clscore<elscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("Java�G%d �p���G%d C�y���G%d �^��G%d",jlscore,glscore,clscore,elscore);
	}
	
	else if(glscore<clscore<jlscore<elscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�p���G%d C�y���G%d Java�G%d �^��G%d",glscore,clscore,jlscore,elscore);
	}
	else if(glscore<clscore<elscore<jlscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�p���G%d C�y���G%d �^��G%d Java�G%d",glscore,clscore,elscore,jlscore);
	}
	else if(glscore<jlscore<clscore<elscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�p���G%d Java�G%d C�y���G%d �^��G%d",glscore,jlscore,clscore,elscore);
	}
	else if(glscore<jlscore<elscore<clscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�p���G%d Java�G%d �^��G%d C�y���G%d",glscore,jlscore,elscore,clscore);
	}
	else if(glscore<elscore<jlscore<clscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�p���G%d �^��G%d Java�G%d C�y���G%d",glscore,elscore,jlscore,clscore);
	}
	else if(glscore<elscore<clscore<jlscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�p���G%d �^��G%d C�y���G%d Java�G%d",glscore,elscore,clscore,jlscore);
	}
	
	else if(elscore<glscore<jlscore<clscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�^��G%d �p���G%d Java�G%d C�y���G%d",elscore,glscore,jlscore,clscore);
	}
	else if(elscore<glscore<clscore<jlscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�^��G%d �p���G%d C�y���G%d Java�G%d",elscore,glscore,clscore,jlscore);
	}
	else if(elscore<jlscore<glscore<clscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�^��G%d Java�G%d �p���G%d C�y���G%d",elscore,jlscore,glscore,clscore);
	}
	else if(elscore<jlscore<clscore<glscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�^��G%d Java�G%d C�y���G%d �p���G%d",elscore,jlscore,clscore,glscore);
	}
	else if(elscore<clscore<jlscore<glscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�^��G%d C�y���G%d Java�G%d �p���G%d",elscore,clscore,jlscore,glscore);
	}
	else if(elscore<clscore<glscore<jlscore){
		printf("�U���`���Z�ƧǡG\n");
		printf("�^��G%d C�y���G%d �p���G%d Java�G%d",elscore,clscore,glscore,jlscore);
	}
	
	printf("\n");
	
	//�̰��̧C�������Z
	puts("�̰��̧C�������Z�G");
	if(clscore2>elscore2&&clscore2>glscore2&&clscore2>jlscore2)
		printf("C�y���G%d",clscore2);
	else if(elscore2>clscore2&&elscore2>glscore2&&elscore2>jlscore2)
		printf("�^��G%d",elscore2);
	else if(jlscore2>elscore2&&jlscore2>glscore2&&jlscore2>clscore2)
		printf("Java�y���G%d",jlscore2);
	else if(glscore2>elscore2&&glscore2>clscore2&&glscore2>jlscore2)
		printf("�p���G%d",glscore2);
	
	if(clscore2<elscore2&&clscore2<glscore2&&clscore2<jlscore2)
		printf("C�y���G%d",clscore2);
	else if(elscore2<clscore2&&elscore2<glscore2&&elscore2<jlscore2)
		printf("�^��G%d",elscore2);
	else if(jlscore2<elscore2&&jlscore2<glscore2&&jlscore2<clscore2)
		printf("Java�y���G%d",jlscore2);
	else if(glscore2<elscore2&&glscore2<clscore2&&glscore2<jlscore2)
		printf("�p���G%d",glscore2);
		
	printf("\n");
	
	//�̰��̧C�������Z
	puts("�̰��̧C�������Z�G");
	if(clscore3>elscore3&&clscore3>glscore3&&clscore3>jlscore3)
		printf("C�y���G%d",clscore3);
	else if(elscore3>clscore3&&elscore3>glscore3&&elscore3>jlscore3)
		printf("�^��G%d",elscore3);
	else if(jlscore3>elscore3&&jlscore3>glscore3&&jlscore3>clscore3)
		printf("Java�y���G%d",jlscore3);
	else if(glscore3>elscore3&&glscore3>clscore3&&glscore3>jlscore3)
		printf("�p���G%d",glscore3);
	
	if(clscore3<elscore3&&clscore3<glscore3&&clscore3<jlscore3)
		printf("C�y���G%d",clscore3);
	else if(elscore3<clscore3&&elscore3<glscore3&&elscore3<jlscore3)
		printf("�^��G%d",elscore3);
	else if(jlscore3<elscore3&&jlscore3<glscore3&&jlscore3<clscore3)
		printf("Java�y���G%d",jlscore3);
	else if(glscore3<elscore3&&glscore3<clscore3&&glscore3<jlscore3)
		printf("�p���G%d",glscore3);
		
	printf("\n");
	
	//�̰��̧C�`���Z
	puts("�̰��̧C�`���Z�G");
	if(clscore>elscore&&clscore>glscore&&clscore>jlscore)
		printf("C�y���G%d",clscore);
	else if(elscore>clscore&&elscore>glscore&&elscore>jlscore)
		printf("�^��G%d",elscore);
	else if(jlscore>elscore&&jlscore>glscore&&jlscore>clscore)
		printf("Java�y���G%d",jlscore);
	else if(glscore>elscore&&glscore>clscore&&glscore>jlscore)
		printf("�p���G%d",glscore);
	
	if(clscore<elscore&&clscore<glscore&&clscore<jlscore)
		printf("C�y���G%d",clscore);
	else if(elscore<clscore&&elscore<glscore&&elscore<jlscore)
		printf("�^��G%d",elscore);
	else if(jlscore<elscore&&jlscore<glscore&&jlscore<clscore)
		printf("Java�y���G%d",jlscore);
	else if(glscore<elscore&&glscore<clscore&&glscore<jlscore)
		printf("�p���G%d",glscore);
		
	printf("\n");
	
	//break�{�� 
	printf("\n");
	int menu;
	puts("�п�J�Ʀr0�H�^��MENU�C");
	scanf("%d",&menu);
	fflush(stdin);
}


