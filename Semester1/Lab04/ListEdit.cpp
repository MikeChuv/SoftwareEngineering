//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "ListEdit.h"
#include "MainWindow.h"
//---------------------------------------------------------------------------
#include "list"
#include "algorithm"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFormListEdit *FormListEdit;

extern std::list<Zoo>ZooList1;
extern std::list<Zoo>::iterator ZooIt1, ZooIt2, ZooIt3;
//---------------------------------------------------------------------------
__fastcall TFormListEdit::TFormListEdit(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TFormListEdit::FormClose(TObject *Sender, TCloseAction &Action)
{
	Action = caFree;
}
//---------------------------------------------------------------------------

void __fastcall TFormListEdit::NextBtnClick(TObject *Sender)
{
	PrevBtn -> Enabled = true;
	ZooIt3++;
	ZooEdit -> Text = ZooIt3 -> ZooName;
	SpeciesEdit -> Text = ZooIt3 -> Species;
	UniqueSpeciesEdit -> Text = ZooIt3 -> UniqueSpecies;
	if(++ZooIt3 == ZooList1.end()){
		NextBtn -> Enabled = false;
	}
	ZooIt3--;
}
//---------------------------------------------------------------------------
void __fastcall TFormListEdit::PrevBtnClick(TObject *Sender)
{
	NextBtn -> Enabled = true;
	ZooIt3--;
	ZooEdit -> Text = ZooIt3 -> ZooName;
	SpeciesEdit -> Text = ZooIt3 -> Species;
	UniqueSpeciesEdit -> Text = ZooIt3 -> UniqueSpecies;
	if(ZooIt3 == ZooList1.begin()){
		PrevBtn -> Enabled = false;
	}
}
//---------------------------------------------------------------------------
void __fastcall TFormListEdit::DeleteBtnClick(TObject *Sender)
{
	AnsiString msg = "Удалить ( " + ZooIt3 -> ZooName + " ) ?";
	int BtnSelected = MessageDlg(msg, mtConfirmation, TMsgDlgButtons() << mbYes << mbNo,0);
	if(BtnSelected == 6){
		ZooList1.erase(ZooIt3);
	}

}
//---------------------------------------------------------------------------
void __fastcall TFormListEdit::ChangeBtnClick(TObject *Sender)
{
    AnsiString zname = ZooEdit -> Text;
	int Sp = StrToInt(SpeciesEdit -> Text);
	int UnSp = StrToInt(UniqueSpeciesEdit -> Text);
	if(UnSp > Sp){
		ShowMessage("Неверно введены данные (уникальных видов больше)");
	}
	else{
		ZooIt3 -> ZooName = zname;
		ZooIt3 -> Species = Sp;
		ZooIt3 -> UniqueSpecies = UnSp;

	}
}
//---------------------------------------------------------------------------
