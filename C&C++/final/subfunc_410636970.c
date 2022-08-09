#include "my_410636970.h"


void display(void){ 	
	puts("(A)輸入個人資料");
	puts("(B)輸入成績資料");
	puts("(C)計算成績資料");
	puts("(D)請輸入成績檔名");
	puts("(E)離開此程式。");
	puts("please select A-E.");
}


void A(void){
	srand(time(NULL));
	
	//class
	int c;
	printf("choose your class is:(1)資工一A (2)資工一B (3)資工二A (4)資工二B (5)資工三A (6)資工三B (7)資工四A (8)資工四B\n");
	puts("請輸入1~8");
	scanf("%d",&c);
	while(1){
		if(c==1){printf("class is 資工一A\n");break;}
		else if(c==2){printf("class is 資工一B\n");break;}
		else if(c==3){printf("class is 資工二A\n");break;}
		else if(c==4){printf("class is 資工二B\n");break;}
		else if(c==5){printf("class is 資工三A\n");break;}
		else if(c==6){printf("class is 資工三B\n");break;}
		else if(c==7){printf("class is 資工四A\n");break;}
		else if(c==8){printf("class is 資工四B\n");break;}
		else {
			puts("輸入錯誤 請輸入選擇1~8\n");
			fflush(stdin);
			scanf("%d",&c);
		}
	}

	//stuID
	printf("stuID is 10%d%d%d%d%d%d\n",rand()%10,rand()%10,rand()%10,rand()%10,rand()%10,rand()%10);
	
	//身高體重
	puts("請輸入身高體重:");
 	scanf("%f %f",&psl.height,&psl.weight) ;
	printf("height is %f .\n",psl.height);
	printf("weight is %f .\n",psl.weight);
	 
	//cellphone number
	puts("請輸入電話號碼");
	scanf("%s",&psl.cellphone);
	printf("cellphone number is %s\n",psl.cellphone);
	
	//break程序 
	printf("\n");
	int menu;
	puts("請輸入數字0以回到MENU。");
	scanf("%d",&menu);
	fflush(stdin);
	
	
}

void B(void){
	srand(time(NULL));
	
	//選擇課程名稱 
	puts("請選擇課程(1)C語言 (2)Java程設 (3)計概 (4)英文");
	puts("請輸入1~4");
	int c1;
	scanf("%d",&c1);
	
	//輸入成績 
	int score;
	if(c1==1){
		puts("請輸入C語言期末成績");
		fflush(stdin);
		scanf("%d",&score);
		clscore3=score;
		clscore1=rand()%100;
		clscore2=rand()%100;
		clscore=clscore1*0.3+clscore2*0.3+clscore3*0.4;
		printf("平時成績：%d\n期中成績：%d\n期末成績：%d\n",clscore1,clscore2,clscore3);
		printf("總成績=%d",clscore);
	}
	else if(c1==2){
		puts("請輸入Java語言期末成績");
		fflush(stdin);
		scanf("%d",&score);
		jlscore3=score;
		jlscore1=rand()%100;
		jlscore2=rand()%100;
		jlscore=jlscore1*0.3+jlscore2*0.3+jlscore3*0.4;
		printf("平時成績：%d\n期中成績：%d\n期末成績：%d\n",jlscore1,jlscore2,jlscore3);
		printf("總成績=%d",jlscore);
	}
	else if(c1==3){
		puts("請輸入計概期末成績");
		fflush(stdin);
		scanf("%d",&score);
		glscore3=score;
		glscore1=rand()%100;
		glscore2=rand()%100;
		glscore=glscore1*0.3+glscore2*0.3+glscore3*0.4;
		printf("平時成績：%d\n期中成績：%d\n期末成績：%d\n",glscore1,glscore2,glscore3);
		printf("總成績=%d",glscore);
	}
	else if(c1==4){
		puts("請輸入英文期末成績");
		fflush(stdin);
		scanf("%d",&score);
		elscore3=score;
		elscore1=rand()%100;
		elscore2=rand()%100;
		elscore=elscore1*0.3+elscore2*0.3+elscore3*0.4;
		printf("平時成績：%d\n期中成績：%d\n期末成績：%d\n",elscore1,elscore2,elscore3);
		printf("總成績=%d",elscore);
	}
	
	//break程序 
	printf("\n");
	int menu;
	puts("請輸入數字0以回到MENU。");
	scanf("%d",&menu);
	fflush(stdin);
}

