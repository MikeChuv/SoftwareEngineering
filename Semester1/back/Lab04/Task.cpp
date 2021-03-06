//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Task.h"
#include "MainWindow.h"
//---------------------------------------------------------------------------
#include "list"
#include "algorithm"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFormTask *FormTask;

extern std::list<Zoo>ZooList1;
extern std::list<Zoo>::iterator ZooIt1, ZooIt2, ZooIt3;
//---------------------------------------------------------------------------
__fastcall TFormTask::TFormTask(TComponent* Owner)
	: TForm(Owner)
{
	OutputSG -> DefaultColWidth = (int)OutputSG -> Width / 3 - 2;
	OutputSG -> Cells[0][0] = "???????";
	OutputSG -> Cells[1][0] = "?????";
	OutputSG -> Cells[2][0] = "??????";
}
//---------------------------------------------------------------------------
void __fastcall TFormTask::FormClose(TObject *Sender, TCloseAction &Action)
{
    Action = caFree;
}
//---------------------------------------------------------------------------
void __fastcall TFormTask::OKbtnClick(TObject *Sender)
{


	if(TaskSelectRG -> ItemIndex == 0){
		ZooIt2 = ZooList1.begin();
		int max = ZooList1.begin() -> UniqueSpecies;
		int count = 1;
		for (ZooIt2 = ZooList1.begin()++; ZooIt2 != ZooList1.end(); ZooIt2++){
			if(ZooIt2 -> UniqueSpecies > max) {
				max = ZooIt2 -> UniqueSpecies;
				count = 1;
			}
			if(ZooIt2 -> UniqueSpecies == max) count++;
		}
		ZooIt2 = ZooList1.begin();
		OutputSG -> RowCount = count;
		for(int i = 1; ZooIt2 != ZooList1.end(); i++, ZooIt2++){
			if(ZooIt2 -> UniqueSpecies == max){

				OutputSG -> Cells[0][i] = ZooIt2 -> ZooName;
				OutputSG -> Cells[1][i] = IntToStr(ZooIt2 -> Species);
				OutputSG -> Cells[2][i] = IntToStr(ZooIt2 -> UniqueSpecies);
			}
		}

	}

	if(TaskSelectRG -> ItemIndex == 1){
		float part = StrToFloat(UniquePartEdit -> Text);

		int i = 0;
		OutputSG -> RowCount = 1;
		for(ZooIt2 = ZooList1.begin(); ZooIt2 != ZooList1.end(); ZooIt2++){
			float iPart = (float)ZooIt2 -> UniqueSpecies / ZooIt2 -> Species;
			if(iPart < part){
				OutputSG -> RowCount++;
				i++;
				OutputSG -> Cells[0][i] = ZooIt2 -> ZooName;
				OutputSG -> Cells[1][i] = IntToStr(ZooIt2 -> Species);
				OutputSG -> Cells[2][i] = IntToStr(ZooIt2 -> UniqueSpecies);

			}
		}

	}
}
//---------------------------------------------------------------------------
