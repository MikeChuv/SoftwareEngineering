//---------------------------------------------------------------------------

#ifndef TaskH
#define TaskH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ExtCtrls.hpp>
#include <Vcl.Grids.hpp>
//---------------------------------------------------------------------------
class TFormTask : public TForm
{
__published:	// IDE-managed Components
	TRadioGroup *TaskSelectRG;
	TLabeledEdit *UniquePartEdit;
	TStringGrid *OutputSG;
	TButton *OKbtn;
	void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
	void __fastcall OKbtnClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TFormTask(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFormTask *FormTask;
//---------------------------------------------------------------------------
#endif
