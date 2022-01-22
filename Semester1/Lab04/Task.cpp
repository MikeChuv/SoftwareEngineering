//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Task.h"
#include "MainWindow.h"
//---------------------------------------------------------------------------
#include "list"
#include "algorithm"
#include "iostream"
#include "vector"
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
	OutputSG -> Cells[0][0] = "Зоопарк";
	OutputSG -> Cells[1][0] = "Видов";
	OutputSG -> Cells[2][0] = "Редких";
}
//---------------------------------------------------------------------------
void __fastcall TFormTask::FormClose(TObject *Sender, TCloseAction &Action)
{
    Action = caFree;
}
//---------------------------------------------------------------------------
void __fastcall TFormTask::OKbtnClick(TObject *Sender)
{

	// первый вариант - макс кол-во редких
	if(TaskSelectRG -> ItemIndex == 0){

		// max_element - возвращает итератор
		auto maxIt = std::max_element(ZooList1.begin(), ZooList1.end(), [](Zoo el1, Zoo el2){
			return el1.UniqueSpecies < el2.UniqueSpecies;
		});

		// возвращает int
		auto count = std::count_if(ZooList1.begin(), ZooList1.end(), [maxIt](Zoo el){
			return el.UniqueSpecies == maxIt -> UniqueSpecies;
		});


		ZooIt2 = ZooList1.begin();
		OutputSG -> RowCount = count + 1;
		for(int i = 1; ZooIt2 != ZooList1.end(); ZooIt2++){
			if(ZooIt2 -> UniqueSpecies == maxIt -> UniqueSpecies){

				OutputSG -> Cells[0][i] = ZooIt2 -> ZooName;
				OutputSG -> Cells[1][i] = IntToStr(ZooIt2 -> Species);
				OutputSG -> Cells[2][i] = IntToStr(ZooIt2 -> UniqueSpecies);
                i++;
			}
		}


	}

	// второй вариант - доля редких меньше заданного
	if(TaskSelectRG -> ItemIndex == 1){



		float part = StrToFloat(UniquePartEdit -> Text);
		int i = 0;
        OutputSG -> RowCount = 1;
		for_each(ZooList1.begin(), ZooList1.end(), [part, this, i](Zoo el)mutable{
			float iPart = (float)el.UniqueSpecies / el.Species;
			if(iPart < part){
				OutputSG -> RowCount++;
				i++;
				OutputSG -> Cells[0][i] = el.ZooName;
				OutputSG -> Cells[1][i] = el.Species;
				OutputSG -> Cells[2][i] = el.UniqueSpecies;

				}
		});



	}
}
//---------------------------------------------------------------------------
