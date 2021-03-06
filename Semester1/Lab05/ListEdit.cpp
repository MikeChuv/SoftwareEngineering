//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "ListEdit.h"
#include "MainWindow.h"
//---------------------------------------------------------------------------
#include "map"
#include "list"
#include "algorithm"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFormListEdit *FormListEdit;

extern std::map<AnsiString, Zoo> ZooMap1;
extern std::map<AnsiString, Zoo>::iterator ZooIt1, ZooIt2, ZooIt3;
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
	ZooEdit -> Text = ZooIt3 -> first;
	SpeciesEdit -> Text = ZooIt3 -> second.Species;
	UniqueSpeciesEdit -> Text = ZooIt3 -> second.UniqueSpecies;
	if(++ZooIt3 == ZooMap1.end()){
		NextBtn -> Enabled = false;
	}
	ZooIt3--;
}
//---------------------------------------------------------------------------
void __fastcall TFormListEdit::PrevBtnClick(TObject *Sender)
{
	NextBtn -> Enabled = true;
	ZooIt3--;
	ZooEdit -> Text = ZooIt3 -> first;
	SpeciesEdit -> Text = ZooIt3 -> second.Species;
	UniqueSpeciesEdit -> Text = ZooIt3 -> second.UniqueSpecies;
	if(ZooIt3 == ZooMap1.begin()){
		PrevBtn -> Enabled = false;
	}
}
//---------------------------------------------------------------------------
void __fastcall TFormListEdit::DeleteBtnClick(TObject *Sender)
{
	AnsiString msg = "??????? ( " + ZooIt3 -> first + " ) ?";
	int BtnSelected = MessageDlg(msg, mtConfirmation, TMsgDlgButtons() << mbYes << mbNo,0);
	if(BtnSelected == 6){
		ZooMap1.erase(ZooIt3);
	}

}
//---------------------------------------------------------------------------
void __fastcall TFormListEdit::ChangeBtnClick(TObject *Sender)
{
    AnsiString zname = ZooEdit -> Text;
	int Sp = StrToInt(SpeciesEdit -> Text);
	int UnSp = StrToInt(UniqueSpeciesEdit -> Text);
	if(UnSp > Sp){
		ShowMessage("??????? ??????? ?????? (?????????? ????? ??????)");
	}
	else{
		ZooMap1.erase(ZooIt3);
		Zoo el;
		el.input(Sp, UnSp);
		ZooMap1[zname] = el;
	}
}
//---------------------------------------------------------------------------
