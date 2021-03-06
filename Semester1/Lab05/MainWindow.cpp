//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "MainWindow.h"
#include "About.h"
#include "FirstListEdit.h"
#include "ListEdit.h"
#include "Task.h"

#include "list"
#include "map"
#include "algorithm"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFormMain *FormMain;

std::map<AnsiString, Zoo> ZooMap1;
std::map<AnsiString, Zoo>::iterator ZooIt1, ZooIt2, ZooIt3;
//---------------------------------------------------------------------------
__fastcall TFormMain::TFormMain(TComponent* Owner)
	: TForm(Owner)
{
	ZooIt1 = ZooMap1.begin();
	ZooIt3 = ZooIt1;
}
//---------------------------------------------------------------------------
void __fastcall TFormMain::Exit1Click(TObject *Sender)
{
	Close();
}
//---------------------------------------------------------------------------
void __fastcall TFormMain::About1Click(TObject *Sender)
{
    AboutBox -> ShowModal();
}
//---------------------------------------------------------------------------
void __fastcall TFormMain::Input1Click(TObject *Sender)
{
	FormListInput = new TFormListInput(this);
	FormListInput -> Show();
}
//---------------------------------------------------------------------------
void __fastcall TFormMain::Edit1Click(TObject *Sender)
{
	FormListEdit = new TFormListEdit(this);
	FormListEdit -> Show();
}
//---------------------------------------------------------------------------
void __fastcall TFormMain::ask1Click(TObject *Sender)
{
	FormTask = new TFormTask(this);
	FormTask -> Show();
}
//---------------------------------------------------------------------------
