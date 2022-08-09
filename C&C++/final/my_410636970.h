#include <stdio.h>
#include <stdlib.h> 
#include <string.h>
#include <time.h>
#define MAX 255

typedef struct{
	char name[MAX];
	char stdID[MAX];
	float height,weight;
	char cellphone[MAX];
}Personal;

Personal psl;

char choice;
int count;

int clscore1,clscore2,clscore3;
int jlscore1,jlscore2,jlscore3;
int glscore1,glscore2,glscore3;
int elscore1,elscore2,elscore3;
int clscore,jlscore,glscore,elscore;

char lname[];
int lscore[];

