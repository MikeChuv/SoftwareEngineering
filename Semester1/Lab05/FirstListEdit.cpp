//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "FirstListEdit.h"
#include "MainWindow.h"
//---------------------------------------------------------------------------
#include "map"
#include "list"
#include "algorithm"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFormListInput *FormListInput;

extern std::map<AnsiString, Zoo> ZooMap1;
extern std::map<AnsiString, Zoo>::iterator ZooIt1, ZooIt2, ZooIt3;
//---------------------------------------------------------------------------
__fastcall TFormListInput::TFormListInput(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TFormListInput::FormClose(TObject *Sender, TCloseAction &Action)
{
	Action = caFree;
}
//---------------------------------------------------------------------------
void __fastcall TFormListInput::InputBtnClick(TObject *Sender)
{
	AnsiString zname = ZooEdit -> Text;
	int Sp = StrToInt(SpeciesEdit -> Text);
	int UnSp = StrToInt(UniqueSpeciesEdit -> Text);
	if(UnSp > Sp){
		ShowMessage("Неверно введены данные (уникальных видов больше)");
	}
	else{
		Zoo el;
		el.input(Sp, UnSp);
		ZooMap1[zname] = el;
		// ShowMessage(ZooList1.size());
		SpeciesEdit -> Text = "";
		UniqueSpeciesEdit -> Text = "";
		ZooEdit -> Text = "";
	}
}
//---------------------------------------------------------------------------