void C(void){
	//總成績排序
	if(clscore<jlscore<glscore<elscore){
		printf("各科總成績排序：\n");
		printf("C語言：%d Java：%d 計概：%d 英文：%d",clscore,jlscore,glscore,elscore);
	}
	else if(clscore<jlscore<elscore<glscore){
		printf("各科總成績排序：\n");
		printf("C語言：%d Java：%d 英文：%d 計概：%d",clscore,jlscore,elscore,glscore);
	}
	else if(clscore<glscore<jlscore<elscore){
		printf("各科總成績排序：\n");
		printf("C語言：%d 計概：%d Java：%d 英文：%d",clscore,glscore,jlscore,elscore);
	}
	else if(clscore<glscore<elscore<jlscore){
		printf("各科總成績排序：\n");
		printf("C語言：%d 計概：%d 英文：%d Java：%d",clscore,glscore,elscore,jlscore);
	}
	else if(clscore<elscore<glscore<jlscore){
		printf("各科總成績排序：\n");
		printf("C語言：%d 英文：%d 計概：%d Java：%d",clscore,elscore,glscore,jlscore);
	}
	else if(clscore<elscore<jlscore<glscore){
		printf("各科總成績排序：\n");
		printf("C語言：%d 英文：%d Java：%d 計概：%d",clscore,elscore,jlscore,glscore);
	}
	
	else if(jlscore<clscore<elscore<glscore){
		printf("各科總成績排序：\n");
		printf("Java：%d C語言：%d 英文：%d 計概：%d",jlscore,clscore,elscore,glscore);
	}
	else if(jlscore<clscore<glscore<elscore){
		printf("各科總成績排序：\n");
		printf("Java：%d C語言：%d 計概：%d 英文：%d",jlscore,clscore,glscore,elscore);
	}
	else if(jlscore<elscore<clscore<glscore){
		printf("各科總成績排序：\n");
		printf("Java：%d 英文：%d C語言：%d 計概：%d",jlscore,elscore,clscore,glscore);
	}
	else if(jlscore<elscore<glscore<clscore){
		printf("各科總成績排序：\n");
		printf("Java：%d 英文：%d 計概：%d C語言：%d",jlscore,elscore,glscore,clscore);
	}
	else if(jlscore<glscore<elscore<clscore){
		printf("各科總成績排序：\n");
		printf("Java：%d 計概：%d 英文：%d C語言：%d",jlscore,glscore,elscore,clscore);
	}
	else if(jlscore<glscore<clscore<elscore){
		printf("各科總成績排序：\n");
		printf("Java：%d 計概：%d C語言：%d 英文：%d",jlscore,glscore,clscore,elscore);
	}
	
	else if(glscore<clscore<jlscore<elscore){
		printf("各科總成績排序：\n");
		printf("計概：%d C語言：%d Java：%d 英文：%d",glscore,clscore,jlscore,elscore);
	}
	else if(glscore<clscore<elscore<jlscore){
		printf("各科總成績排序：\n");
		printf("計概：%d C語言：%d 英文：%d Java：%d",glscore,clscore,elscore,jlscore);
	}
	else if(glscore<jlscore<clscore<elscore){
		printf("各科總成績排序：\n");
		printf("計概：%d Java：%d C語言：%d 英文：%d",glscore,jlscore,clscore,elscore);
	}
	else if(glscore<jlscore<elscore<clscore){
		printf("各科總成績排序：\n");
		printf("計概：%d Java：%d 英文：%d C語言：%d",glscore,jlscore,elscore,clscore);
	}
	else if(glscore<elscore<jlscore<clscore){
		printf("各科總成績排序：\n");
		printf("計概：%d 英文：%d Java：%d C語言：%d",glscore,elscore,jlscore,clscore);
	}
	else if(glscore<elscore<clscore<jlscore){
		printf("各科總成績排序：\n");
		printf("計概：%d 英文：%d C語言：%d Java：%d",glscore,elscore,clscore,jlscore);
	}
	
	else if(elscore<glscore<jlscore<clscore){
		printf("各科總成績排序：\n");
		printf("英文：%d 計概：%d Java：%d C語言：%d",elscore,glscore,jlscore,clscore);
	}
	else if(elscore<glscore<clscore<jlscore){
		printf("各科總成績排序：\n");
		printf("英文：%d 計概：%d C語言：%d Java：%d",elscore,glscore,clscore,jlscore);
	}
	else if(elscore<jlscore<glscore<clscore){
		printf("各科總成績排序：\n");
		printf("英文：%d Java：%d 計概：%d C語言：%d",elscore,jlscore,glscore,clscore);
	}
	else if(elscore<jlscore<clscore<glscore){
		printf("各科總成績排序：\n");
		printf("英文：%d Java：%d C語言：%d 計概：%d",elscore,jlscore,clscore,glscore);
	}
	else if(elscore<clscore<jlscore<glscore){
		printf("各科總成績排序：\n");
		printf("英文：%d C語言：%d Java：%d 計概：%d",elscore,clscore,jlscore,glscore);
	}
	else if(elscore<clscore<glscore<jlscore){
		printf("各科總成績排序：\n");
		printf("英文：%d C語言：%d 計概：%d Java：%d",elscore,clscore,glscore,jlscore);
	}
	
	printf("\n");
	
	//最高最低期中成績
	puts("最高最低期中成績：");
	if(clscore2>elscore2&&clscore2>glscore2&&clscore2>jlscore2)
		printf("C語言：%d",clscore2);
	else if(elscore2>clscore2&&elscore2>glscore2&&elscore2>jlscore2)
		printf("英文：%d",elscore2);
	else if(jlscore2>elscore2&&jlscore2>glscore2&&jlscore2>clscore2)
		printf("Java語言：%d",jlscore2);
	else if(glscore2>elscore2&&glscore2>clscore2&&glscore2>jlscore2)
		printf("計概：%d",glscore2);
	
	if(clscore2<elscore2&&clscore2<glscore2&&clscore2<jlscore2)
		printf("C語言：%d",clscore2);
	else if(elscore2<clscore2&&elscore2<glscore2&&elscore2<jlscore2)
		printf("英文：%d",elscore2);
	else if(jlscore2<elscore2&&jlscore2<glscore2&&jlscore2<clscore2)
		printf("Java語言：%d",jlscore2);
	else if(glscore2<elscore2&&glscore2<clscore2&&glscore2<jlscore2)
		printf("計概：%d",glscore2);
		
	printf("\n");
	
	//最高最低期末成績
	puts("最高最低期末成績：");
	if(clscore3>elscore3&&clscore3>glscore3&&clscore3>jlscore3)
		printf("C語言：%d",clscore3);
	else if(elscore3>clscore3&&elscore3>glscore3&&elscore3>jlscore3)
		printf("英文：%d",elscore3);
	else if(jlscore3>elscore3&&jlscore3>glscore3&&jlscore3>clscore3)
		printf("Java語言：%d",jlscore3);
	else if(glscore3>elscore3&&glscore3>clscore3&&glscore3>jlscore3)
		printf("計概：%d",glscore3);
	
	if(clscore3<elscore3&&clscore3<glscore3&&clscore3<jlscore3)
		printf("C語言：%d",clscore3);
	else if(elscore3<clscore3&&elscore3<glscore3&&elscore3<jlscore3)
		printf("英文：%d",elscore3);
	else if(jlscore3<elscore3&&jlscore3<glscore3&&jlscore3<clscore3)
		printf("Java語言：%d",jlscore3);
	else if(glscore3<elscore3&&glscore3<clscore3&&glscore3<jlscore3)
		printf("計概：%d",glscore3);
		
	printf("\n");
	
	//最高最低總成績
	puts("最高最低總成績：");
	if(clscore>elscore&&clscore>glscore&&clscore>jlscore)
		printf("C語言：%d",clscore);
	else if(elscore>clscore&&elscore>glscore&&elscore>jlscore)
		printf("英文：%d",elscore);
	else if(jlscore>elscore&&jlscore>glscore&&jlscore>clscore)
		printf("Java語言：%d",jlscore);
	else if(glscore>elscore&&glscore>clscore&&glscore>jlscore)
		printf("計概：%d",glscore);
	
	if(clscore<elscore&&clscore<glscore&&clscore<jlscore)
		printf("C語言：%d",clscore);
	else if(elscore<clscore&&elscore<glscore&&elscore<jlscore)
		printf("英文：%d",elscore);
	else if(jlscore<elscore&&jlscore<glscore&&jlscore<clscore)
		printf("Java語言：%d",jlscore);
	else if(glscore<elscore&&glscore<clscore&&glscore<jlscore)
		printf("計概：%d",glscore);
		
	printf("\n");
	
	//break程序 
	printf("\n");
	int menu;
	puts("請輸入數字0以回到MENU。");
	scanf("%d",&menu);
	fflush(stdin);
}


